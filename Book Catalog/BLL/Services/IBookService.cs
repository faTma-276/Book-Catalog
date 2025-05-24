using Book_Catalog.DTO;

namespace Book_Catalog.BLL.Services
{
    public interface IBookService
    {
        BookDto Add(BookDto bookDto);
        List<BookDto> GetBooks();
    }
}
