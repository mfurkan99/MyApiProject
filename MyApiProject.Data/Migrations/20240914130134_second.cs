using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApiProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(4273), "Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(4462), "Home, Garden & Baby" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(4470), "Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 16, 1, 34, 2, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 3, DateTimeKind.Local).AddTicks(6698), "Numquam masanın gördüm gül gitti.", "Filmini." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 3, DateTimeKind.Local).AddTicks(6729), "Orta voluptatem rem sed kulu.", "Corporis." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 3, DateTimeKind.Local).AddTicks(6756), "Enim minima ad uzattı inventore.", "Quae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 5, DateTimeKind.Local).AddTicks(2737), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3.202115957947930m, 839.02m, "Tasty Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 16, 1, 34, 5, DateTimeKind.Local).AddTicks(2764), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1.885995526273320m, 471.32m, "Intelligent Concrete Gloves" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(1525), "Books" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(1532), "Grocery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(1537), "Toys" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 14, 15, 59, 38, 369, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 370, DateTimeKind.Local).AddTicks(3712), "Şafak perferendis accusantium çakıl sequi.", "Sit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 370, DateTimeKind.Local).AddTicks(3742), "Rem sıla consequatur dağılımı ona.", "Koyun." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 370, DateTimeKind.Local).AddTicks(3771), "Quasi dolayı laboriosam adipisci dicta.", "Suscipit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 371, DateTimeKind.Local).AddTicks(9673), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5.611422694931950m, 482.14m, "Handcrafted Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 59, 38, 371, DateTimeKind.Local).AddTicks(9698), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9.270792646708960m, 490.76m, "Handmade Plastic Tuna" });
        }
    }
}
