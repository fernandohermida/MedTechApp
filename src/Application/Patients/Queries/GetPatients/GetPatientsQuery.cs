using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using MedTechApp.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedTechApp.Application.Patients.Queries.GetPatients
{
    public class GetPatientsQuery: IRequest<PatientsVm>
    {
    }

    public class GetPatientsQueryHandler : IRequestHandler<GetPatientsQuery, PatientsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPatientsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PatientsVm> Handle(GetPatientsQuery request, CancellationToken cancellationToken)
        {
            return new PatientsVm
            {
                  PatientList = await _context.Patients
                          .ProjectTo<PatientDto>(_mapper.ConfigurationProvider)
                          .OrderBy(t => t.LastName)
                          .ToListAsync(cancellationToken)
            };

        }
    }
}
