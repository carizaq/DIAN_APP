using Dian02.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dian01.Data.Configurations
{
    public class ProductoConfig
    {
        public class ClienteConfig : IEntityTypeConfiguration<Producto>
        {
            public void Configure(EntityTypeBuilder<Producto> builder)
            {
                builder.Property(p => p.IDProducto).HasColumnName("IDE_PRODUCTO");
                builder.Property(p => p.Nombre).HasColumnName("NOM_PRODUCTO").IsRequired(true).HasMaxLength(20);
                builder.Property(p => p.ValorUnidad).HasColumnName("VAL_UNITARIO").IsRequired(true).HasPrecision(precision: 10, scale: 0); ;
                builder.Property(p => p.UnidadesDisponibles).HasColumnName("NUM_UNIDADES_DISPONIBLES").IsRequired(true).HasPrecision(10);
                builder.Property(p => p.FechaIngreso).HasColumnName("FEC_INGRESO").IsRequired(true).HasColumnType("date");

            }
        }
    }
}
