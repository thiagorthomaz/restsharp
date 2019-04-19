using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace restsharp.Migrations
{
    public partial class SeedSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime CurrentTime = DateTime.Now;
            migrationBuilder.Sql("insert into Sites (Name, Description, CreatedAt, UpdatedAt) values ('Site-1', 'One simple site to explorer some features.', '" +  CurrentTime + "', '" +  CurrentTime + "')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
