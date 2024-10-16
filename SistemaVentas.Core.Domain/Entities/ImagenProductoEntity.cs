using SistemaVentas.Core.Domain.Common;

namespace SistemaVentas.Core.Domain.Entities
{
    public class ImagenProductoEntity : AuditableBaseEntity
    {
        public int Id { get; set; }
        public string RutaImagen { get; set; }
        public int ProductoId { get; set; }
        public ProductoEntity Producto { get; set; }

    }
}
