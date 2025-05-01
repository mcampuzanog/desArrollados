using Microsoft.EntityFrameworkCore;

namespace HotelSOL.DataAccess
{
    public class HotelSolContext : DbContext
    {
        // DbSet para cada tabla en la base de datos
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<ReservaHabitaciones> ReservaHabitaciones { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }

        // Constructor que recibe una cadena de conexión
        public HotelSolContext(string connectionString) : base(new DbContextOptionsBuilder<HotelSolContext>()
            .UseSqlServer(connectionString)
            .Options)
        {
        }

        // Configuración adicional (opcional) para relaciones entre tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservaHabitaciones>()
                .HasOne(rh => rh.Reserva)
                .WithMany(r => r.ReservaHabitaciones)
                .HasForeignKey(rh => rh.ReservaId);

            modelBuilder.Entity<ReservaHabitaciones>()
                .HasOne(rh => rh.Habitacion)
                .WithMany(h => h.ReservaHabitaciones)
                .HasForeignKey(rh => rh.HabitacionId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
