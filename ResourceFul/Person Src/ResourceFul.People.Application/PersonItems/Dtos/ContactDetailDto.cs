using AutoMapper;
using ResourceFul.People.Application.Common.Mappings;
using ResourceFul.People.Domain.Entities;

namespace ResourceFul.People.Application.PersonItems.Dtos
{
    public class ContactDetailDto : IMapFrom<ContactDetail>
    {
        public long ContactDetailId { get; set; }

        public string WorkNumber { get; set; }

        public string WorkExtension { get; set; }

        public string CellphoneNumber { get; set; }

        public string WorkEmailAddress { get; set; }

        public string PersonalEmailAddress { get; set; }

        public string EmergencyContact { get; set; }

        public string EmergencyCellphoneNumber { get; set; }

        public string EmergencyPhysicalAddress { get; set; }

        public long PersonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ContactDetail, ContactDetailDto>();
            profile.CreateMap<ContactDetailDto, ContactDetail>();
        }
    }
}
