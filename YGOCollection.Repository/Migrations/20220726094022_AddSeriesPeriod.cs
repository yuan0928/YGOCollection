using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YGOCollection.Repository.Migrations
{
    public partial class AddSeriesPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "CardSeries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "CardSeries");
        }
    }
}
