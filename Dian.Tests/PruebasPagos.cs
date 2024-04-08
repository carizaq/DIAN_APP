using Dian03.Business.Controllers;
using Dian03.Business.DTO;
using Dian03.Business.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Dian.Tests
{
    public class PruebasPagos
    {
        private readonly ArchivoController _archivocontroller;
        private readonly PagosController _pagosController;
        private readonly IArchivoRepository _archivoRepository;
        private readonly IPagosRepository<PagoDTO> _pagosRepository;


        public PruebasPagos(ArchivoController archivocontroller, PagosController pagosController, IArchivoRepository archivoRepository, IPagosRepository<PagoDTO> pagosRepository)
        {
            _archivocontroller = archivocontroller;
            _pagosController = pagosController;
            _archivoRepository = archivoRepository;
            _pagosRepository = pagosRepository;
        }


        /// <summary>
        /// Prueba que el servicio expuesto este fucnionando correctamente
        /// </summary>
        [Fact]
        public void ObtenerTodosPagos_Ok()
        {
            var rta = _pagosController.ObtenerTodosPagos();
            Assert.IsType<OkObjectResult>(rta);
        }
    }
}