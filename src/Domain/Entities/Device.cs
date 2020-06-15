using System;
using System.Collections.Generic;
using System.Text;


namespace MedTechApp.Domain.Entities
{
    class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Serial { get; set; }

        public Patient LinkPatienat { get; set; }
    }
}