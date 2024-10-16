using System.ComponentModel.DataAnnotations;

namespace StockApp.Core.Application.ViewModels.Categories;

public class SaveCategoriaViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Debe colocar el nombre de la categoria")]
    public string Name { get; set; }
}
