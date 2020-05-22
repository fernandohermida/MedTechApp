using MedTechApp.Domain.Common;
using MedTechApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Domain.Entities
{
    public class Patient : AuditableEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime? BirdDate { get; set; }

        public BloodType BloodGroup { get; set; }

        public GenderType Gender { get; set; }

    }
}
