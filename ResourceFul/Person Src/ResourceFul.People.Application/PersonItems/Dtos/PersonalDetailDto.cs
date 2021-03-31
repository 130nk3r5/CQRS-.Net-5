using System;
using AutoMapper;
using ResourceFul.People.Application.Common.Mappings;
using ResourceFul.People.Domain.Entities;
namespace ResourceFul.People.Application.PersonItems.Dtos
{
    public class PersonalDetailDto : IMapFrom<PersonalDetail>
    {
        public long PersonalDetailId { get; set; }

        public string Language { get; set; }

        public Gender Gender { get; set; }

        public Race Race { get; set; }

        public string Nationality { get; set; }

        public string Citizenship { get; set; }

        public string Disability { get; set; }

         public MaritalStatusCode MaritalStatus { get; set; }

        public DateTime BirthDate { get; set; }

        public byte[] Photo { get; set; }

        public long PersonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PersonalDetail, PersonalDetailDto>();
            profile.CreateMap<PersonalDetailDto, PersonalDetail>();
        }
    }
}
