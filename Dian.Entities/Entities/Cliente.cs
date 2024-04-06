using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dian02.Entities.Entities
{
    [Table("TL_CLIENTES")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public Int64 Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public short Estrato { get; set; }

        public ICollection<Factura> Facturas { get; set; }
    }
}
