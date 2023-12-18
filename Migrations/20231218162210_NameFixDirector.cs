using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTickets.Migrations
{
    /// <inheritdoc />
    public partial class NameFixDirector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePic",
                table: "Directors",
                newName: "ProfilePicture");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Directors",
                newName: "ProfilePic");
        }
    }
}
