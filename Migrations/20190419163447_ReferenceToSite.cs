using Microsoft.EntityFrameworkCore.Migrations;

namespace restsharp.Migrations
{
    public partial class ReferenceToSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Midias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SiteId",
                table: "Posts",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Midias_SiteId",
                table: "Midias",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SiteId",
                table: "Categories",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sites_SiteId",
                table: "Categories",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Midias_Sites_SiteId",
                table: "Midias",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Sites_SiteId",
                table: "Posts",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sites_SiteId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Midias_Sites_SiteId",
                table: "Midias");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Sites_SiteId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SiteId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Midias_SiteId",
                table: "Midias");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SiteId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Midias");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Categories");
        }
    }
}
