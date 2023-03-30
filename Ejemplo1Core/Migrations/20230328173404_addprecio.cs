using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejemplo1Core.Migrations
{
    /// <inheritdoc />
    public partial class addprecio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "libro",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "libro");
        }
    }
}
