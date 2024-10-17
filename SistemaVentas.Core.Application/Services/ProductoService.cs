using AutoMapper;
using SistemaVentas.Core.Application.Interfaces.Repositories;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Products;
using SistemaVentas.Core.Domain.Entities;
using StockApp.Core.Application.ViewModels.Products;

namespace SistemaVentas.Core.Application.Services
{
    public class ProductoService : GenericService<SaveProductoViewModel, ProductoViewModel, ProductoEntity>, IProductoService
    {
        public ProductoService(IProductoRepository productoRepository, IMapper mapper): base(productoRepository,mapper)
        {
            
        }
    }
}
