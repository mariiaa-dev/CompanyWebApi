namespace CompanyWebApi.Resources
{
    public class SaveCompanyResource
    {
        [MaxLength(20, ErrorMessage = "Company's name can only be 20 characters long")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Brand can only be 20 characters long")]
        public string Brand { get; set; }

        [Required]
        public int DirectorId { get; set; }

        [Required]
        public decimal MounthlyBudget { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }
    }
}
