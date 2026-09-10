using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libreria.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioVoNombre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Usuarios",
                newName: "Nombre_Value");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre_Value",
                table: "Usuarios",
                newName: "Nombre");
        }
    }
}
