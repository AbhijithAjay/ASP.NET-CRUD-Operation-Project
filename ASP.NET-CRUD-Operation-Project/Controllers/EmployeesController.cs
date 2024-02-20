using ASP.NET_CRUD_Operation_Project.Data;
using ASP.NET_CRUD_Operation_Project.Models;
using ASP.NET_CRUD_Operation_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_CRUD_Operation_Project.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeManagementDbContext employeeDbcontext;
        public EmployeesController(EmployeeManagementDbContext EmployeeDbcontext)
        {
            this.employeeDbcontext = EmployeeDbcontext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await employeeDbcontext.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
                Department = addEmployeeRequest.Department,
                Salary = addEmployeeRequest.Salary,
                DateOfJoining = addEmployeeRequest.DateOfJoining
            };
            await employeeDbcontext.Employees.AddAsync(employee);
            await employeeDbcontext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}