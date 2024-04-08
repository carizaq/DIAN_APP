using Dian03.Business.Controllers;
using Dian03.Business.DTO;
using Dian03.Business.IRepository;

namespace DianAppTest
{
    [TestClass]
    public class PagosUnitTest
    {
        private readonly ArchivoController _archivocontroller;
        private readonly PagosController _pagosController;
        private readonly IArchivoRepository _archivoRepository;
        private readonly IPagosRepository<PagoDTO> _pagosRepository;


        public PagosUnitTest(ArchivoController archivocontroller, PagosController pagosController, IArchivoRepository archivoRepository, IPagosRepository<PagoDTO> pagosRepository)
        {
            _archivocontroller = archivocontroller;
            _pagosController = pagosController;
            _archivoRepository = archivoRepository;
            _pagosRepository = pagosRepository;
        }

        [Fact]
        public void ObtenerTodosPagos_OK()
        {
            var rta = _pagosController.ObtenerTodosPagos();

            Assert.IsType<rta>();
                
        }
    }
}