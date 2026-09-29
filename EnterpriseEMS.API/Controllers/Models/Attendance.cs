using System.ComponentModel.DataAnnotations;

namespace EnterpriseEMS.API.Models;

public class Attendance
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime Date { get; set; } = DateTime.UtcNow.Date;

    public DateTime? CheckInTime { get; set; }

    public DateTime? CheckOutTime { get; set; }

    [Required]
    [MaxLength(30)]
    public string Status { get; set; } = "Present";

    public Employee? Employee { get; set; }
}