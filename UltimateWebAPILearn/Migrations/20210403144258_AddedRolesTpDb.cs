using Microsoft.EntityFrameworkCore.Migrations;

namespace UltimateWebAPILearn.Migrations
{
    public partial class AddedRolesTpDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d686111-31c5-4d90-8b9a-c967effe6dd9", "bcc9d017-7a41-4057-ab8f-0a2db875ddc9", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af8f9bd0-75d0-46ef-955c-1692666441a4", "f1b2bf72-d40e-4da7-a963-62cb6efb190a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d686111-31c5-4d90-8b9a-c967effe6dd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af8f9bd0-75d0-46ef-955c-1692666441a4");
        }
    }
}
