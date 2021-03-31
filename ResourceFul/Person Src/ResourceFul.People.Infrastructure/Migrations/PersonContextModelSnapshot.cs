﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResourceFul.People.Infrastructure.Persistence;

namespace ResourceFul.People.Infrastructure.Migrations
{
    [DbContext(typeof(PersonContext))]
    partial class PersonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.ContactDetail", b =>
                {
                    b.Property<long>("ContactDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CellphoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyCellphoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyContact")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyPhysicalAddress")
                        .HasColumnType("TEXT");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonalEmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkEmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkExtension")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactDetailId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.EmployeeDetail", b =>
                {
                    b.Property<long>("EmployeeDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.Property<int>("Title")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeDetailId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.Person", b =>
                {
                    b.Property<long>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.PersonalDetail", b =>
                {
                    b.Property<long>("PersonalDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Citizenship")
                        .HasColumnType("TEXT");

                    b.Property<string>("Disability")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nationality")
                        .HasColumnType("TEXT");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("BLOB");

                    b.Property<int>("Race")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonalDetailId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.PhysicalAddress", b =>
                {
                    b.Property<long>("PhysicalAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("ComplexName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("PhysicalAddressId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("PhysicalAddresses");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.PostalAddress", b =>
                {
                    b.Property<long>("PostalAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("ComplexName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<long>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("PostalAddressId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("PostalAddresses");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.ContactDetail", b =>
                {
                    b.HasOne("ResourceFul.People.Domain.Entities.Person", "Person")
                        .WithOne("ContactInfo")
                        .HasForeignKey("ResourceFul.People.Domain.Entities.ContactDetail", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.EmployeeDetail", b =>
                {
                    b.HasOne("ResourceFul.People.Domain.Entities.Person", "Person")
                        .WithOne("Employee")
                        .HasForeignKey("ResourceFul.People.Domain.Entities.EmployeeDetail", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.PersonalDetail", b =>
                {
                    b.HasOne("ResourceFul.People.Domain.Entities.Person", "Person")
                        .WithOne("Personal")
                        .HasForeignKey("ResourceFul.People.Domain.Entities.PersonalDetail", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.PhysicalAddress", b =>
                {
                    b.HasOne("ResourceFul.People.Domain.Entities.Person", "Person")
                        .WithOne("PhysicalAddress")
                        .HasForeignKey("ResourceFul.People.Domain.Entities.PhysicalAddress", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.PostalAddress", b =>
                {
                    b.HasOne("ResourceFul.People.Domain.Entities.Person", "Person")
                        .WithOne("PostalAddress")
                        .HasForeignKey("ResourceFul.People.Domain.Entities.PostalAddress", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResourceFul.People.Domain.Entities.Person", b =>
                {
                    b.Navigation("ContactInfo");

                    b.Navigation("Employee");

                    b.Navigation("Personal");

                    b.Navigation("PhysicalAddress");

                    b.Navigation("PostalAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
