namespace p1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Class { get; set; } = string.Empty;

        public float CGPA { get; set; }
    }

}