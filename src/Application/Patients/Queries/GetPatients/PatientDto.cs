using AutoMapper;
using MedTechApp.Application.Common.Mappings;
using MedTechApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Application.Patients.Queries.GetPatients
{
    public class PatientDto : IMapFrom<Patient>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string BirdDate { get; set; }

        public string BloodGroup { get; set; }

        public string Gender { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Patient, PatientDto>();
        }
    }
}
