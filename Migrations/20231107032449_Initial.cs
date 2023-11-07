using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTC_Dental.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DentistID = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentTypes",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTypes", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "CompletedServices",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    VisitID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedServices", x => new { x.ServiceID, x.VisitID });
                });

            migrationBuilder.CreateTable(
                name: "Dentists",
                columns: table => new
                {
                    DentistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DentistFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DentistLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentists", x => x.DentistID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientSSN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientMinor = table.Column<bool>(type: "bit", nullable: false),
                    PatientHOHID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCost = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DentistID = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitID);
                });

            migrationBuilder.InsertData(
                table: "AppointmentTypes",
                columns: new[] { "TypeID", "AppointmentName", "Description", "Duration" },
                values: new object[,]
                {
                    { 1, "Cosmetic Consultation - Adult", "Initial consultation with adult patient to discuss cosmetic dentistry options", 30 },
                    { 2, "Cosmetic Consultation - Child", "Initial consultation with child patient to discuss cosmetic dentistry options", 30 },
                    { 3, "Cosmetic Consultation - Teen", "Initial consultation with teem patient to discuss cosmetic dentistry options", 30 },
                    { 4, " Cosmetic Procedure - Adult", "Cosmetic dentistry procedure for adult patient", 120 },
                    { 5, "Cosmetic Procedure - Child", "Cosmetic dentistry procedure for child patient", 120 },
                    { 6, "Cosmetic Procedure - Teen", "Cosmetic dentistry procedure for teen patient", 120 },
                    { 7, "Endodontic Procedure - Adult", "Painless root canal therapy for adults", 90 },
                    { 8, " Endodontic Procedure - Child", "Painless root canal therapy for Children", 90 },
                    { 9, "Endodontic Procedure - Teen ", "Painless root canal therapy for Teens", 90 },
                    { 10, "New Patient - Adult", "Meet new patient with general dental check-up including x-rays and teeth cleaning", 30 },
                    { 11, "New Patient - Child", "Meet new patient with general dental check-up including x-rays and teeth cleaning", 30 },
                    { 12, "New Patient - Teen", "Meet new patient with general dental check-up including x-rays and teeth cleaning", 30 },
                    { 13, "Periodontal Treatment - Adult ", "Treatment (both preventative or restorative) for gum diseases", 60 },
                    { 14, "Periodontal Treatment - Child", "Treatment (both preventative or restorative) for gum diseases", 60 },
                    { 15, "Periodontal Treatment - Teen ", "Treatment (both preventative or restorative) for gum diseases", 60 },
                    { 16, "Preventative Care - Adult", "General preventative care for an adult patient.The appointment will include x-rays\\54 teeth cleaning\\54 and general oral hygiene advising", 60 },
                    { 17, "Preventative Care - Child", "General preventative care for an adult patient.The appointment will include x-rays\\54 teeth cleaning\\54 and general oral hygiene advising", 60 },
                    { 18, "Preventative Care - Teen", "General preventative care for an adult patient. The appointment will include x - rays\\54 teeth cleaning\\54 and general oral hygiene advising", 60 },
                    { 19, "Prosthodontic Care - Adult", "Restoration and/or replacement of missing or damaged teeth for adults", 60 },
                    { 20, "Prosthodontic Care - Child", "Restoration and/or replacement of missing or damaged teeth for adults", 60 },
                    { 21, "Prosthodontic Care - Teen", "Restoration and/or replacement of missing or damaged teeth for adults", 60 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentDate", "DentistID", "PatientID", "StartTime", "TypeID" },
                values: new object[,]
                {
                    { 1, new DateTime(2009, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 2, new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 3, new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new TimeSpan(0, 1, 0, 0, 0), 3 },
                    { 4, new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, new TimeSpan(0, 2, 0, 0, 0), 4 },
                    { 5, new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, new TimeSpan(0, 2, 20, 0, 0), 5 },
                    { 6, new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, new TimeSpan(0, 2, 15, 0, 0), 6 },
                    { 7, new DateTime(2012, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, new TimeSpan(0, 1, 12, 0, 0), 7 },
                    { 8, new DateTime(2010, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, new TimeSpan(0, 2, 55, 0, 0), 8 },
                    { 9, new DateTime(2009, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 9, new TimeSpan(0, 3, 0, 0, 0), 9 },
                    { 10, new DateTime(2009, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 10, new TimeSpan(0, 11, 30, 0, 0), 10 }
                });

            migrationBuilder.InsertData(
                table: "CompletedServices",
                columns: new[] { "ServiceID", "VisitID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Dentists",
                columns: new[] { "DentistID", "DentistFirstName", "DentistLastName", "HireDate" },
                values: new object[,]
                {
                    { 1, "Jan", "Run", new DateTime(1985, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Ron", "Jun", new DateTime(1997, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Jason", "Fun", new DateTime(1993, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Jammy", "Dillan", new DateTime(1979, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Jonh", "Ronal", new DateTime(1988, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "PatientCity", "PatientDOB", "PatientEmail", "PatientFirstName", "PatientHOHID", "PatientLastName", "PatientMinor", "PatientPhone", "PatientSSN", "PatientState", "PatientStreetAddress", "PatientZip" },
                values: new object[,]
                {
                    { 1, "Austin", new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rohan@Gmail.com", "Rohan", 0, "Govathoti", false, "5127787879", "123456789", "TX", "101 Chillip", "78753" },
                    { 2, "Austin", new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph@Gmail.com", "Joseph", 0, "Pham", false, "5127787394", "133456789", "TX", "102 Chillip", "78753" },
                    { 3, "Austin", new DateTime(1978, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hanson@Gmail.com", "Hanson", 0, "Nguyen", false, "5122228493", "143456789", "TX", "103 Chillip", "78753" },
                    { 4, "Austin", new DateTime(2000, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason@Gmail.com", "Jason", 0, "Nguyen", false, "5127784905", "125456789", "TX", "104 Chillip", "78753" },
                    { 5, "Austin", new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zahra@Gmail.com", "Zahra", 0, "Karim", false, "5128878473", "123466789", "TX", "105 Chillip", "78753" },
                    { 6, "Austin", new DateTime(1997, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miley@Gmail.com", "Miley", 0, "Cyrus", false, "5127787473", "123457789", "TX", "106 Chillip", "78753" },
                    { 7, "Austin", new DateTime(2000, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donal@Gmail.com", "Donal", 0, "Duck", false, "5124445546", "123459789", "TX", "107 Chillip", "78753" },
                    { 8, "Austin", new DateTime(2000, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly@Gmail.com", "Kelly", 0, "Tran", false, "5126635465", "123456889", "TX", "108 Chillip", "78753" },
                    { 9, "Austin", new DateTime(1973, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dalvin@Gmail.com", "Dalvin", 0, "Kelly", false, " 5125565686", "923456789", "TX", "109 Chillip", "78753" },
                    { 10, "Austin", new DateTime(1981, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diana@Gmail.com", "Diana", 0, "Gutiz", false, "5126676748", "103456789", "TX", "1231 Chillip", "78753" },
                    { 11, "Austin", new DateTime(1996, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josh@Gmail.com", "Josh", 0, "Drake", false, "5126676543", "113456789", "TX", "10231 Chillip", " 78753" },
                    { 12, "Austin", new DateTime(1990, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drake@Gmail.com", "Drake", 0, "Josh", false, " 5127736489", "198456789", "TX", "241 Chillip", "8753" },
                    { 13, "Austin", new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esther@Gmail.com", "Ester", 0, "Lovato", false, "5178673645", "123456789", "TX", "141 Chillip", "78753" },
                    { 14, "Austin", new DateTime(1957, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daffy@Gmail.com", "Daffy", 0, "Duck", false, "5126954367", "123456789", "TX", "1271 Chillip", "78753" },
                    { 15, "Austin", new DateTime(2010, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dan@Gmail.com", "Dan", 1, "Run", true, "3924454397", "123456789", "TX", "1261 Chillip", "78753" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "ServiceCost", "ServiceDescription" },
                values: new object[,]
                {
                    { 1, 250f, "X-Ray" },
                    { 2, 350f, "Drill Cavity" },
                    { 3, 750f, "Crown" },
                    { 4, 500f, "Extract Tooth" },
                    { 5, 1500f, "Root Canal" },
                    { 6, 350f, "Tooth Whitening" },
                    { 7, 2500f, "Dental Implant" },
                    { 8, 4500f, "Dentures" },
                    { 9, 250f, "Anesthetic" },
                    { 10, 150f, "Cleaning" },
                    { 11, 350f, "Pediatric Dental Care" },
                    { 12, 500f, "Dental Extraction" },
                    { 13, 250f, "Dental Screening" },
                    { 14, 275f, "Fluoride Treatment" },
                    { 15, 250f, "Cavity Filling" }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitID", "DentistID", "PatientID", "VisitDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2002, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, new DateTime(2022, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 4, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 5, new DateTime(2010, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 6, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 7, new DateTime(2009, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, 8, new DateTime(2001, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4, 9, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 5, 10, new DateTime(2017, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentTypes");

            migrationBuilder.DropTable(
                name: "CompletedServices");

            migrationBuilder.DropTable(
                name: "Dentists");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Visits");
        }
    }
}
