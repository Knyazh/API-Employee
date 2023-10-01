using AutoMapper;
using Employee.Application.DTOs.Patients;
using Employee.Application.Repositories.Employee;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeReadRepository _EmployeeReadRepository;
        private readonly IEmployeeWriteRepository _EmployeeWriteRepository;
        private readonly IMapper _mapper;

        public Employee(IEmployeeReadRepository EmployeeReadRepository, IEmployeeWriteRepository EmployeeWriteRepository, IMapper mapper)
        {
            _EmployeeReadRepository = EmployeeReadRepository;
            _EmployeeWriteRepository = EmployeeWriteRepository;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllEmployee()
        {

            var Employees = await _EmployeeReadRepository.GetAll().ToListAsync();
            return Ok(Employees);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {

            Employee Employee = await _EmployeeReadRepository.GetById(id);
            return Ok(Employee);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateEmployeeAsync([FromForm] EmployeetCreateDTO EmployeetCreateDTO)
        {
            Employee Employee = _mapper.Map<Employee>(EmployeetCreateDTO);
            await _EmployeeWriteRepository.CreateAsync(Employee);
            await _EmployeeWriteRepository.SaveChangeAsync();
            return Ok();
        }

    }

}