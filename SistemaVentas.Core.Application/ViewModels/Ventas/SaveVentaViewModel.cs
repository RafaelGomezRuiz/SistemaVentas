using SistemaVentas.Core.Application.Enums;
using SistemaVentas.Core.Application.ViewModels.CarritoCompras;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.ViewModels.Ventas
{
    public class SaveVentaViewModel
    {
        public int Id { get; set; }
        public EnumEstadoVenta Estado { get; set; }
        public double MontoPagado { get; set; }

        public int CarritoId { get; set; }
    }
}
