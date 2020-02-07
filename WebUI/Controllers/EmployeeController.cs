using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Employees.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await Mediator.Send(new GetAllEmployeesQuery());
        }

    }
}

