using SistemaVentas.Core.Application.ViewModels.Direcciones;
using SistemaVentas.Core.Application.ViewModels.Inventario;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IDireccionService : IGenericService<SaveDireccionViewModel, DireccionViewModel, DireccionEntity>
    {
    }
}
