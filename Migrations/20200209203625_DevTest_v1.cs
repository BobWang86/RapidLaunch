using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class DevTest_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaunchedDateTime",
                table: "Launches");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Launches");

            migrationBuilder.RenameColumn(
                name: "PlannedDateTime",
                table: "Launches",
                newName: "LaunchTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "LaunchDate",
                table: "Launches",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaunchDate",
                table: "Launches");

            migrationBuilder.RenameColumn(
                name: "LaunchTime",
                table: "Launches",
                newName: "PlannedDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "LaunchedDateTime",
                table: "Launches",
                type: "DateTime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mission",
                table: "Launches",
                nullable: true);
        }
    }
}
