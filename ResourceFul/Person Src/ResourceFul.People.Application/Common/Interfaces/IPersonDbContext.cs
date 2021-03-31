using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResourceFul.People.Domain.Entities;

namespace ResourceFul.People.Application.Common.Interfaces
{
    public interface IPersonDbContext
    {
        DbSet<Domain.Entities.Person> People { get; set; }
        DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        DbSet<PersonalDetail> PersonalDetails { get; set; }
        DbSet<ContactDetail> ContactDetails { get; set; }
        DbSet<PhysicalAddress> PhysicalAddresses { get; set; }
        DbSet<PostalAddress> PostalAddresses { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
