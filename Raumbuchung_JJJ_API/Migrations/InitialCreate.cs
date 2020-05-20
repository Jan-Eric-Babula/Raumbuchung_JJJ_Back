using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Raumbuchung_JJJ_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Floor = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Rooms", x => x.Id); }
            );
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}