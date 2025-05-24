using Book_Catalog.DAL.Models;

namespace Book_Catalog.DAL.Repositry
{
    public interface IBookRepo
    {
        Book Create(string title, string author);
        List<Book> GetBooks();
    }
}
