using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Marca;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.Services
{
    public class MarcaService : GenericService<SaveMarcaViewModel, MarcaViewModel, MarcaEntity>, IMarcaService
    {
        public MarcaService(IMarcaRepository _marcaRepository, IMapper _mapper) : base(_marcaRepository, _mapper)
        {

        }
    }
}
