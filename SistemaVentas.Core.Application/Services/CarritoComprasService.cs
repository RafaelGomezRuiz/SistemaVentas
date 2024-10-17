using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.CarritoCompras;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Services
{
    public class CarritoComprasService : GenericService<SaveCarritoCompraViewModel, CarritoCompraViewModel, CarritoCompraEntity>, ICarritoComprasService
    {
        public CarritoComprasService(ICarritoCompraRepository carritoCompraRepository, IMapper mapper) : base(carritoCompraRepository, mapper)
        {

        }
    }
}
