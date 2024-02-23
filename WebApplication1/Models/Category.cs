namespace Mission6.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Movies> Movies { get; set; } // Navigation property
    }
}