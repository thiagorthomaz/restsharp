using Microsoft.EntityFrameworkCore.Migrations;

namespace sharppress.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Published')");
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Draft')");
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Trash')");
            migrationBuilder.Sql("insert into PostStatus (Description) values ('Pending')");
            
            migrationBuilder.Sql("insert into Sites (Name, Description, CreatedAt, UpdatedAt) values ('Site-1', 'One simple site to explorer some features.', GETDATE(), GETDATE())");

            migrationBuilder.Sql("insert into Categories (Name, SiteId, Description, Slug, CreatedAt) values ('Uncategorized', (SELECT ID FROM Sites where Name='Site-1'), 'The default Category of your posts if none were defined.', 'uncategorized' , GETDATE())");

            migrationBuilder.Sql("insert into Posts (CreatedAt, PostTitle, PostStatusId, SiteId, PostAt, PostContent) values (GETDATE(), 'Hello World', (SELECT ID FROM PostStatus where Description='Published'), (SELECT ID FROM Sites where Name='Site-1'), GETDATE(), 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec dolor laoreet, rutrum lacus eu, luctus enim. Phasellus vel bibendum nulla. Integer ac tellus a justo vulputate maximus in sed eros. Nullam auctor quam lectus, eu eleifend velit consectetur eu. Praesent et odio dapibus velit posuere molestie nec non dui. Proin sit amet erat suscipit, sodales risus quis, cursus ex. Phasellus hendrerit enim et nisl egestas, et congue massa condimentum. Etiam vitae neque at felis mollis volutpat id sed ante. Vivamus non auctor risus. Proin at tellus quis arcu placerat varius.<br><br>Morbi laoreet varius risus, sit amet congue nisi aliquam nec. Vestibulum consectetur hendrerit augue eu vestibulum. Maecenas orci ex, elementum sit amet ex ut, venenatis interdum tellus. Phasellus elit ligula, fermentum non diam mattis, accumsan interdum sapien. Nam sit amet tincidunt urna, a vulputate dolor. Mauris vitae egestas elit. Nulla ac eros in nunc luctus egestas. Vivamus dictum orci quis leo sodales iaculis. Cras tempor sem posuere purus congue, eu venenatis ante tincidunt.')");

            migrationBuilder.Sql("insert into PostsCategories (PostId, CategoryId) values ((SELECT ID FROM Posts where PostTitle='Hello World'), (SELECT ID FROM Categories where Slug='uncategorized'));");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
