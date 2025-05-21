namespace HotelSOL.DataAccess.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; } // 🔒 Considera encriptarla
        public string Rol { get; set; }
        public Cliente Cliente { get; set; } // 🔹 Propiedad de navegación
    }

}