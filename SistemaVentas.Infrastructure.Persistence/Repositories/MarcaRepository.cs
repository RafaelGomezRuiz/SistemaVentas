using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class MarcaRepository : GenericRepository<MarcaEntity>, IMarcaRepository
    {
        public MarcaRepository(ApplicationContext dbContext) : base(dbContext){}
    }
}
