using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTickets.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePicUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Directors SET ProfilePicture = 'http://dotnethow.net/images/producers/producer-1.jpeg' WHERE DirectorId = '1'");
            migrationBuilder.Sql("UPDATE Directors SET ProfilePicture = 'http://dotnethow.net/images/producers/producer-2.jpeg' WHERE DirectorId = '2'");
            migrationBuilder.Sql("UPDATE Directors SET ProfilePicture = 'http://dotnethow.net/images/producers/producer-3.jpeg' WHERE DirectorId = '3'");
            migrationBuilder.Sql("UPDATE Directors SET ProfilePicture = 'http://dotnethow.net/images/producers/producer-4.jpeg' WHERE DirectorId = '4'");
            migrationBuilder.Sql("UPDATE Directors SET ProfilePicture = 'http://dotnethow.net/images/producers/producer-5.jpeg' WHERE DirectorId = '5'");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
