using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Core.Application.ViewModels.Products
{
    public class SaveProductoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del producto")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe colocar la descripcion")]
        [DataType(DataType.Text)]
        public string Descripcion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe colocar el precio del producto")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }
        public int Status { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe colocar la marca del producto")]

        public int MarcaId { get; set; }
        public List<int> Categorias { get; set; }
        public List<IFormFile> Images { get; set; }
        public List<string> ImagenesRuta { get; set; }

    }
}
