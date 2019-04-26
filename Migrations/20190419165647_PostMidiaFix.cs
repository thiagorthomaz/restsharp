using Microsoft.EntityFrameworkCore.Migrations;

namespace sharppress.Migrations
{
    public partial class PostMidiaFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Midias_MidiaId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "MidiaId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Midias_MidiaId",
                table: "Posts",
                column: "MidiaId",
                principalTable: "Midias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Midias_MidiaId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "MidiaId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Midias_MidiaId",
                table: "Posts",
                column: "MidiaId",
                principalTable: "Midias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
