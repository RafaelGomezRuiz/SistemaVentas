namespace SistemaVentas.Core.Domain.Entities
{
    public class CarritoCompraEntity
    {
        public int Id { get; set; }
        public int CantidadRequerida { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public int MetodoEntrega { get; set; }
        public int? DireccionId { get; set; }
        public string? Ubicacion { get; set; }
        public string? TelefonoContacto { get; set; }
        public DateTime? HorarioDisponible { get; set; }

        public int InventarioId { get; set; }
        public ICollection<InventarioEntity> InventarioProductos { get; set; }
        public VentaEntity Venta { get; set; }
    }
}
