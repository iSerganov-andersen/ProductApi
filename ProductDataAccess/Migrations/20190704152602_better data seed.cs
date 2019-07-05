using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDataAccess.Migrations
{
    public partial class betterdataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("eaf20c83-b075-4ced-94ed-841a3dacb8bd"), "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("67ba1043-62da-4a8b-99a3-8e4249f899d5"), "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3ef33c24-234c-46d8-9042-fb3c00a7b6ab"), "Cars" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("ae72ef5d-9328-4fc6-877c-129225933928"), new Guid("eaf20c83-b075-4ced-94ed-841a3dacb8bd"), true, "Milk GMZ", 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("603a3303-1060-4e00-acae-c238481a361c"), new Guid("67ba1043-62da-4a8b-99a3-8e4249f899d5"), true, "TV Samsung 40\"", 2999.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("cd45e298-8b20-46e9-b638-32e6aa978a2b"), new Guid("3ef33c24-234c-46d8-9042-fb3c00a7b6ab"), true, "Toyota Tundra V8 4.7L", 64999.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("603a3303-1060-4e00-acae-c238481a361c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae72ef5d-9328-4fc6-877c-129225933928"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd45e298-8b20-46e9-b638-32e6aa978a2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ef33c24-234c-46d8-9042-fb3c00a7b6ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67ba1043-62da-4a8b-99a3-8e4249f899d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaf20c83-b075-4ced-94ed-841a3dacb8bd"));

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
    }
}
