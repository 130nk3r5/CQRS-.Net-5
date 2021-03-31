
using ResourceFul.People.Domain.Entities;
using ResourceFul.People.Application.Common.Mappings;
using AutoMapper;

namespace ResourceFul.People.Application.PersonItems.Dtos
{
    public class PersonDto : IMapFrom<Domain.Entities.Person>
    {
        public PersonDto()
        {
        }

        public long PersonId { get; set; }

        public EmployeeDetailDto Employee { get; set; }

        public PersonalDetailDto Personal { get; set; }

        public ContactDetailDto ContactInfo { get; set; }

        public PhysicalAddressDto PhysicalAddress { get; set; }

        public PostalAddressDto PostalAddress { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Person, PersonDto>()
                .ForMember(p => p.Employee, opt => opt.MapFrom(s => s.Employee))
                .ForMember(p => p.Personal, opt => opt.MapFrom(s => s.Personal))
                .ForMember(p => p.ContactInfo, opt => opt.MapFrom(s => s.ContactInfo))
                .ForMember(p => p.PhysicalAddress, opt => opt.MapFrom(s => s.PhysicalAddress))
                .ForMember(p => p.PostalAddress, opt => opt.MapFrom(s => s.PostalAddress));

            profile.CreateMap<PersonDto , Domain.Entities.Person>()
                .ForMember(p => p.Employee, opt => opt.MapFrom(s => s.Employee))
                .ForMember(p => p.Personal, opt => opt.MapFrom(s => s.Personal))
                .ForMember(p => p.ContactInfo, opt => opt.MapFrom(s => s.ContactInfo))
                .ForMember(p => p.PhysicalAddress, opt => opt.MapFrom(s => s.PhysicalAddress))
                .ForMember(p => p.PostalAddress, opt => opt.MapFrom(s => s.PostalAddress));
        }
    }
}
