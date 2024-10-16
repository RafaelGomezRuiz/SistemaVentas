using SistemaVentas.Core.Application.ViewModels.CarritoCompras;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.ViewModels.Ventas
{
    public class VentaViewModel
    {
        public int Id { get; set; }
        public int Estado { get; set; }
        public double MontoPagado { get; set; }

        public int CarritoId { get; set; }
        public CarritoCompraViewModel Carrito { get; set; }
    }
}
