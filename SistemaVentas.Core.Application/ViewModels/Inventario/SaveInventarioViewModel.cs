using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Core.Application.ViewModels.Inventario
{
    public class SaveInventarioViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar la cantidad disponible")]

        public int CantidadDisponible { get; set; }

        [Required(ErrorMessage = "Debe colocar el size de la categoria")]
        public string Zize { get; set; }

        [Required(ErrorMessage = "Debe colocar el id de la categoria")]

        public string Color { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre de la categoria")]

        public int ProductoId { get; set; }
    }
}
