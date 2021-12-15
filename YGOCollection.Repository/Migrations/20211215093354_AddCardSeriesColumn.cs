using Microsoft.EntityFrameworkCore.Migrations;

namespace YGOCollection.Repository.Migrations
{
    public partial class AddCardSeriesColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CardSeries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SeriesCode",
                table: "CardSeries",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CardSeries");

            migrationBuilder.DropColumn(
                name: "SeriesCode",
                table: "CardSeries");
        }
    }
}
