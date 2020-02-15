using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class DevTest_v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchPads_LaunchPadID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Rockets_RocketID",
                table: "Launches");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchPads_LaunchPadID",
                table: "Launches",
                column: "LaunchPadID",
                principalTable: "LaunchPads",
                principalColumn: "LaunchPadID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Rockets_RocketID",
                table: "Launches",
                column: "RocketID",
                principalTable: "Rockets",
                principalColumn: "RocketID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchPads_LaunchPadID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_Rockets_RocketID",
                table: "Launches");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchPads_LaunchPadID",
                table: "Launches",
                column: "LaunchPadID",
                principalTable: "LaunchPads",
                principalColumn: "LaunchPadID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_Rockets_RocketID",
                table: "Launches",
                column: "RocketID",
                principalTable: "Rockets",
                principalColumn: "RocketID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
