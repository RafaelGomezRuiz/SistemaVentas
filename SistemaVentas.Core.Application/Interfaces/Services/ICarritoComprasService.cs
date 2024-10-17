using SistemaVentas.Core.Application.ViewModels.CarritoCompras;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface ICarritoComprasService : IGenericService<SaveCarritoCompraViewModel, CarritoCompraViewModel, CarritoCompraEntity>
    {
    }
}
