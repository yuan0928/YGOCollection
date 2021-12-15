using Microsoft.EntityFrameworkCore.Migrations;

namespace YGOCollection.Repository.Migrations
{
    public partial class AddCarTypeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 1, "怪獸卡" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 2, "魔法卡" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 3, "陷阱卡" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
