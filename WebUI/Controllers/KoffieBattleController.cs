using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Employees.Queries;
using Application.KoffieBattles.Commands;
using Application.KoffieBattles.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace WebUI.Controllers
{
    public class KoffieBattleController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<KoffieBattle>>> GetKoffieBattleData_CurrentMonth()
        {
            return await Mediator.Send(new GetCurrentMonthQuery());
        }
        [HttpPost]
        public async Task<ActionResult<string>> AddKoffieBattleData(AddKoffieBattleDataCommand command)
        {
            return await Mediator.Send(command);
        }
    }


}