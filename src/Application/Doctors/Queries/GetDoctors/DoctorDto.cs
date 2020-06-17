using AutoMapper;
using MedTechApp.Application.Common.Mappings;
using MedTechApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Application.Doctors.Queries.GetDoctors
{
    public class DoctorDto : IMapFrom<Doctor>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Doctor, DoctorDto>();
        }
    }
}
