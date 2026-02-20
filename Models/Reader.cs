namespace LMS.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Reader
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }
    }
}
