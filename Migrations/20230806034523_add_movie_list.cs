using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace auth.Migrations
{
    /// <inheritdoc />
    public partial class add_movie_list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDetail", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MovieDetail",
                columns: new[] { "Id", "Description", "MovieName", "Rating", "Url" },
                values: new object[,]
                {
                    { 1, "the planet's first line of defense against the most powerful threats in the universe", "Avenger End Game", 8, "https://lumiere-a.akamaihd.net/v1/images/p_avengersendgame_19751_e14a0104.jpeg?region=0%2C0%2C540%2C810" },
                    { 2, "Harry Potter and the Philosopher's Stone (released in the United States and India as Harry Potter and the Sorcerer's Stone) is a 2001 fantasy film directed by Chris Columbus and produced by David Heyman, from a screenplay by Steve Kloves, based on the 1997 novel of the same name by J. K. Rowling.", "Harry Potter and the Philosopher's Stone", 9, "https://images.moviesanywhere.com/143cdb987186a1c8f94d4f18de211216/fdea56fa-2703-47c1-8da8-70fc5382e1ea.webp?h=375&resize=fit&w=250" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDetail");
        }
    }
}
