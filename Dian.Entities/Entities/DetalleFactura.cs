using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dian02.Entities.Entities
{
    [Table("TL_DETALLES_FACTURAS")]
    public class DetalleFactura
    {
        [Column("IDE_FACTURA")]
        [Required]
        public int IdFactura { get; set; }
        
        [Column("IDE_PRODUCTO")]
        [Required]
        public int IdProducto { get; set; }

        [Column("NUM_UNIDADES")]
        [Required]
        public int Unidades { get; set; }

        [Column("VAL_SUBTOTAL", TypeName = "decimal(22, 0)")]        
        [Required]
        public decimal Subtotal { get; set; }

        public Factura Factura{ get; set; }
        public Producto Producto { get; set; }
    }
}
