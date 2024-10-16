using SistemaVentas.Core.Domain.Common;

namespace SistemaVentas.Core.Domain.Entities
{
    public class CategoriaEntity : AuditableBaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<ProductoEntity> Productos { get; set;}
    }
}
