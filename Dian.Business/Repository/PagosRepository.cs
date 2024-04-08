using AutoMapper;
using Dian01.Data;
using Dian02.Entities.Entities;
using Dian03.Business.DTO;
using Dian03.Business.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Dian03.Business.Repository
{
    public class PagosRepository:IPagosRepository<PagoDTO>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public PagosRepository(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;

        }

        /// <summary>
        /// Obtener los pagos por año
        /// </summary>
        /// <param name="pAnioPagos"></param>
        /// <returns></returns>
        public async Task<IEnumerable<PagoDTO>> ObtenerTodosPagos(int pAnioPagos)
        {
            var usuaDTO = new List<PagoDTO>();
            try
            {
                var facturas = await _context.Facturas.Where(x=>x.Fecha.Year == pAnioPagos)
                                                        .Join(_context.Proveedores,
                                                            fact => fact.IdProveedor,
                                                            prov => prov.IdProveedor,
                                                            (fact,prov) => new PagoDTO()
                                                            {
                                                                IdProveedor = fact.IdProveedor,
                                                                NombreProveedor = prov.NombreProveedor,
                                                                TipoIdentificacion = prov.TipoIdentificacion,
                                                                NumeroIdentificacion = prov.NumeroIdentificacion,
                                                                FechaFactura = fact.Fecha,
                                                            }).ToListAsync();
                usuaDTO = facturas;

                return usuaDTO;
            }
            catch (Exception ex)
            {

                throw;
            }

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
