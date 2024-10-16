using SistemaVentas.Core.Domain.Common;

namespace SistemaVentas.Core.Domain.Entities
{
    public class VentaEntity : AuditableBaseEntity
    {
        public int Id { get; set; }
        public int Estado { get; set; }
        public double MontoPagado { get; set; }

        public int CarritoId { get; set; }
        public CarritoCompraEntity Carrito { get; set;}
    }
}
