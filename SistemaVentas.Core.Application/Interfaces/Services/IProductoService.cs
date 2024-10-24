using SistemaVentas.Core.Application.ViewModels.Products;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IProductoService : IGenericService<SaveProductoViewModel, ProductoViewModel, ProductoEntity>
    {
    }
}
