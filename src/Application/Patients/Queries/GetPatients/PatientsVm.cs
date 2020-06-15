using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Application.Patients.Queries.GetPatients
{
    public class PatientsVm
    {
        public IList<PatientDto> PatientList { get; set; }
    }
}
