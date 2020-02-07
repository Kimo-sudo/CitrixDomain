using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Employees.Queries;
using Application.KoffieBattle.Commands;
using Domain.Entities;
using Domain.Entities.KoffieBattle;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace WebUI.Controllers
{
    public class KoffieBattleController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<string>> CreateEmployee(AddKoffieBattleDataCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}