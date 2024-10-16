using SistemaVentas.Core.Application.ViewModels.Products;

namespace SistemaVentas.Core.Application.ViewModels.Marca
{
    public class MarcaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<ProductoViewModel> Productos { get; set; }
    }
}
