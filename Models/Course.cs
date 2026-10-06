namespace BootstrapApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructor { get; set; }
        public int Duration { get; set; }      
        public decimal Price { get; set; }
        public string Level { get; set; }      
    }
}