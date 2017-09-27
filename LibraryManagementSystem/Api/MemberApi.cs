using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem.Api
{
    public static class MemberApi
    {
        public static int RegisterMember(Member member)
        {
            using (var context = new LibraryContext())
            {
                member.DateOfMembership = DateTime.Today;
                member.IsDeleted = false;
                member.MaxBookLimit = PredefinedRules.MaxBookBorrow;
                context.Members.Add(member);
                context.SaveChanges();
                return context.Members.OrderByDescending(m => m.Id).First().Id;
            }
        }

        public static Member LoadMemberDetails(int memberId)
        {
            using (var context = new LibraryContext())
            {
                var member = context.Members.Where(m => m.IsDeleted == false).SingleOrDefault(m => m.Id == memberId);
                if(member == null)
                    throw new InvalidOperationException("Member not found.");

                return member;
            }
        }

        public static IEnumerable<Member> SearchMember (string input, int numbersToSkip)
        {
            using (var context = new LibraryContext())
            {
                int convertedToInt = Convert.ToInt32(input);
                var members = context.Members.Where(m => m.Id == convertedToInt || m.Name.Contains(input))
                                             .OrderBy(m => m.Id)
                                             .Skip(numbersToSkip)
                                             .Take(PredefinedRules.ShownPerPage)
                                             .ToList();
                if (members.Count == 0)
                    throw new InvalidOperationException("Member not found.");
                return members;
            }
        }

        public static void UpdateMember(Member member)
        {
            using (var context = new LibraryContext())
            {
                var memberInDb = context.Members.Where(m => m.IsDeleted == false).SingleOrDefault(m => m.Id == member.Id);
                if(memberInDb == null)
                    throw new InvalidOperationException("Member not found");

                memberInDb.Name = member.Name;
                memberInDb.Phone = member.Phone;
                memberInDb.Address = member.Address;
                memberInDb.Photo = member.Photo;
                context.SaveChanges();
            }
        }

        public static void DeleteMember(int memberId)
        {
            using (var context = new LibraryContext())
            {
                var member = context.Members.Where(m => m.IsDeleted == false).SingleOrDefault(m => m.Id == memberId);
                if (member == null)
                    throw new InvalidOperationException("Member not found");

                member.IsDeleted = true;
                context.SaveChanges();
            }
        }

        public static void UndoDeleteMember(int memberId)
        {
            using (var context = new LibraryContext())
            {
                var member = context.Members.Where(m => m.IsDeleted).SingleOrDefault(m => m.Id == memberId);
                if (member == null)
                    throw new InvalidOperationException("Member not found");

                member.IsDeleted = false;
                context.SaveChanges();
            }
        }
    }
}
