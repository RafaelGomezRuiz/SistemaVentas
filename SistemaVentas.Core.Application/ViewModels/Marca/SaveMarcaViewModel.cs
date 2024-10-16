using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Core.Application.ViewModels.Marca
{
    public class SaveMarcaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre de la marca")]
        public string Nombre { get; set; }
    }
}
