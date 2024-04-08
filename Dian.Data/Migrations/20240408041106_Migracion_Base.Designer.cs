﻿// <auto-generated />
using System;
using Dian01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dian01.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240408041106_Migracion_Base")]
    partial class Migracion_Base
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dian02.Entities.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDE_CLIENTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NOM_DIRECCION");

                    b.Property<short>("Estrato")
                        .HasPrecision(2)
                        .HasColumnType("smallint")
                        .HasColumnName("COD_ESTRATO");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("date")
                        .HasColumnName("FEC_INGRESO");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("NOM_CLIENTE");

                    b.Property<long>("Telefono")
                        .HasPrecision(16)
                        .HasColumnType("bigint")
                        .HasColumnName("NUM_TELEFONO");

                    b.HasKey("IdCliente");

                    b.ToTable("TL_CLIENTES");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.DetalleFactura", b =>
                {
                    b.Property<int>("IdFactura")
                        .HasColumnType("int")
                        .HasColumnName("IDE_FACTURA");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int")
                        .HasColumnName("IDE_PRODUCTO");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(22, 0)")
                        .HasColumnName("VAL_SUBTOTAL");

                    b.Property<int>("Unidades")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasColumnName("NUM_UNIDADES");

                    b.HasKey("IdFactura", "IdProducto");

                    b.ToTable("TL_DETALLES_FACTURAS");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Factura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDE_FACTURA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<int>("CodigoTipoPago")
                        .HasPrecision(2)
                        .HasColumnType("int")
                        .HasColumnName("COD_TIPO_PAGO");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date")
                        .HasColumnName("FEC_FACTURA");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("IDE_CLIENTE");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int")
                        .HasColumnName("IDE_PROVEEDOR");

                    b.Property<short>("IdTipoTarjeta")
                        .HasMaxLength(2)
                        .HasColumnType("smallint")
                        .HasColumnName("IDE_TIPO_TARJETA");

                    b.Property<decimal>("Valor")
                        .HasPrecision(15)
                        .HasColumnType("decimal(15,0)")
                        .HasColumnName("VAL_FACTURA");

                    b.HasKey("IdFactura");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdProveedor");

                    b.HasIndex("IdTipoTarjeta");

                    b.ToTable("TL_FACTURAS");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Producto", b =>
                {
                    b.Property<int>("IDProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDE_PRODUCTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDProducto"));

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("date")
                        .HasColumnName("FEC_INGRESO");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NOM_PRODUCTO");

                    b.Property<int>("UnidadesDisponibles")
                        .HasPrecision(10)
                        .HasColumnType("int")
                        .HasColumnName("NUM_UNIDADES_DISPONIBLES");

                    b.Property<decimal>("ValorUnidad")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,0)")
                        .HasColumnName("VAL_UNITARIO");

                    b.HasKey("IDProducto");

                    b.ToTable("TL_PRODUCTOS");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDE_PROVEEDOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NOM_NOMBRE_PROVEEDOR");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NUM_IDENTIFICACION");

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("COD_TIPO_IDENTIFICACION");

                    b.HasKey("IdProveedor");

                    b.ToTable("TL_PROVEEDORES");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.TipoTarjetaCredito", b =>
                {
                    b.Property<short>("IdTipoTarjeta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("IDE_TIPO_TARJETA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("IdTipoTarjeta"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOM_TIPO_TARJETA");

                    b.HasKey("IdTipoTarjeta");

                    b.ToTable("TL_TIPOS_TARJETA_CREDITO");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.DetalleFactura", b =>
                {
                    b.HasOne("Dian02.Entities.Entities.Producto", "Producto")
                        .WithMany("DetallesFacturas")
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("DEFA_PROD_FK");

                    b.HasOne("Dian02.Entities.Entities.Factura", "Factura")
                        .WithMany("DetallesFacturas")
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("DEFA_FACT_FK");

                    b.Navigation("Factura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Factura", b =>
                {
                    b.HasOne("Dian02.Entities.Entities.Cliente", "Cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FACT_CLIE_FK");

                    b.HasOne("Dian02.Entities.Entities.Proveedor", "Proveedor")
                        .WithMany("Facturas")
                        .HasForeignKey("IdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FACT_PROV_FK");

                    b.HasOne("Dian02.Entities.Entities.TipoTarjetaCredito", "TipoTarjetaCredito")
                        .WithMany("Facturas")
                        .HasForeignKey("IdTipoTarjeta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FACT_TITC_FK");

                    b.Navigation("Cliente");

                    b.Navigation("Proveedor");

                    b.Navigation("TipoTarjetaCredito");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Cliente", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Factura", b =>
                {
                    b.Navigation("DetallesFacturas");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Producto", b =>
                {
                    b.Navigation("DetallesFacturas");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.Proveedor", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("Dian02.Entities.Entities.TipoTarjetaCredito", b =>
                {
                    b.Navigation("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}
