using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesWebApp.Migrations
{
    public partial class Repair1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMovies_Users_UserId",
                table: "ListOfMovies");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ListOfMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMovies_Users_UserId",
                table: "ListOfMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListOfMovies_Users_UserId",
                table: "ListOfMovies");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ListOfMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ListOfMovies_Users_UserId",
                table: "ListOfMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
