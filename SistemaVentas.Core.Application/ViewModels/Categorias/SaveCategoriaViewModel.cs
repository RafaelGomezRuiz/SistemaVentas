using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Core.Application.ViewModels.Categories;

public class SaveCategoriaViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Debe colocar el nombre de la categoria")]
    public string Nombre { get; set; }
}
