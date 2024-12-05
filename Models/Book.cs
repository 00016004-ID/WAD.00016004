﻿namespace BookCatalogApp.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CoverImageURL { get; set; }

        public Category Category { get; set; }  // Navigation property to Category
    }
}
