using EnterpriseEMS.API.Controllers.Models;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseEMS.API.Models;

public class Employee
{
    public int Id { get; set; }

    public int UserId { get; set; }

    [Required]
    [MaxLength(50)]
    public string EmployeeNumber { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Position { get; set; } = string.Empty;

    [MaxLength(100)]
    public string Department { get; set; } = string.Empty;

    [MaxLength(20)]
    public string Phone { get; set; } = string.Empty;

    public DateTime? DateOfBirth { get; set; }

    public DateTime DateJoined { get; set; } = DateTime.UtcNow;

    [Range(0, 999999999)]
    public decimal Salary { get; set; }

    [Required]
    [MaxLength(30)]
    public string Status { get; set; } = "Active";

    public User? User { get; set; }

    public ICollection<Attendance> Attendances { get; set; } =
        new List<Attendance>();

    public ICollection<LeaveRequest> LeaveRequests { get; set; } =
        new List<LeaveRequest>();

    public ICollection<Payslip> Payslips { get; set; } =
        new List<Payslip>();
}