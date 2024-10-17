using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Ventas;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Services
{
    public class VentaService : GenericService<SaveVentaViewModel, VentaViewModel, VentaEntity>, IVentaService
    {
        public VentaService(IVentaRepository ventaRepository, IMapper mapper) : base(ventaRepository, mapper)
        {
            
        }
    }
}
