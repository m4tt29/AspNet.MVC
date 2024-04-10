namespace AspNet.MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Genre { get; set; }
        public int ReleaseDate { get; set; }
    }
}
