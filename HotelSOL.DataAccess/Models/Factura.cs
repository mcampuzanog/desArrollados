namespace HotelSOL.DataAccess.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaEmision { get; set; }

        // Relación con Reserva
        public Reserva Reserva { get; set; } = new Reserva(); 
    }
}