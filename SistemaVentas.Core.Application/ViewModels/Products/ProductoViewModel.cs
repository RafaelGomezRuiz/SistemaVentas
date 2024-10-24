using SistemaVentas.Core.Application.Enums;
using SistemaVentas.Core.Application.ViewModels.Categories;
using SistemaVentas.Core.Application.ViewModels.ImagenProducto;
using SistemaVentas.Core.Application.ViewModels.Inventario;
using SistemaVentas.Core.Application.ViewModels.Marca;

namespace SistemaVentas.Core.Application.ViewModels.Products
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioOferta { get; set; }

        public EnumEstadoProducto Status { get; set; }

        public int MarcaId { get; set; }
        public MarcaViewModel Marca { get; set; }
        public ICollection<CategoriaViewModel> Categorias { get; set; }
        public ICollection<ImagenProductoViewModel> Imagenes { get; set; }
        public InventarioViewModel Inventario { get; set; }
    }
}
