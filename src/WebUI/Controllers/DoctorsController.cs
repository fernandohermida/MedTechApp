using MedTechApp.Application.Doctors.Commands.CreateDoctor;
using MedTechApp.Application.Doctors.Queries.GetDoctors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedTechApp.WebUI.Controllers
{
    [Authorize]
    public class DoctorsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateDoctorCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<DoctorsVm>> Get()
        {
           return await Mediator.Send(new GetDoctorsQuery());
        }
    }
}
