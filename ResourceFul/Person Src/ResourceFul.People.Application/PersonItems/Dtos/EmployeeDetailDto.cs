using System;
using AutoMapper;
using ResourceFul.People.Application.Common.Mappings;
using ResourceFul.People.Domain.Entities;
namespace ResourceFul.People.Application.PersonItems.Dtos
{
    public class EmployeeDetailDto : IMapFrom<EmployeeDetail>
    {
        public long EmployeeDetailId { get; set; }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public Title Title { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime? LastDate { get; set; }

        public long PersonId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EmployeeDetail, EmployeeDetailDto>();
            profile.CreateMap<EmployeeDetailDto, EmployeeDetail>();
        }
    }
}
