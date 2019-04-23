using Microsoft.EntityFrameworkCore.Migrations;

namespace restsharp.Migrations
{
    public partial class SeedPostCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into PostsCategories (PostId, CategoryId) values ((SELECT ID FROM Posts where PostTitle='Hello World'), (SELECT ID FROM Categories where Slug='uncategorized'));");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
