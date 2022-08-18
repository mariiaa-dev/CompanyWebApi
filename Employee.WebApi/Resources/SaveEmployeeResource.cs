namespace CompanyWebApi.Resources
{
    public class SaveEmployeeResource
    {
        [Required]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can only be 50 characters long")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can only be 50 characters long")]
        public string Surname { get; set; }

        [Required]
        public DateTime EmploymentDate { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        public int PositionId { get; set; }

        [Required]
        public string Mail { get; set; }
    }
}
