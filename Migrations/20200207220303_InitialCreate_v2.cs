using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class InitialCreate_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchPrograms_LaunchProgramID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchStatus_LaunchStatusID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_LaunchPads_LaunchPadStatuses_LaunchPadStatusID",
                table: "LaunchPads");

            migrationBuilder.DropTable(
                name: "LaunchPadStatuses");

            migrationBuilder.DropTable(
                name: "LaunchPrograms");

            migrationBuilder.DropTable(
                name: "LaunchDestinations");

            migrationBuilder.DropIndex(
                name: "IX_LaunchPads_LaunchPadStatusID",
                table: "LaunchPads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaunchStatus",
                table: "LaunchStatus");

            migrationBuilder.DropColumn(
                name: "LaunchPadStatusID",
                table: "LaunchPads");

            migrationBuilder.RenameTable(
                name: "LaunchStatus",
                newName: "LaunchStatuses");

            migrationBuilder.RenameColumn(
                name: "LaunchProgramID",
                table: "Launches",
                newName: "LaunchOrbitID");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_LaunchProgramID",
                table: "Launches",
                newName: "IX_Launches_LaunchOrbitID");

            migrationBuilder.AddColumn<string>(
                name: "Mission",
                table: "Launches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaunchStatuses",
                table: "LaunchStatuses",
                column: "LaunchStatusID");

            migrationBuilder.CreateTable(
                name: "LaunchOrbits",
                columns: table => new
                {
                    LaunchOrbitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchOrbits", x => x.LaunchOrbitID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchOrbits_LaunchOrbitID",
                table: "Launches",
                column: "LaunchOrbitID",
                principalTable: "LaunchOrbits",
                principalColumn: "LaunchOrbitID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchStatuses_LaunchStatusID",
                table: "Launches",
                column: "LaunchStatusID",
                principalTable: "LaunchStatuses",
                principalColumn: "LaunchStatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchOrbits_LaunchOrbitID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchStatuses_LaunchStatusID",
                table: "Launches");

            migrationBuilder.DropTable(
                name: "LaunchOrbits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LaunchStatuses",
                table: "LaunchStatuses");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Launches");

            migrationBuilder.RenameTable(
                name: "LaunchStatuses",
                newName: "LaunchStatus");

            migrationBuilder.RenameColumn(
                name: "LaunchOrbitID",
                table: "Launches",
                newName: "LaunchProgramID");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_LaunchOrbitID",
                table: "Launches",
                newName: "IX_Launches_LaunchProgramID");

            migrationBuilder.AddColumn<int>(
                name: "LaunchPadStatusID",
                table: "LaunchPads",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaunchStatus",
                table: "LaunchStatus",
                column: "LaunchStatusID");

            migrationBuilder.CreateTable(
                name: "LaunchDestinations",
                columns: table => new
                {
                    LaunchDestinationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
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
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchPadStatuses", x => x.LaunchPadStatusID);
                });

            migrationBuilder.CreateTable(
                name: "LaunchPrograms",
                columns: table => new
                {
                    LaunchProgramID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    LaunchDestinationID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchPrograms", x => x.LaunchProgramID);
                    table.ForeignKey(
                        name: "FK_LaunchPrograms_LaunchDestinations_LaunchDestinationID",
                        column: x => x.LaunchDestinationID,
                        principalTable: "LaunchDestinations",
                        principalColumn: "LaunchDestinationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LaunchPads_LaunchPadStatusID",
                table: "LaunchPads",
                column: "LaunchPadStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_LaunchPrograms_LaunchDestinationID",
                table: "LaunchPrograms",
                column: "LaunchDestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchPrograms_LaunchProgramID",
                table: "Launches",
                column: "LaunchProgramID",
                principalTable: "LaunchPrograms",
                principalColumn: "LaunchProgramID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchStatus_LaunchStatusID",
                table: "Launches",
                column: "LaunchStatusID",
                principalTable: "LaunchStatus",
                principalColumn: "LaunchStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaunchPads_LaunchPadStatuses_LaunchPadStatusID",
                table: "LaunchPads",
                column: "LaunchPadStatusID",
                principalTable: "LaunchPadStatuses",
                principalColumn: "LaunchPadStatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
