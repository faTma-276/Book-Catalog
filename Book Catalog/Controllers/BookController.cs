using Book_Catalog.BLL.Services;
using Book_Catalog.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Book_Catalog.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService service;
        public BookController(IBookService service)
        {
            this.service = service;
        }
        [HttpPost]
        public IActionResult Add([FromBody] BookDto book)
        {
            try
            {
                var result = service.Add(book);
                return Ok(new
                {
                    message = "Book Added Successfully",
                    data = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = service.GetBooks();
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
