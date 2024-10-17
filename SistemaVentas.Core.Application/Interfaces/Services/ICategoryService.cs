using SistemaVentas.Core.Domain.Entities;
using StockApp.Core.Application.ViewModels.Categories;

namespace SistemaVentas.Core.Application.Interfaces.Services
{
    public interface ICategoryService : IGenericService<SaveCategoriaViewModel, CategoriaViewModel, CategoriaEntity>
    {
    }
}
