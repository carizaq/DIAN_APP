using Dian02.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dian01.Data.Configurations
{
    public class ClienteConfig:IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(p=>p.NombreCliente).HasColumnName("NOM_CLIENTE").HasMaxLength(300).IsRequired(true);
            builder.Property(p=>p.Telefono).HasColumnName("NUM_TELEFONO").IsRequired(true);
            builder.Property(p=>p.Direccion).HasColumnName("NOM_DIRECCION").HasMaxLength(20).IsRequired(true); 
            builder.Property(p=>p.FechaIngreso).HasColumnName("FEC_INGRESO").IsRequired(true);
            builder.Property(p=>p.Estrato).HasColumnName("COD_ESTRATO").IsRequired(true).HasMaxLength(2);            
            

        }
    }
}
