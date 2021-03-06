using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eletric_app.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "VeiculosE",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Motor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Capacidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   Autonomia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   Eficiencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   Data = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_VeiculosE", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VeiculosE");
        }
    }
}
