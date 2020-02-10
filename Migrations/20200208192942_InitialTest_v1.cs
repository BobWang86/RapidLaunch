using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class InitialTest_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "RocketModels",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels",
                column: "ProviderID1",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderID",
                table: "RocketModels",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels",
                column: "ProviderID1",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
