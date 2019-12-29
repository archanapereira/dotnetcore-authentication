namespace MyBookApplication.Models
{
    public class Book
    {
        //id
        //title
        //Publisher year
        //publisher name
        //description
        //rating
        //Price
        //author

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
    }
}