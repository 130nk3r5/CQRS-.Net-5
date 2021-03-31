using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResourceFul.People.Application.Common.Interfaces;
using ResourceFul.People.Domain.Entities;

namespace ResourceFul.People.Infrastructure.Persistence
{
    public class PersonContext : DbContext, IPersonDbContext
    {
        //private static bool _created = false;
        public PersonContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
//            if (!_created)
//            {
//                _created = true;
//                Database.EnsureDeleted();
//                Database.EnsureCreated();
//            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasOne(p => p.Employee).WithOne(e => e.Person).HasForeignKey<EmployeeDetail>(ed => ed.PersonId);
            modelBuilder.Entity<Person>().HasOne(p => p.Personal).WithOne(p => p.Person).HasForeignKey<PersonalDetail>(p => p.PersonId);
            modelBuilder.Entity<Person>().HasOne(p => p.ContactInfo).WithOne(c => c.Person).HasForeignKey<ContactDetail>(c => c.PersonId);
            modelBuilder.Entity<Person>().HasOne(p => p.PhysicalAddress).WithOne(pa => pa.Person).HasForeignKey<PhysicalAddress>(p => p.PersonId);
            modelBuilder.Entity<Person>().HasOne(p => p.PostalAddress).WithOne(pa => pa.Person).HasForeignKey<PostalAddress>(p => p.PersonId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> People { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<PersonalDetail> PersonalDetails { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<PhysicalAddress> PhysicalAddresses { get; set; }
        public DbSet<PostalAddress> PostalAddresses { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            // Could add audit info here to an entitiy (CreateDate, LastModified, UserEdit)
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }        
    }
}
