using SistemaVentas.Core.Application.ViewModels.Products;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Core.Application.ViewModels.ImagenProducto
{
    public class ImagenProductoViewModel
    {
        public int Id { get; set; }
        public string RutaImagen { get; set; }
        public int ProductoId { get; set; }
        public ProductoViewModel Producto { get; set; }
    }
}
