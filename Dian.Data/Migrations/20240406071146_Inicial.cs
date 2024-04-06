using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dian01.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TL_CLIENTES",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_CLIENTE = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    NUM_TELEFONO = table.Column<long>(type: "bigint", nullable: false),
                    NOM_DIRECCION = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FEC_INGRESO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    COD_ESTRATO = table.Column<short>(type: "smallint", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TL_CLIENTES", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "TL_PRODUCTOS",
                columns: table => new
                {
                    IDProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_PRODUCTO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VAL_UNITARIO = table.Column<decimal>(type: "decimal(15,0)", precision: 15, scale: 0, nullable: false),
                    NUM_UNIDADES_DISPONIBLES = table.Column<int>(type: "int", nullable: false),
                    FEC_INGRESO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TL_PRODUCTOS", x => x.IDProducto);
                });

            migrationBuilder.CreateTable(
                name: "TL_TIPOS_TARJETA_CREDITO",
                columns: table => new
                {
                    IDE_TIPO_TARJETA = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_TIPO_TARJETA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TL_TIPOS_TARJETA_CREDITO", x => x.IDE_TIPO_TARJETA);
                });

            migrationBuilder.CreateTable(
                name: "TL_FACTURAS",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FEC_FACTURA = table.Column<DateTime>(type: "date", nullable: false),
                    IDE_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    VAL_FACTURA = table.Column<decimal>(type: "decimal(15,0)", precision: 15, scale: 0, nullable: false),
                    COD_TIPO_PAGO = table.Column<int>(type: "int", nullable: false),
                    IDE_TIPO_TARJETA = table.Column<short>(type: "smallint", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TL_FACTURAS", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FACT_CLIE_FK",
                        column: x => x.IDE_CLIENTE,
                        principalTable: "TL_CLIENTES",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FACT_TITC_FK",
                        column: x => x.IDE_TIPO_TARJETA,
                        principalTable: "TL_TIPOS_TARJETA_CREDITO",
                        principalColumn: "IDE_TIPO_TARJETA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TL_DETALLES_FACTURAS",
                columns: table => new
                {
                    IDE_FACTURA = table.Column<int>(type: "int", nullable: false),
                    IDE_PRODUCTO = table.Column<int>(type: "int", nullable: false),
                    NUM_UNIDADES = table.Column<int>(type: "int", nullable: false),
                    VAL_SUBTOTAL = table.Column<decimal>(type: "decimal(22,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TL_DETALLES_FACTURAS", x => new { x.IDE_FACTURA, x.IDE_PRODUCTO });
                    table.ForeignKey(
                        name: "DEFA_FACT_FK",
                        column: x => x.IDE_FACTURA,
                        principalTable: "TL_FACTURAS",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "DEFA_PROD_FK",
                        column: x => x.IDE_FACTURA,
                        principalTable: "TL_PRODUCTOS",
                        principalColumn: "IDProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TL_FACTURAS_IDE_CLIENTE",
                table: "TL_FACTURAS",
                column: "IDE_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_TL_FACTURAS_IDE_TIPO_TARJETA",
                table: "TL_FACTURAS",
                column: "IDE_TIPO_TARJETA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TL_DETALLES_FACTURAS");

            migrationBuilder.DropTable(
                name: "TL_FACTURAS");

            migrationBuilder.DropTable(
                name: "TL_PRODUCTOS");

            migrationBuilder.DropTable(
                name: "TL_CLIENTES");

            migrationBuilder.DropTable(
                name: "TL_TIPOS_TARJETA_CREDITO");
        }
    }
}
