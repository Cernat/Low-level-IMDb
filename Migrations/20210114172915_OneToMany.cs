using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesWebApp.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ListOfMovies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListOfMovies_UserId",
                table: "ListOfMovies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMovies_Users_UserId",
                table: "ListOfMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMovies_Users_UserId",
                table: "ListOfMovies");

            migrationBuilder.DropIndex(
                name: "IX_ListOfMovies_UserId",
                table: "ListOfMovies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ListOfMovies");
        }
    }
}
