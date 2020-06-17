using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Application.Doctors.Queries.GetDoctors
{
    public class DoctorsVm
    {
        public IList<DoctorDto> DoctorsList { get; set; }
    }
}
