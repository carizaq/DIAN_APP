using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dian02.Entities.Entities
{
    [Table("TL_PROVEEDORES")]
    public class Proveedor
    {
        [Key]
        [Required]
        [Column("IDE_PROVEEDOR")]
        public int IdProveedor { get; set; }
        [Required]
        [MaxLength(30)]
        [Column("NOM_NOMBRE_PROVEEDOR")]
        public string NombreProveedor { get; set; }

        /// <summary>
        /// CC = Cédula de ciudadanía; CE = Cédula extranjería; NIT = NIT;PEP = permiso especial de permanencia;PA = Pasaporte
        /// </summary>
        [Required]
        [MaxLength(3)]
        [Column("COD_TIPO_IDENTIFICACION")]
        public string TipoIdentificacion { get; set; }
        
        [Required]
        [MaxLength(30)]
        [Column("NUM_IDENTIFICACION")]
        public string NumeroIdentificacion { get; set; }

        public ICollection<Factura> Facturas { get; set; }
    }
}
