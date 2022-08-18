namespace CompanyWebApi.Domains.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Name can only be 50 characters long")]
        public string Name { get; set; }

        public IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}
