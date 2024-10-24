using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<CategoriaEntity>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext dbContext) : base(dbContext) { }
    }
}
