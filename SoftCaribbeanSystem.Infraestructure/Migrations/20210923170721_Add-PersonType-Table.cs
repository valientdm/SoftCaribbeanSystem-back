using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftCaribbeanSystem.Infraestructure.Migrations
{
    public partial class AddPersonTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonType",
                table: "Person",
                newName: "PersonTypeId");

            migrationBuilder.CreateTable(
                name: "PersonType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonTypeId",
                table: "Person",
                column: "PersonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_PersonType_PersonTypeId",
                table: "Person",
                column: "PersonTypeId",
                principalTable: "PersonType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_PersonType_PersonTypeId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "PersonType");

            migrationBuilder.DropIndex(
                name: "IX_Person_PersonTypeId",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "PersonTypeId",
                table: "Person",
                newName: "PersonType");
        }
    }
}
