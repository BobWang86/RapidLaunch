using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace RapidLaunch.Migrations
{
    public partial class InitialCreate_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchPrograms_LaunchProjectID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Contacts_ContactID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Positions_JobTitleID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_People_ContactID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "JobTitleID",
                table: "Staff",
                newName: "PositionID");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_JobTitleID",
                table: "Staff",
                newName: "IX_Staff_PositionID");

            migrationBuilder.RenameColumn(
                name: "LaunchProjectID",
                table: "LaunchPrograms",
                newName: "LaunchProgramID");

            migrationBuilder.RenameColumn(
                name: "LaunchProjectID",
                table: "Launches",
                newName: "LaunchProgramID");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_LaunchProjectID",
                table: "Launches",
                newName: "IX_Launches_LaunchProgramID");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "RocketModels",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProviderID1",
                table: "RocketModels",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Percentage",
                table: "PayHistories",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<Point>(
                name: "Location",
                table: "LaunchSites",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuildDate",
                table: "LaunchSites",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LaunchSites",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LaunchPadStatuses",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "LaunchPadCode",
                table: "LaunchPads",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LaunchDestinations",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LaunchDestinations",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RocketModels_ProviderID1",
                table: "RocketModels",
                column: "ProviderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PersonID",
                table: "Contacts",
                column: "PersonID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_People_PersonID",
                table: "Contacts",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchPrograms_LaunchProgramID",
                table: "Launches",
                column: "LaunchProgramID",
                principalTable: "LaunchPrograms",
                principalColumn: "LaunchProgramID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels",
                column: "ProviderID1",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Positions_PositionID",
                table: "Staff",
                column: "PositionID",
                principalTable: "Positions",
                principalColumn: "JobTitleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_People_PersonID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Launches_LaunchPrograms_LaunchProgramID",
                table: "Launches");

            migrationBuilder.DropForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Positions_PositionID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_RocketModels_ProviderID1",
                table: "RocketModels");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PersonID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ProviderID1",
                table: "RocketModels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LaunchSites");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "PositionID",
                table: "Staff",
                newName: "JobTitleID");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_PositionID",
                table: "Staff",
                newName: "IX_Staff_JobTitleID");

            migrationBuilder.RenameColumn(
                name: "LaunchProgramID",
                table: "LaunchPrograms",
                newName: "LaunchProjectID");

            migrationBuilder.RenameColumn(
                name: "LaunchProgramID",
                table: "Launches",
                newName: "LaunchProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Launches_LaunchProgramID",
                table: "Launches",
                newName: "IX_Launches_LaunchProjectID");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "RocketModels",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "People",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Percentage",
                table: "PayHistories",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "LaunchSites",
                nullable: true,
                oldClrType: typeof(Point),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BuildDate",
                table: "LaunchSites",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LaunchPadStatuses",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LaunchPadCode",
                table: "LaunchPads",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LaunchDestinations",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LaunchDestinations",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_ContactID",
                table: "People",
                column: "ContactID");

            migrationBuilder.AddForeignKey(
                name: "FK_Launches_LaunchPrograms_LaunchProjectID",
                table: "Launches",
                column: "LaunchProjectID",
                principalTable: "LaunchPrograms",
                principalColumn: "LaunchProjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Contacts_ContactID",
                table: "People",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Positions_JobTitleID",
                table: "Staff",
                column: "JobTitleID",
                principalTable: "Positions",
                principalColumn: "JobTitleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
