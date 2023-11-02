using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_commerce_api.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name" },
                values: new object[] { new Guid("29a6c741-bfe8-4a4c-8f8e-4d4d5951b18b"), "Street 13", "mijael.rcf@gmail", "Mijael Callejas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("29a6c741-bfe8-4a4c-8f8e-4d4d5951b18b"));
        }
    }
}
