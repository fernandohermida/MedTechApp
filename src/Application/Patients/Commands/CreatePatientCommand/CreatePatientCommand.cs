using MedTechApp.Application.Common.Interfaces;
using MedTechApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MedTechApp.Application.Patients.Commands.CreatePatientCommand
{
    public class CreatePatientCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
                LastName = request.LastName
            };

            _context.Patients.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
     }
}
