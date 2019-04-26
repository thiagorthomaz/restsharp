using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sharppress.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime CurrentTime = DateTime.Now;
            migrationBuilder.Sql("insert into Categories (Name, SiteId, Description, Slug, CreatedAt) values ('Uncategorized', (SELECT ID FROM Sites where Name='Site-1'), 'The default Category of your posts if none were defined.', 'uncategorized' , GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
