namespace SistemaVentas.Core.Domain.Entities
{
    public class DireccionEntity
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Sector { get; set; }
        public string NumeroCelular { get; set; }
        public string? NumeroCasa { get; set; }
        public string UserId { get; set; }
    }
}
