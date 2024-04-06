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
    [Table("TL_TIPOS_TARJETA_CREDITO")]
    public class TipoTarjetaCredito
    {
        [Key]
        [Column("IDE_TIPO_TARJETA")]
        public short IdTipoTarjeta { get; set; }

        [MaxLength(50)]
        [Required]
        [Column("NOM_TIPO_TARJETA")]
        public string Nombre { get; set; }

        public ICollection<Factura> Facturas{ get; set; }
    }
}
