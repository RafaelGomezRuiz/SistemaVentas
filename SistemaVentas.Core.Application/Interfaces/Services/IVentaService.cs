using SistemaVentas.Core.Application.ViewModels.Ventas;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IVentaService : IGenericService<SaveVentaViewModel, VentaViewModel, VentaEntity>
    {
    }
}
