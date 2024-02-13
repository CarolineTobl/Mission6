namespace Mission6.Models
{
    public class Application
    {
        public int ApplicationID { get; set; } //Just get is a read only variable
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string Edited { get; set; } //Will need to change since true and false
        public string LentTo { get; set; }
        public string Notes { get; set; }

    }
}
