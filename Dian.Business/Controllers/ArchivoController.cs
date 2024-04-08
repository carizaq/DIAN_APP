using Dian03.Business.DTO;
using Dian03.Business.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Dian03.Business.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchivoController : ControllerBase
    {
        private readonly IArchivoRepository _archivoRepository;

        public ArchivoController(IArchivoRepository archivoRepository)
        {
            this._archivoRepository = archivoRepository;
        }

        [HttpPost]
        [Route("CargarArchivo/")]
        public async Task<bool> CargarRegistrosArchivo(IFormFile pFile)
        {
            return await _archivoRepository.CargarRegistrosArchivo(pFile);
        }
    }
}
