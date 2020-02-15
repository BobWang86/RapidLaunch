using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class DevTest_v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Contacts_ContactID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_People_PersonID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Staff_StaffID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ContactID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "People",
                newName: "ContactID");

            migrationBuilder.RenameIndex(
                name: "IX_People_StaffID",
                table: "People",
                newName: "IX_People_ContactID");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Contacts",
                newName: "AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_PersonID",
                table: "Contacts",
                newName: "IX_Contacts_AddressID");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Staff",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PersonID",
                table: "Staff",
                column: "PersonID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddressID",
                table: "Contacts",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Contacts_ContactID",
                table: "People",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_People_PersonID",
                table: "Staff",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddressID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Contacts_ContactID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_People_PersonID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_PersonID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "People",
                newName: "StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_People_ContactID",
                table: "People",
                newName: "IX_People_StaffID");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Contacts",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_AddressID",
                table: "Contacts",
                newName: "IX_Contacts_PersonID");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "People",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "People",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactID",
                table: "Addresses",
                column: "ContactID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Contacts_ContactID",
                table: "Addresses",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_People_PersonID",
                table: "Contacts",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Staff_StaffID",
                table: "People",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "StaffID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
