using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Categories;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Services
{
    public class CategoriaService : GenericService<SaveCategoriaViewModel, CategoriaViewModel, CategoriaEntity>, ICategoryService
    {
        public CategoriaService(ICategoryRepository _categoryRepository, IMapper _mapper) : base(_categoryRepository, _mapper)
        {

        }
    }
}
