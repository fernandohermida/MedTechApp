using MedTechApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Domain.Entities
{
    public class Doctor : AuditableEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

    }
}
