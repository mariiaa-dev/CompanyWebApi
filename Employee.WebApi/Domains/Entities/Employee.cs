using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyWebApi.Domains.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can only be 50 characters long")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Surname can only be 50 characters long")]
        public string Surname { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public DateTime EmploymentDate { get; set; }

        public DateTime? DismissDate { get; set; }

        public Position Position { get; set; }

        [Required]
        public int PositionId { get; set; }

        public Company Company { get; set; }

        [Required]
        public int CompanyId { get; set; }
    }
}
