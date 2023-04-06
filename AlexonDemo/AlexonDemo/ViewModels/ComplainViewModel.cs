namespace AlexonDemo.ViewModels
{
    public class ComplainViewModel
    {
        public int Id { get; set; }
        public string ComplainType { get; set; }
        public DateTime ComplainDate { get; set; }
        public string City { get; set; } 
        public string Department { get; set; }
        public string Display { get; set; } = null!;
    }
}
