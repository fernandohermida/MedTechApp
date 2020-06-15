using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MedTechApp.Application.Patients.Commands.CreatePatient;
using MedTechApp.Application.Patients.Queries.GetPatients;

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

        [HttpGet]
        public async Task<ActionResult<PatientsVm>> Get()
        {
            return await Mediator.Send(new GetPatientsQuery());
        }
    }
}