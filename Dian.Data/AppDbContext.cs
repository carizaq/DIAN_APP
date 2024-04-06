using Dian02.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dian01.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<DetalleFactura>().HasKey(p => new {p.IdFactura,p.IdProducto });

            //Se ajusta las foreignKey entre las diferentes tablas: 
            //Relación uno a muchos de Clientes -Facturas
            modelBuilder.Entity<Cliente>()
                .HasMany<Factura>(f => f.Facturas)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.IdCliente)
                .HasConstraintName("FACT_CLIE_FK");
            //.OnDelete(DeleteBehavior.Cascade);

            //Relación uno a muchos de Facturas - Tipos_Tarjetas_Credito
            modelBuilder.Entity<TipoTarjetaCredito>()
                .HasMany<Factura>(f => f.Facturas)
                .WithOne(t => t.TipoTarjetaCredito)
                .HasForeignKey(t => t.IdTipoTarjeta)
                .HasConstraintName("FACT_TITC_FK");

            //Relación uno a muchos de Detalles_Facturas - Facturas
            modelBuilder.Entity<Factura>()
                .HasMany<DetalleFactura>(f => f.DetallesFacturas)
                .WithOne(d => d.Factura)
                .HasForeignKey(c => c.IdFactura)
                .HasConstraintName("DEFA_FACT_FK");

            //Relación uno a muchos de Detalles_Facturas - Productos
            modelBuilder.Entity<Producto>()
                .HasMany<DetalleFactura>(f => f.DetallesFacturas)
                .WithOne(p => p.Producto)
                .HasForeignKey(p => p.IdFactura)
                .HasConstraintName("DEFA_PROD_FK");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleFactura> DetallesFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoTarjetaCredito> TipoTarjetaCredito{ get; set; }
    }
}
