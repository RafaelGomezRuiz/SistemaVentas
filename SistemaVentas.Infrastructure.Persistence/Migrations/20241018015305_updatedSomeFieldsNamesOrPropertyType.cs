using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentas.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updatedSomeFieldsNamesOrPropertyType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifyBy",
                table: "Ventas",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifyBy",
                table: "Productos",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifyBy",
                table: "Marcas",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifyBy",
                table: "Inventarios",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifyBy",
                table: "ImagenProductos",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "LastModifyBy",
                table: "Categorias",
                newName: "LastModifiedBy");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioOferta",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioOferta",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Ventas",
                newName: "LastModifyBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Productos",
                newName: "LastModifyBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Marcas",
                newName: "LastModifyBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Inventarios",
                newName: "LastModifyBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "ImagenProductos",
                newName: "LastModifyBy");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Categorias",
                newName: "LastModifyBy");
        }
    }
}
