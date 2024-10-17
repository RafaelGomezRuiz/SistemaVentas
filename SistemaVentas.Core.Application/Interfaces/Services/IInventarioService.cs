using SistemaVentas.Core.Application.ViewModels.Inventario;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IInventarioService : IGenericService<SaveInventarioViewModel, InventarioViewModel, InventarioEntity>
    {
    }
}
