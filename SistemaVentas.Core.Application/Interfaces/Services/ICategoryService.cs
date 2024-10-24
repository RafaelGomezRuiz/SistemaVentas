using SistemaVentas.Core.Application.ViewModels.Categories;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface ICategoryService : IGenericService<SaveCategoriaViewModel, CategoriaViewModel, CategoriaEntity>
    {
    }
}
