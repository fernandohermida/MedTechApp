using MediatR;
using MedTechApp.Application.Common.Interfaces;
using MedTechApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedTechApp.Application.Doctors.Commands.CreateDoctor
{
    public class CreateDoctorCommand : IRequest<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }
    }

    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public CreateDoctorCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            var entity = new Doctor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Address = request.Address,
                Notes = request.Notes,
            };

            _context.Doctors.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }

}
