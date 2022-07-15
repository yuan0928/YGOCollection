using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YGOCollection.Repository.Migrations
{
    public partial class AddCardPieceAndImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Piece",
                table: "CardSeries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "CardInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Piece",
                table: "CardSeries");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "CardInfos");
        }
    }
}
