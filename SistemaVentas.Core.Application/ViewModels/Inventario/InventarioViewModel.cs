using SistemaVentas.Core.Application.ViewModels.CarritoCompras;
using SistemaVentas.Core.Application.ViewModels.Products;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.ViewModels.Inventario
{
    public class InventarioViewModel
    {
        public int Id { get; set; }
        public int CantidadDisponible { get; set; }
        public string Zize { get; set; }
        public string Color { get; set; }

        public int ProductoId { get; set; }
        public ICollection<ProductoViewModel> Productos { get; set; }
        public CarritoCompraViewModel Carrito { get; set; }

    }
}
