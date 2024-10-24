﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVentas.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class propiedadEnEntidadCarrito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadRequerida",
                table: "CarritoCompras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadRequerida",
                table: "CarritoCompras");
        }
    }
}
