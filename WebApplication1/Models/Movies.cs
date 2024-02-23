using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models
{
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        // If CategoryId can be null in the database, make it nullable
        public int? CategoryId { get; set; }

        [Required] // Title is NOT NULL in the database
        public string Title { get; set; }

        [Required] // Year is NOT NULL in the database
        public int Year { get; set; }

        // Director can be NULL in the database, so make it nullable
        public string? Director { get; set; }

        // Rating can be NULL in the database, so make it nullable
        public string? Rating { get; set; }

        // Edited is an INTEGER in SQLite, which is used as a boolean. No change needed.
        // But ensure that this property is handled correctly in your application logic.
        [Required]
        public bool Edited { get; set; }

        // LentTo can be NULL in the database, so make it nullable
        public string? LentTo { get; set; }

        // CopiedToPlex is an INTEGER in SQLite, which is used as a boolean. No change needed.
        // But ensure that this property is handled correctly in your application logic.
        [Required]
        public bool CopiedToPlex { get; set; }

        // Notes can be NULL in the database, so make it nullable
        public string? Notes { get; set; }

        // Define navigation property for Category
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
