using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MedTechApp.Application.Patients.Commands.CreatePatientCommand;


namespace MedTechApp.WebUI.Controllers
{
    [Authorize]
    public class PatientsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreatePatientCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}