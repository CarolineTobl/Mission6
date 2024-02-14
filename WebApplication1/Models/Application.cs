using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; } //Just get is a read only variable

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public bool Edited { get; set; } //Will need to change since true and false
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
