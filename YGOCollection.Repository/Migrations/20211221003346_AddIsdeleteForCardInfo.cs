using Microsoft.EntityFrameworkCore.Migrations;

namespace YGOCollection.Repository.Migrations
{
    public partial class AddIsdeleteForCardInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CardInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CardInfos");
        }
    }
}
