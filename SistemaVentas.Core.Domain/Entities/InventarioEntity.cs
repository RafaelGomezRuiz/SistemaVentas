using SistemaVentas.Core.Domain.Common;

namespace SistemaVentas.Core.Domain.Entities
{
    public class InventarioEntity : AuditableBaseEntity
    {
        public int Id { get; set; }
        public int CantidadDisponible { get; set; }
        public string Zize { get; set; }
        public string Color { get; set; }

        public int ProductoId { get; set; }
        public ICollection<ProductoEntity> Productos { get; set;}
        public CarritoCompraEntity Carrito{ get; set; }
    }
}
