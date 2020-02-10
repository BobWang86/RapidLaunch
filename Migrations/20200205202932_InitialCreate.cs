using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    GroupName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "LaunchDestinations",
                columns: table => new
                {
                    LaunchDestinationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchDestinations", x => x.LaunchDestinationID);
                });

            migrationBuilder.CreateTable(
                name: "LaunchPadStatuses",
                columns: table => new
                {
                    LaunchPadStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchPadStatuses", x => x.LaunchPadStatusID);
                });

            migrationBuilder.CreateTable(
                name: "LaunchSites",
                columns: table => new
                {
                    LaunchSiteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    BuildDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchSites", x => x.LaunchSiteID);
                });

            migrationBuilder.CreateTable(
                name: "LaunchStatus",
                columns: table => new
                {
                    LaunchStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchStatus", x => x.LaunchStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "PayRates",
                columns: table => new
                {
                    PayRateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rank = table.Column<int>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayRates", x => x.PayRateID);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EstablishDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "RocketCategories",
                columns: table => new
                {
                    RocketCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RocketCategories", x => x.RocketCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "RocketStatuses",
                columns: table => new
                {
                    RocketStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RocketStatuses", x => x.RocketStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    ContactID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaunchPrograms",
                columns: table => new
                {
                    LaunchProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LaunchDestinationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchPrograms", x => x.LaunchProjectID);
                    table.ForeignKey(
                        name: "FK_LaunchPrograms_LaunchDestinations_LaunchDestinationID",
                        column: x => x.LaunchDestinationID,
                        principalTable: "LaunchDestinations",
                        principalColumn: "LaunchDestinationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaunchPads",
                columns: table => new
                {
                    LaunchPadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LaunchPadCode = table.Column<string>(maxLength: 25, nullable: false),
                    LaunchSiteID = table.Column<int>(nullable: false),
                    LaunchPadStatusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchPads", x => x.LaunchPadID);
                    table.ForeignKey(
                        name: "FK_LaunchPads_LaunchPadStatuses_LaunchPadStatusID",
                        column: x => x.LaunchPadStatusID,
                        principalTable: "LaunchPadStatuses",
                        principalColumn: "LaunchPadStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaunchPads_LaunchSites_LaunchSiteID",
                        column: x => x.LaunchSiteID,
                        principalTable: "LaunchSites",
                        principalColumn: "LaunchSiteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    JobTitleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    PayRateID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.JobTitleID);
                    table.ForeignKey(
                        name: "FK_Positions_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Positions_PayRates_PayRateID",
                        column: x => x.PayRateID,
                        principalTable: "PayRates",
                        principalColumn: "PayRateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RocketModels",
                columns: table => new
                {
                    RocketModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    Mass = table.Column<double>(nullable: true),
                    Diameter = table.Column<double>(nullable: true),
                    PayloadLEO = table.Column<double>(nullable: true),
                    PayloadGTO = table.Column<double>(nullable: true),
                    ManufacturerID = table.Column<int>(nullable: false),
                    ProviderID = table.Column<int>(nullable: true),
                    RocketCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RocketModels", x => x.RocketModelID);
                    table.ForeignKey(
                        name: "FK_RocketModels_Manufacturers_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RocketModels_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RocketModels_RocketCategories_RocketCategoryID",
                        column: x => x.RocketCategoryID,
                        principalTable: "RocketCategories",
                        principalColumn: "RocketCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    JobTitleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_Positions_JobTitleID",
                        column: x => x.JobTitleID,
                        principalTable: "Positions",
                        principalColumn: "JobTitleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rockets",
                columns: table => new
                {
                    RocketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManufactureDate = table.Column<DateTime>(type: "date", nullable: true),
                    ProviderID = table.Column<int>(nullable: false),
                    RocketModelID = table.Column<int>(nullable: false),
                    RocketStatusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rockets", x => x.RocketID);
                    table.ForeignKey(
                        name: "FK_Rockets_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rockets_RocketModels_RocketModelID",
                        column: x => x.RocketModelID,
                        principalTable: "RocketModels",
                        principalColumn: "RocketModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rockets_RocketStatuses_RocketStatusID",
                        column: x => x.RocketStatusID,
                        principalTable: "RocketStatuses",
                        principalColumn: "RocketStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentHistories",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    ShiftID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentHistories", x => new { x.StaffID, x.DepartmentID, x.ShiftID });
                    table.ForeignKey(
                        name: "FK_DepartmentHistories_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentHistories_Shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "Shifts",
                        principalColumn: "ShiftID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentHistories_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PayHistories",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false),
                    PayDate = table.Column<DateTime>(type: "date", nullable: false),
                    Allowance = table.Column<decimal>(type: "money", nullable: true),
                    Percentage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayHistories", x => new { x.StaffID, x.PayDate });
                    table.ForeignKey(
                        name: "FK_PayHistories_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 8, nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    NationalInsuranceNumber = table.Column<string>(nullable: false),
                    ContactID = table.Column<int>(nullable: true),
                    StaffID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_People_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Launches",
                columns: table => new
                {
                    LaunchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlannedDateTime = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    LaunchedDateTime = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    RocketID = table.Column<int>(nullable: false),
                    LaunchPadID = table.Column<int>(nullable: false),
                    LaunchProjectID = table.Column<int>(nullable: false),
                    LaunchStatusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launches", x => x.LaunchID);
                    table.ForeignKey(
                        name: "FK_Launches_LaunchPads_LaunchPadID",
                        column: x => x.LaunchPadID,
                        principalTable: "LaunchPads",
                        principalColumn: "LaunchPadID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Launches_LaunchPrograms_LaunchProjectID",
                        column: x => x.LaunchProjectID,
                        principalTable: "LaunchPrograms",
                        principalColumn: "LaunchProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Launches_LaunchStatus_LaunchStatusID",
                        column: x => x.LaunchStatusID,
                        principalTable: "LaunchStatus",
                        principalColumn: "LaunchStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Launches_Rockets_RocketID",
                        column: x => x.RocketID,
                        principalTable: "Rockets",
                        principalColumn: "RocketID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactID",
                table: "Addresses",
                column: "ContactID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentHistories_DepartmentID",
                table: "DepartmentHistories",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentHistories_ShiftID",
                table: "DepartmentHistories",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_LaunchPadID",
                table: "Launches",
                column: "LaunchPadID");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_LaunchProjectID",
                table: "Launches",
                column: "LaunchProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_LaunchStatusID",
                table: "Launches",
                column: "LaunchStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Launches_RocketID",
                table: "Launches",
                column: "RocketID");

            migrationBuilder.CreateIndex(
                name: "IX_LaunchPads_LaunchPadStatusID",
                table: "LaunchPads",
                column: "LaunchPadStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_LaunchPads_LaunchSiteID",
                table: "LaunchPads",
                column: "LaunchSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_LaunchPrograms_LaunchDestinationID",
                table: "LaunchPrograms",
                column: "LaunchDestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_People_ContactID",
                table: "People",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_People_StaffID",
                table: "People",
                column: "StaffID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentID",
                table: "Positions",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PayRateID",
                table: "Positions",
                column: "PayRateID");

            migrationBuilder.CreateIndex(
                name: "IX_RocketModels_ManufacturerID",
                table: "RocketModels",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_RocketModels_ProviderID",
                table: "RocketModels",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_RocketModels_RocketCategoryID",
                table: "RocketModels",
                column: "RocketCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Rockets_ProviderID",
                table: "Rockets",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Rockets_RocketModelID",
                table: "Rockets",
                column: "RocketModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Rockets_RocketStatusID",
                table: "Rockets",
                column: "RocketStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_JobTitleID",
                table: "Staff",
                column: "JobTitleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "DepartmentHistories");

            migrationBuilder.DropTable(
                name: "Launches");

            migrationBuilder.DropTable(
                name: "PayHistories");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "LaunchPads");

            migrationBuilder.DropTable(
                name: "LaunchPrograms");

            migrationBuilder.DropTable(
                name: "LaunchStatus");

            migrationBuilder.DropTable(
                name: "Rockets");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "LaunchPadStatuses");

            migrationBuilder.DropTable(
                name: "LaunchSites");

            migrationBuilder.DropTable(
                name: "LaunchDestinations");

            migrationBuilder.DropTable(
                name: "RocketModels");

            migrationBuilder.DropTable(
                name: "RocketStatuses");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "RocketCategories");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "PayRates");
        }
    }
}
