using System.ComponentModel.DataAnnotations;

namespace EnterpriseEMS.API.Models;

public class Payslip
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(30)]
    public string PayPeriod { get; set; } = string.Empty;

    [Range(0, 999999999)]
    public decimal BasicSalary { get; set; }

    [Range(0, 999999999)]
    public decimal Allowances { get; set; }

    [Range(0, 999999999)]
    public decimal Deductions { get; set; }

    public decimal NetSalary =>
        BasicSalary + Allowances - Deductions;

    public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;

    public Employee? Employee { get; set; }
}