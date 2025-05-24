using System.ComponentModel.DataAnnotations;

namespace Book_Catalog.DTO
{
    public class BookDto
    {
        [Required(ErrorMessage ="Book Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Book Author is Required")]
        public string Author { get; set; }
    }
}
