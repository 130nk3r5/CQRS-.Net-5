using System;
using AutoMapper;
using ResourceFul.People.Application.Common.Mappings;
using ResourceFul.People.Domain.Entities;

namespace ResourceFul.People.Application.PersonItems.Dtos
{
    public class PhysicalAddressDto : IMapFrom<PhysicalAddress>
    {
        public long PhysicalAddressId { get; set; }

        public string UnitNumber { get; set; }

        public string ComplexName { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public string Code { get; set; }

        public string Country { get; set; }

        public long PersonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PhysicalAddress, PhysicalAddressDto>();
            profile.CreateMap<PhysicalAddressDto, PhysicalAddress>();
        }
    }

    public class PostalAddressDto : IMapFrom<PostalAddress>
    {
        public long PostalAddressId { get; set; }

        public string UnitNumber { get; set; }

        public string ComplexName { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public string Code { get; set; }

        public string Country { get; set; }

        public long PersonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PostalAddress, PostalAddressDto>();
            profile.CreateMap<PostalAddressDto, PostalAddress>();
        }

    }
}
