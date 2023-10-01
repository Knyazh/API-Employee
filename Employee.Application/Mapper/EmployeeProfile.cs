using AutoMapper;
using Employee.Application.DTOs.Patients;

namespace Employee.Application.Mapper;

public class EmployeeProfile:Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeetCreateDTO>().ReverseMap();
    }
}
