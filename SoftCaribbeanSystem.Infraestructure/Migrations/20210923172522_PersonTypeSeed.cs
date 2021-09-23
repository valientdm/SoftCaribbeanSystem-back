using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftCaribbeanSystem.Infraestructure.Migrations
{
    public partial class PersonTypeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonType",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { 1, new DateTime(2021, 9, 23, 12, 25, 22, 405, DateTimeKind.Local).AddTicks(2699), null, "Employee" });

            migrationBuilder.InsertData(
                table: "PersonType",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { 2, new DateTime(2021, 9, 23, 12, 25, 22, 406, DateTimeKind.Local).AddTicks(6865), null, "Patient" });

            migrationBuilder.InsertData(
                table: "PersonType",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { 3, new DateTime(2021, 9, 23, 12, 25, 22, 406, DateTimeKind.Local).AddTicks(6889), null, "Worker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonType",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
