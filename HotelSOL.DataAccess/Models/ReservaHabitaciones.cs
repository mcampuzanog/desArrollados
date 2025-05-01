namespace HotelSOL.DataAccess.Models
{
    public class ReservaHabitaciones
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int HabitacionId { get; set; }

        // Relación con Reserva y Habitacion
        public Reserva Reserva { get; set; } // No inicializar aquí
        public Habitacion Habitacion { get; set; } // No inicializar aquí
    }
}