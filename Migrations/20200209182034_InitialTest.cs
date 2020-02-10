using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class InitialTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rockets_Providers_ProviderID",
                table: "Rockets");

            migrationBuilder.DropIndex(
                name: "IX_Rockets_ProviderID",
                table: "Rockets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RocketModelLinks",
                table: "RocketModelLinks");

            migrationBuilder.DropIndex(
                name: "IX_RocketModelLinks_ProviderID",
                table: "RocketModelLinks");

            migrationBuilder.DropColumn(
                name: "ProviderID",
                table: "Rockets");

            migrationBuilder.DropColumn(
                name: "RocketModelLinkID",
                table: "RocketModelLinks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RocketModelLinks",
                table: "RocketModelLinks",
                columns: new[] { "ProviderID", "RocketModelID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RocketModelLinks",
                table: "RocketModelLinks");

            migrationBuilder.AddColumn<int>(
                name: "ProviderID",
                table: "Rockets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RocketModelLinkID",
                table: "RocketModelLinks",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RocketModelLinks",
                table: "RocketModelLinks",
                column: "RocketModelLinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Rockets_ProviderID",
                table: "Rockets",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_RocketModelLinks_ProviderID",
                table: "RocketModelLinks",
                column: "ProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rockets_Providers_ProviderID",
                table: "Rockets",
                column: "ProviderID",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
