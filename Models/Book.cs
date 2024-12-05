namespace BookCatalogApp.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int PublishedYear { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
