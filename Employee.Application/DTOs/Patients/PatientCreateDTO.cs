namespace Employee.Application.DTOs.Patients;

public class EmployeetCreateDTO
{
    public string? Name { get; set; } 
    public string? Surname { get; set; }
    public DateTime DOB { get; set; }
    public string? PhoneNumber { get; set; }
    public string? SeriaNumber { get; set; }
    public decimal? Salary { get; set; }
    public string? CurrentAddress { get; set; }
    public string? Email { get; set; }
}
