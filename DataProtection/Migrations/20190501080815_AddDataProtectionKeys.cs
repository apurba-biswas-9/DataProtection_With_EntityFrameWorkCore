using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataProtection.Migrations
{
    public partial class AddDataProtectionKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataProtectionXMLElements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Xml = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProtectionXMLElements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataProtectionXMLElements");
        }
    }
}
