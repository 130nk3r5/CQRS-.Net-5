using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ResourceFul.People.Application.Common.Interfaces;
using ResourceFul.People.Application.PersonItems.Dtos;
using ResourceFul.People.Domain.Entities;

namespace ResourceFul.People.Application.PersonItems.Commands.CreatePerson
{
    public class CreatePersonCommand : IRequest<long>
    {
        public CreatePersonCommand()
        {
        }

        public EmployeeDetailDto Employee { get; set; }

        public PersonalDetailDto Personal { get; set; }

        public ContactDetailDto ContactInfo { get; set; }

        public PhysicalAddressDto PhysicalAddress { get; set; }

        public PostalAddressDto PostalAddress { get; set; }
    }


    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, long>
    {
        private readonly IPersonDbContext _context;
        private readonly IMapper _mapper;

        public CreatePersonCommandHandler(IPersonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            EmployeeDetail employeeDetail = _mapper.Map<EmployeeDetail>(request.Employee);
            PersonalDetail personalDetail = _mapper.Map<PersonalDetail>(request.Personal);
            ContactDetail contactDetail = _mapper.Map<ContactDetail>(request.ContactInfo);
            PhysicalAddress physicalAddress = _mapper.Map<PhysicalAddress>(request.PhysicalAddress);
            PostalAddress postalAddress = _mapper.Map<PostalAddress>(request.PostalAddress);
            Domain.Entities.Person person = new Domain.Entities.Person
            {
                Employee = employeeDetail,
                Personal = personalDetail,
                ContactInfo = contactDetail,
                PhysicalAddress = physicalAddress,
                PostalAddress = postalAddress
            };

            _context.People.Add(person);

            await _context.SaveChangesAsync(cancellationToken);

            return person.PersonId;
        }
    }
}
