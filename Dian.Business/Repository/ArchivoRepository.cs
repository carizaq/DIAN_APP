using Dian03.Business.IRepository;

namespace Dian03.Business.Repository
{
    public class ArchivoRepository: IArchivoRepository
    {       
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ArchivoRepository(IWebHostEnvironment pWebHostEnvironment)
        {
            _webHostEnvironment = pWebHostEnvironment;
        }

        public Task<bool> CargarRegistrosArchivo(IFormFile pFile)
        {
            return Task.FromResult(true);   
        }

        async Task CargarArchivo(IFormFile pFile)
        {
            if (pFile != null)
            {
                //var rutaArchivo = 
                //using (var fileStream = new FileStream())
                //{

                //}

            }
           
        }
    }
}
