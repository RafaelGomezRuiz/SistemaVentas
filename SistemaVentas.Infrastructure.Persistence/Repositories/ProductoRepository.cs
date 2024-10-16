using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class ProductoRepository : GenericRepository<ProductoEntity>, IProductoRepository
    {
        public ProductoRepository(ApplicationContext dbContext) : base(dbContext) { }

    }
}
