using SistemaVentas.Core.Domain.Common;

namespace SistemaVentas.Core.Domain.Entities
{
    public class ProductoEntity : AuditableBaseEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioOferta { get; set; }
        public int Status { get; set; }

        public int MarcaId { get; set; }
        public MarcaEntity Marca { get; set; }
        public ICollection<CategoriaEntity> Categorias { get; set; }
        public ICollection<ImagenProductoEntity> Imagenes { get; set; }
        public InventarioEntity Inventario { get; set; }



    }
}
