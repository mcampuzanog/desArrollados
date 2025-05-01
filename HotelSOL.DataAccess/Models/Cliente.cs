namespace HotelSOL.DataAccess.Models
{
    public class Cliente

    {
        public int ClienteId { get; set; }
        public string DNI { get; set; } = "Pendiente";
        public string Nombre { get; set; } = "Pendiente";
        public string Apellido { get; set; } = "Pendiente";
        public string Direccion { get; set; } = "Pendiente";
        public string Email { get; set; } = "Pendiente";
        public string Telefono { get; set; } = "Pendiente";
        public bool VIP { get; set; }

        // Relación con Reservas
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    }
}