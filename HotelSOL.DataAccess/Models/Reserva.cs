namespace HotelSOL.DataAccess.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string TipoAlojamiento { get; set; } = "Normal";
        public string Temporada { get; set; } = "Baja";

        // Relación con Cliente
        public Cliente Cliente { get; set; }  // Permitir valores nulos

        // Relación con ReservaHabitaciones
        public ICollection<ReservaHabitaciones>? ReservaHabitaciones { get; set; }

        // Relación con Factura
        public Factura? Factura { get; set; }  // Permitir valores nulos para evitar recursión infinita

    }
}
