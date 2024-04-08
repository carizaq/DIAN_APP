namespace Dian03.Business.IRepository
{
    public interface IArchivoRepository
    {
        Task<bool> CargarRegistrosArchivo(IFormFile pFile);
    }
}
