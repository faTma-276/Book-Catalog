namespace Book_Catalog.DAL.Models
{
    public class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public int Id { get; set; }
        public string Title { get;private set; }
        public string Author { get;private set; }
        
    }
}
