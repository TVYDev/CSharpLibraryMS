﻿namespace LibraryManagementSystem.DomainModels
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public int YearEdition { get; set; }

        public string Isbn { get; set; }

        public bool IsBorrowed { get; set; }

        public bool IsDeleted { get; set; }

        public int Qty { get; set; }

        public int QtyAvailable { get; set; }
    }
}