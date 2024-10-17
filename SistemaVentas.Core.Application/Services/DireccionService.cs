using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Direcciones;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Services
{
    public class DireccionService : GenericService<SaveDireccionViewModel, DireccionViewModel, DireccionEntity>, IDireccionService
    {
        public DireccionService(IDirecionRepository direccionRepository, IMapper mapper) : base(direccionRepository, mapper)
        {

        }
    }
}
