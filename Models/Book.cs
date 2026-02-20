namespace LMS.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(120)]
        public string Author { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Range(1, 9999)]
        public int TotalCopies { get; set; }

        [Range(0, 9999)]
        public int AvailableCopies { get; set; }
    }
}
