namespace HotelSOL.DataAccess.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int TipoId { get; set; }
        public string Numero { get; set; }
        public int Capacidad { get; set; }
        public bool Disponible { get; set; } = true; // Indica si está libre o no

        public ICollection<ReservaHabitaciones> ReservaHabitaciones { get; set; } = new List<ReservaHabitaciones>();
        public TipoHabitacion TipoHabitacion { get; set; }
    }

}