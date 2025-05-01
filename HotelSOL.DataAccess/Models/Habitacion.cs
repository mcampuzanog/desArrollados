namespace HotelSOL.DataAccess.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = "Pendiente";
        public int Capacidad { get; set; }
        public decimal Precio_base { get; set; }
        public bool disponibilidad { get; set; } = true;

        // Agregar propiedades faltantes
       

        // Relación con ReservaHabitaciones
        public ICollection<ReservaHabitaciones> ReservaHabitaciones { get; set; } = new List<ReservaHabitaciones>();

    }
}