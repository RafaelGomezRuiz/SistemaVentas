using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class InventarioRepository : GenericRepository<InventarioEntity>, IInventarioRepository
    {
        public InventarioRepository(ApplicationContext dbContext) : base(dbContext){}
    }
}
