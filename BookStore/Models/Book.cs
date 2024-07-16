using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public enum Language
    {
        English,
        Hindi,
        German,
        Spanish
    }
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author Name is Required")]
        [DisplayName("Author Name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Language is Required")]
        public Language? Language { get; set; }
    }
}
