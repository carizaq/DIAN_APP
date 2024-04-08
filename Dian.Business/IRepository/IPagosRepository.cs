namespace Dian03.Business.IRepository
{
    public interface IPagosRepository<T> where T:class
    {
        Task<IEnumerable<T>> ObtenerTodosPagos();
        Task<T> AlmacenarPagos();
        Task AlmacenarCambios();
    }
}
