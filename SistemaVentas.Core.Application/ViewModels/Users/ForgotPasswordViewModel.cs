using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Core.Application.ViewModels.Users
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Debe colocar su email")]
        [DataType(DataType.Text)]
        public string? Email { get; set; }
        public bool HasError { get; set; }
        public string? ErrorDescription { get; set; }
    }
}
