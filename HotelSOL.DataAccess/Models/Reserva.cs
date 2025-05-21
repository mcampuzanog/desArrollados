namespace HotelSOL.DataAccess.Models
{
    public enum EstadoReserva
    {
        Pendiente,
        Confirmada,
        CheckIn,
        CheckOut,
        Cancelada
    }

    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstadoReserva Estado { get; set; } = EstadoReserva.Pendiente;

        public Cliente? Cliente { get; set; }
        public ICollection<ReservaHabitaciones>? ReservaHabitaciones { get; set; }
        public Factura? Factura { get; set; }
    }

}
