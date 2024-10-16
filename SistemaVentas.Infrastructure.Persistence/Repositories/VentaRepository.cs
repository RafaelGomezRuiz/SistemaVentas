using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class VentaRepository : GenericRepository<VentaEntity>, IVentaRepository
    {
        public VentaRepository(ApplicationContext dbContext ) : base(dbContext)
        {
            
        }
    }
}
