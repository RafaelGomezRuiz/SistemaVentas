using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.ViewModels.Marca;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface IMarcaService : IGenericService<SaveMarcaViewModel, MarcaViewModel, MarcaEntity>
    {
    }
}
