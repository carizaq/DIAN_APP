using AutoMapper;
using Dian01.Data;
using Dian03.Business.DTO;
using Dian03.Business.IRepository;

namespace Dian03.Business.Repository
{
    public class PagosRepository:IPagosRepository<PagoDTO>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        PagosRepository(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;

        }

        public async Task<IEnumerable<PagoDTO>> ObtenerTodosPagos()
        {
            throw new NotImplementedException();
        }


        public async Task<PagoDTO> AlmacenarPagos()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task AlmacenarCambios()
        {
            await _context.SaveChangesAsync();
        }
    }
}
