namespace API.Entities;

public class Employee : BaseEntity
{

    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime DOB { get; set; }
    public string? PhoneNumber { get; set; }
    public string? SeriaNumber { get; set; }
    public string? CurrentAddress { get; set; }
    public decimal? Salary { get; set; }
    public string? Email { get; set; }


}


