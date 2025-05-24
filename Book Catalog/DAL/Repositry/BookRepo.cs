using Book_Catalog.DAL.Models;

namespace Book_Catalog.DAL.Repositry
{
    public class BookRepo : IBookRepo
    {
        private static readonly List<Book> books = new();
        private static int nextId = 1;
        public Book Create(string title, string author)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
                {
                    throw new ArgumentException("title and author parameters is required.");
                }
                Book book = new Book(title, author);
                book.Id = nextId++;
                books.Add(book);
                return book;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
