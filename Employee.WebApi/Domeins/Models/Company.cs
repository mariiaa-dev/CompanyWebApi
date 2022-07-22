using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyWebApi.Domeins.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Company's name can only be 20 characters long")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Brand can only be 20 characters long")]
        public string Brand { get; set; }

        [Required]
        public int DirectorId { get; set; }

        [ForeignKey("DirectorId")]
        public Employee Director { get; set; }

        public decimal MounthlyBudget { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}
