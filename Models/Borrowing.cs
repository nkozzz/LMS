namespace LMS.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Borrowing
    {
        public int Id { get; set; }

        [Required]
        public int ReaderId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }
    }
}
