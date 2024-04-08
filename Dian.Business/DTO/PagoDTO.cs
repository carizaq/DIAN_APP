using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dian03.Business.DTO
{
    public class PagoDTO
    {
        public int IdProveedor { get; set; }
        
        public string NombreProveedor { get; set; }

        /// <summary>
        /// CC = Cédula de ciudadanía; CE = Cédula extranjería; NIT = NIT;PEP = permiso especial de permanencia;PA = Pasaporte
        /// </summary>        
        public string TipoIdentificacion { get; set; }
        
        public string NumeroIdentificacion { get; set; }
        
        public DateTime FechaFactura { get; set; }
    }
}
