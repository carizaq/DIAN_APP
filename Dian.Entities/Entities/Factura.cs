using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dian02.Entities.Entities
{
    [Table("TL_FACTURAS")]
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        public DateTime Fecha{ get; set; }
        public int IdCliente { get; set; }
        public decimal Valor{ get; set; }
        public int CodigoTipoPago{ get; set; }
        public short IdTipoTarjeta { get; set; }

        public Cliente Cliente { get; set; }
        public TipoTarjetaCredito TipoTarjetaCredito { get; set; }

        public ICollection<DetalleFactura> DetallesFacturas { get; set; }

    }
}
