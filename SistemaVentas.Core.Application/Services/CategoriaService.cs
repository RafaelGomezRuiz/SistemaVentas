using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Domain.Entities;
using StockApp.Core.Application.ViewModels.Categories;

namespace SistemaVentas.Core.Application.Services
{
    public class CategoriaService : GenericService<SaveCategoriaViewModel, CategoriaViewModel, CategoriaEntity>, ICategoryService
    {
        public CategoriaService(ICategoryRepository _categoryRepository, IMapper _mapper) : base(_categoryRepository,_mapper)
        {
            
        }
    }
}
