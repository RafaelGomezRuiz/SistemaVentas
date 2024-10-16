using SistemaVentas.Core.Application.ViewModels.Inventario;
using SistemaVentas.Core.Application.ViewModels.Ventas;
using SistemaVentas.Core.Domain.Entities;
using StockApp.Core.Application.Enums;

namespace SistemaVentas.Core.Application.ViewModels.CarritoCompras
{
    public class CarritoCompraViewModel
    {
        public int Id { get; set; }
        public int CantidadRequerida { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public EnumMetodoEntrega MetodoEntrega { get; set; }
        public int? DireccionId { get; set; }
        public string? Ubicacion { get; set; }
        public string? TelefonoContacto { get; set; }
        public DateTime? HorarioDisponible { get; set; }

        public int InventarioId { get; set; }
        public ICollection<InventarioViewModel> InventarioProductos { get; set; }
        public VentaViewModel Venta { get; set; }
    }
}
