using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ca147fa-1911-451b-8c1f-d8d75b5b8c38", "02fd6bfd-2544-4232-8b6f-3f6a2c51b318", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f0b0ed3-eaeb-4de6-ac63-0a3cd3d86db2", "14cdf37a-8168-4953-8820-ff92c5cc2138", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8eccd454-9b7c-4e46-a5d5-1c3fae1cf9e7", "378b3b0e-66f3-4742-90c4-b2483166cbe0", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ca147fa-1911-451b-8c1f-d8d75b5b8c38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f0b0ed3-eaeb-4de6-ac63-0a3cd3d86db2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8eccd454-9b7c-4e46-a5d5-1c3fae1cf9e7");
        }
    }
}
