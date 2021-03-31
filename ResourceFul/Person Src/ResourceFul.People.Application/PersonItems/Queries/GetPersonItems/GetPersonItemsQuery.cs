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
    public class GetPersonItemsQuery : IRequest<List<PersonDto>>
    {
        //ToDo : Add query details

        public GetPersonItemsQuery()
        {
        }
    }

    public class GetPersonItemsQueryHandler : IRequestHandler<GetPersonItemsQuery, List<PersonDto>>
    {

        private readonly IPersonDbContext _context;
        private readonly IMapper _mapper;

        public GetPersonItemsQueryHandler(IPersonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PersonDto>> Handle(GetPersonItemsQuery request, CancellationToken cancellationToken)
        {
            return await _context.People
                .AsNoTracking()
                .ProjectTo<PersonDto>(_mapper.ConfigurationProvider)
                .ToListAsync();                
        }        
    }
}
