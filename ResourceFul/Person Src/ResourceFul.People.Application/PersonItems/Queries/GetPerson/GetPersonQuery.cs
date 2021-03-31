using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using ResourceFul.People.Application.Common.Interfaces;
using ResourceFul.People.Application.PersonItems.Dtos;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ResourceFul.People.Application.Person.Queries.GetPersonItems
{
    public class GetPersonQuery : IRequest<PersonDto>
    {
        public int personId { get; set; } 

        public GetPersonQuery()
        {
        }
    }

    public class GetPersonQueryHandler : IRequestHandler<GetPersonQuery, PersonDto>
    {

        private readonly IPersonDbContext _context;
        private readonly IMapper _mapper;

        public GetPersonQueryHandler(IPersonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PersonDto> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            return await _context.People
                .Where(p => p.PersonId == request.personId)
                .ProjectTo<PersonDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();                       
        }        
    }
}
