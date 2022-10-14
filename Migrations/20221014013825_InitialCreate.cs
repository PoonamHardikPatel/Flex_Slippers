using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flex_Slippers.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slipper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfProduct = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Size = table.Column<decimal>(nullable: false),
                    Width = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    DescOfProduct = table.Column<string>(nullable: true),
                    ManufacturingDt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slipper", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slipper");
        }
    }
}
