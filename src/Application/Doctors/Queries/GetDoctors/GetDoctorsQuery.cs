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

namespace MedTechApp.Application.Doctors.Queries.GetDoctors
{
    public class GetDoctorsQuery : IRequest<DoctorsVm>
    {
    }

    public class GetDoctorsQueryHandler : IRequestHandler<GetDoctorsQuery, DoctorsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetDoctorsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<DoctorsVm> Handle(GetDoctorsQuery request, CancellationToken cancellationToken)
        {
            return new DoctorsVm
            {
                DoctorsList = await _context.Doctors
                           .ProjectTo<DoctorDto>(_mapper.ConfigurationProvider)
                           .OrderBy(t => t.LastName)
                           .ToListAsync(cancellationToken)
            };
        }
    }

}
