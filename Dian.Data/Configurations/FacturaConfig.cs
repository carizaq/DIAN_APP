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
    public class FacturaConfig
    {
        public class ClienteConfig : IEntityTypeConfiguration<Factura>
        {
            public void Configure(EntityTypeBuilder<Factura> builder)
            {
                builder.Property(p => p.IdFactura).HasColumnName("IDE_FACTURA");
                builder.Property(p => p.Fecha).HasColumnName("FEC_FACTURA").IsRequired(true).HasColumnType("date");
                builder.Property(p => p.IdCliente).HasColumnName("IDE_CLIENTE").IsRequired(true);
                builder.Property(p => p.Valor).HasColumnName("VAL_FACTURA").IsRequired(true).HasPrecision(precision:15,scale:0); 
                builder.Property(p => p.CodigoTipoPago).HasColumnName("COD_TIPO_PAGO").IsRequired(true).HasPrecision(2);
                builder.Property(p => p.IdTipoTarjeta).HasColumnName("IDE_TIPO_TARJETA").HasMaxLength(2);
                builder.Property(p => p.IdProveedor).HasColumnName("IDE_PROVEEDOR").IsRequired(true);

            }
        }
    }
}
