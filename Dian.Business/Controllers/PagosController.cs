using Dian03.Business.DTO;
using Dian03.Business.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Dian03.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController:Controller
    {
        private readonly IPagosRepository<PagoDTO> _pagosRepository;

        public PagosController(IPagosRepository<PagoDTO> pagosRepository)
        {
            this._pagosRepository = pagosRepository;
        }

        [HttpGet]
        [Route("ObtenerPagos/")]
        public async Task<IEnumerable<PagoDTO>> ObtenerTodosPagos()
        {
            return await _pagosRepository.ObtenerTodosPagos();
        }

        [HttpPost]
        [Route("AlmacenarPagos/")]
        public async Task<PagoDTO> AlmacenarPagos()
        {
            throw new NotImplementedException();
        }
        
    }
}
