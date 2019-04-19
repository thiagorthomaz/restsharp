using Microsoft.EntityFrameworkCore.Migrations;

namespace restsharp.Migrations
{
    public partial class SeedPostStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Published')");
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Draft')");
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Trash')");
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Pending')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
