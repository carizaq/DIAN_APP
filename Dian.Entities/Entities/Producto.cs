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
    [Table("TL_PRODUCTOS")]
    public class Producto
    {
        [Key]        
        public int IDProducto { get; set; }        
        public string Nombre { get; set; }        
        public decimal ValorUnidad { get; set; }
        public int UnidadesDisponibles{ get; set; }
        public DateTime FechaIngreso { get; set; }

        public ICollection<DetalleFactura> DetallesFacturas{ get; set; }
    }
}
