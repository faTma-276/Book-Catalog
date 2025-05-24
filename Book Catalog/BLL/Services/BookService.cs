using System.Reflection;
using System.Threading.Tasks;
using Book_Catalog.DAL.Models;
using Book_Catalog.DAL.Repositry;
using Book_Catalog.DTO;

namespace Book_Catalog.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepo bookRepo;

        public BookService(IBookRepo bookRepo)
        {
            this.bookRepo = bookRepo;
        }
        public BookDto Add(BookDto bookDto)
        {
            try
            {
                var book = bookRepo.Create(bookDto.Title, bookDto.Author);
                return new BookDto
                {
                    Title = book.Title,
                    Author = book.Author
                };
            }
            catch (Exception )
            {
                throw;
            }
        }

        public List<BookDto> GetBooks()
        {
            var books = bookRepo.GetBooks();
            var bookDtos = new List<BookDto>(); 
            foreach (Book book in books)
            {
                bookDtos.Add(new BookDto
                {
                    Title = book.Title,
                    Author = book.Author
                });
            }
            if (!bookDtos.Any())
            {
                throw new KeyNotFoundException("No Books Found");

            }
            return bookDtos;
        }
    }
}
