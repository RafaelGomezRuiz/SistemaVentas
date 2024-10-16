using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Core.Application.ViewModels.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Debe colocar su email")]
        [DataType(DataType.Text)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Debe colocar una contrasenia")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool HasError { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
