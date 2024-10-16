namespace SistemaVentas.Core.Application.ViewModels.Direcciones
{
    public class DireccionViewModel
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Sector { get; set; }
        public string NumeroCelular { get; set; }
        public string? NumeroCasa { get; set; }
    }
}
