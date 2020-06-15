using MedTechApp.Application.Common.Interfaces;
using MedTechApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;
using MedTechApp.Domain.Enums;

namespace MedTechApp.Application.Patients.Commands.CreatePatient
{
    public class CreatePatientCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? BirdDate { get; set; }
        public BloodType BloodGroup { get; set; }
        public GenderType Gender { get; set; }
    }
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public CreatePatientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var entity = new Patient
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Address = request.Address,
                BirdDate = request.BirdDate,
                BloodGroup  = request.BloodGroup,
                Gender = request.Gender
            };

            _context.Patients.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
     }
}
