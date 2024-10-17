using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Inventario;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Services
{
    public class InventarioService : GenericService<SaveInventarioViewModel, InventarioViewModel, InventarioEntity>, IInventarioService
    {
        public InventarioService(IInventarioRepository inventarioRepository, IMapper mapper) : 
            base(inventarioRepository,mapper)
        {
            
        }
    }
}
