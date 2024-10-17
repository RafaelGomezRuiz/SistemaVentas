using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Core.Application.ViewModels.Direcciones
{
    public class SaveDireccionViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre de la calle")]

        public string Calle { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del sector")]
        public string Sector { get; set; }
        [Required(ErrorMessage = "Debe colocar el numero de contacto")]
        public string NumeroCelular { get; set; }
        public string? NumeroCasa { get; set; }
        public string UserId { get; set; }

    }
}
