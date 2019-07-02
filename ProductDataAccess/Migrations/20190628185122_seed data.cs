using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e87be121-59e5-43a3-a09b-6e8e0d6afabe"), "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ecf61ca2-eb9c-4ba3-b283-0badd8a6547b"), "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7a36367e-95b3-498b-a95b-43d53952e04b"), "Cars" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("3ae81e5e-7084-4eeb-ab72-75e5d9022607"), new Guid("e87be121-59e5-43a3-a09b-6e8e0d6afabe"), true, "Milk GMZ", 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("03f1457b-219b-4d22-be20-111f79301717"), new Guid("ecf61ca2-eb9c-4ba3-b283-0badd8a6547b"), true, "TV Samsung 40\"", 2999.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("cf66b994-4155-4373-8d7f-d297ffc4bbcb"), new Guid("7a36367e-95b3-498b-a95b-43d53952e04b"), true, "Toyota Tundra V8 4.7L", 64999.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03f1457b-219b-4d22-be20-111f79301717"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ae81e5e-7084-4eeb-ab72-75e5d9022607"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf66b994-4155-4373-8d7f-d297ffc4bbcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a36367e-95b3-498b-a95b-43d53952e04b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e87be121-59e5-43a3-a09b-6e8e0d6afabe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecf61ca2-eb9c-4ba3-b283-0badd8a6547b"));
        }
    }
}
