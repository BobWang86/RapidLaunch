using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapidLaunch.Migrations
{
    public partial class InitialTest_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RocketModels_Providers_ProviderID",
                table: "RocketModels");

            migrationBuilder.DropForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels");

            migrationBuilder.DropIndex(
                name: "IX_RocketModels_ProviderID",
                table: "RocketModels");

            migrationBuilder.DropIndex(
                name: "IX_RocketModels_ProviderID1",
                table: "RocketModels");

            migrationBuilder.DropColumn(
                name: "ProviderID",
                table: "RocketModels");

            migrationBuilder.DropColumn(
                name: "ProviderID1",
                table: "RocketModels");

            migrationBuilder.CreateTable(
                name: "RocketModelLinks",
                columns: table => new
                {
                    RocketModelLinkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderID = table.Column<int>(nullable: false),
                    RocketModelID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RocketModelLinks", x => x.RocketModelLinkID);
                    table.ForeignKey(
                        name: "FK_RocketModelLinks_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RocketModelLinks_RocketModels_RocketModelID",
                        column: x => x.RocketModelID,
                        principalTable: "RocketModels",
                        principalColumn: "RocketModelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RocketModelLinks_ProviderID",
                table: "RocketModelLinks",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_RocketModelLinks_RocketModelID",
                table: "RocketModelLinks",
                column: "RocketModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RocketModelLinks");

            migrationBuilder.AddColumn<int>(
                name: "ProviderID",
                table: "RocketModels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProviderID1",
                table: "RocketModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RocketModels_ProviderID",
                table: "RocketModels",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_RocketModels_ProviderID1",
                table: "RocketModels",
                column: "ProviderID1");

            migrationBuilder.AddForeignKey(
                name: "FK_RocketModels_Providers_ProviderID",
                table: "RocketModels",
                column: "ProviderID",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RocketModels_Providers_ProviderID1",
                table: "RocketModels",
                column: "ProviderID1",
                principalTable: "Providers",
                principalColumn: "ProviderID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
