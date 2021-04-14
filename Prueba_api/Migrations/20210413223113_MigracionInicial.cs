using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba_Api.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infomacionitems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_creacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_actualizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estatus = table.Column<byte>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infomacionitems", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infomacionitems");
        }
    }
}
