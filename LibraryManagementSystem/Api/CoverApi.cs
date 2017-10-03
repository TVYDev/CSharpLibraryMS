using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem.Api
{
    public static class CoverApi
    {
        public static int AddNewCover(Byte[] bufferImage)
        {
            using (var context = new LibraryContext())
            {
                context.Covers.Add(new Cover { Image = bufferImage });
                context.SaveChanges();

                return context.Covers.OrderByDescending(b => b.Id).First().Id;
            }
        }
    }
}
