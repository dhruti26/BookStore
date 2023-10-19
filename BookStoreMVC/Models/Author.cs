using System.ComponentModel.DataAnnotations;

namespace BookStoreMVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
