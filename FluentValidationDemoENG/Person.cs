namespace FluentValidationDemoENG
{
    public class Person
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
