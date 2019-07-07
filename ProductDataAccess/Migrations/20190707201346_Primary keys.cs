using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDataAccess.Migrations
{
    public partial class Primarykeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("c94ff890-a18c-497b-9c4e-48918594dbf5"), "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("64560d29-fa1d-4e9d-8b74-7f760b74985b"), "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d752edae-2e55-44db-802a-c3b9c6c5d5c9"), "Cars" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("607ecc78-1ce4-4edc-bcce-541e2776416e"), new Guid("c94ff890-a18c-497b-9c4e-48918594dbf5"), true, "Milk GMZ", 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("26bfc2de-3fd8-408e-b6ea-f97d4145088c"), new Guid("64560d29-fa1d-4e9d-8b74-7f760b74985b"), true, "TV Samsung 40\"", 2999.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "IsActive", "Name", "Price" },
                values: new object[] { new Guid("9276a4b5-a2fe-4abd-8b3f-acd289b89bdc"), new Guid("d752edae-2e55-44db-802a-c3b9c6c5d5c9"), true, "Toyota Tundra V8 4.7L", 64999.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26bfc2de-3fd8-408e-b6ea-f97d4145088c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("607ecc78-1ce4-4edc-bcce-541e2776416e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9276a4b5-a2fe-4abd-8b3f-acd289b89bdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64560d29-fa1d-4e9d-8b74-7f760b74985b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c94ff890-a18c-497b-9c4e-48918594dbf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d752edae-2e55-44db-802a-c3b9c6c5d5c9"));

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
    }
}
