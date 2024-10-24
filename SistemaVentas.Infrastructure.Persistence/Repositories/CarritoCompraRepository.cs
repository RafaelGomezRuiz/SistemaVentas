using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Domain.Entities;
using SistemaVentas.Infrastructure.Persistence.Contexts;

namespace SistemaVentas.Infrastructure.Persistence.Repositories
{
    public class CarritoCompraRepository : GenericRepository<CarritoCompraEntity>, ICarritoCompraRepository
    {
        public CarritoCompraRepository(ApplicationContext dbContext) : base(dbContext) { }
    }
}
