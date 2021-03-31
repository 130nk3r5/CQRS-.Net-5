using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResourceFul.People.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    ContactDetailId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkNumber = table.Column<string>(type: "TEXT", nullable: true),
                    WorkExtension = table.Column<string>(type: "TEXT", nullable: true),
                    CellphoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    WorkEmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    PersonalEmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyContact = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyCellphoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyPhysicalAddress = table.Column<string>(type: "TEXT", nullable: true),
                    PersonId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.ContactDetailId);
                    table.ForeignKey(
                        name: "FK_ContactDetails_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    EmployeeDetailId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<int>(type: "INTEGER", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PersonId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmployeeDetailId);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    PersonalDetailId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Language = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Race = table.Column<int>(type: "INTEGER", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: true),
                    Citizenship = table.Column<string>(type: "TEXT", nullable: true),
                    Disability = table.Column<string>(type: "TEXT", nullable: true),
                    MaritalStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Photo = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PersonId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.PersonalDetailId);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAddresses",
                columns: table => new
                {
                    PhysicalAddressId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnitNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ComplexName = table.Column<string>(type: "TEXT", nullable: true),
                    StreetNumber = table.Column<string>(type: "TEXT", nullable: true),
                    StreetName = table.Column<string>(type: "TEXT", nullable: true),
                    Suburb = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    PersonId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAddresses", x => x.PhysicalAddressId);
                    table.ForeignKey(
                        name: "FK_PhysicalAddresses_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostalAddresses",
                columns: table => new
                {
                    PostalAddressId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnitNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ComplexName = table.Column<string>(type: "TEXT", nullable: true),
                    StreetNumber = table.Column<string>(type: "TEXT", nullable: true),
                    StreetName = table.Column<string>(type: "TEXT", nullable: true),
                    Suburb = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    PersonId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostalAddresses", x => x.PostalAddressId);
                    table.ForeignKey(
                        name: "FK_PostalAddresses_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_PersonId",
                table: "ContactDetails",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_PersonId",
                table: "EmployeeDetails",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_PersonId",
                table: "PersonalDetails",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAddresses_PersonId",
                table: "PhysicalAddresses",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostalAddresses_PersonId",
                table: "PostalAddresses",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "PhysicalAddresses");

            migrationBuilder.DropTable(
                name: "PostalAddresses");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
