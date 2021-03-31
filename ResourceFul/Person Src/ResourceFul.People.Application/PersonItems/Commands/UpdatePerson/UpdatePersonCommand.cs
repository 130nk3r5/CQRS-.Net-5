using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ResourceFul.People.Application.Common.Exceptions;
using ResourceFul.People.Application.Common.Interfaces;
using ResourceFul.People.Application.PersonItems.Dtos;
using ResourceFul.People.Domain.Entities;

namespace ResourceFul.People.Application.PersonItems.Commands.UpdatePerson
{
    public class UpdatePersonCommand : IRequest
    {
        public UpdatePersonCommand()
        {
        }

        public long PersonId { get; set; }

        public EmployeeDetailDto Employee { get; set; }

        public PersonalDetailDto Personal { get; set; }

        public ContactDetailDto ContactInfo { get; set; }

        public PhysicalAddressDto PhysicalAddress { get; set; }

        public PostalAddressDto PostalAddress { get; set; }

        
    }

    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand>
    {
        private readonly IPersonDbContext _context;
        private readonly IMapper _mapper;

        public UpdatePersonCommandHandler(IPersonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.People.FindAsync(request.PersonId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Person), request.PersonId);
            }

            EmployeeDetail employeeDetail = _mapper.Map<EmployeeDetail>(request.Employee);
            PersonalDetail personalDetail = _mapper.Map<PersonalDetail>(request.Personal);
            ContactDetail contactDetail = _mapper.Map<ContactDetail>(request.ContactInfo);
            PhysicalAddress physicalAddress = _mapper.Map<PhysicalAddress>(request.PhysicalAddress);
            PostalAddress postalAddress = _mapper.Map<PostalAddress>(request.PostalAddress);

            if (employeeDetail != null) // if API omits to add detail, then don't try to update it.
                entity.Employee = employeeDetail;
            if (personalDetail != null)
                entity.Personal = personalDetail;
            if (contactDetail != null)
                entity.ContactInfo = contactDetail;
            if (physicalAddress != null)
                entity.PhysicalAddress = physicalAddress;
            if (postalAddress != null)
                entity.PostalAddress = postalAddress;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
