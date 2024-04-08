namespace Dian03.Business.IRepository
{
    public interface IPagosRepository<T> where T:class
    {
        /// <summary>
        /// Obtener los pagos por año
        /// </summary>
        /// <param name="pAnioPagos"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> ObtenerTodosPagos(int pAnioPagos);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<T> AlmacenarPagos();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task AlmacenarCambios();
    }
}
