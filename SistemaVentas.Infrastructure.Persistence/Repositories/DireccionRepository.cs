using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class DireccionRepository : GenericRepository<DireccionEntity>, IDirecionRepository
    {
        public DireccionRepository(ApplicationContext dbContext) : base(dbContext){}
    }
}
