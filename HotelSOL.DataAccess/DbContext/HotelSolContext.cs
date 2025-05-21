using Microsoft.EntityFrameworkCore;
using HotelSOL.DataAccess.Models;



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
        public DbSet<TipoHabitacion> TiposHabitaciones { get; set; }
        public DbSet<Pago> Pagos { get; set; }


        // Constructor que recibe una cadena de conexión
        public HotelSolContext(DbContextOptions<HotelSolContext> options) : base(options)
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


            modelBuilder.Entity<Reserva>()
                .HasMany(r => r.ReservaHabitaciones)
                .WithOne(rh => rh.Reserva)
                .HasForeignKey(rh => rh.ReservaId)
                .OnDelete(DeleteBehavior.Cascade); // Considera el comportamiento de borrad
            
            modelBuilder.Entity<Cliente>()
        .       HasKey(c => c.ClienteId); // 🔹 Define la clave primaria correctamente

            modelBuilder.Entity<Cliente>()
                 .HasOne(c => c.Usuario)
                 .WithOne(u => u.Cliente)
                 .HasForeignKey<Cliente>(c => c.UsuarioId);// 🔹 Define `UsuarioId` como clave foránea en `Cliente`

            modelBuilder.Entity<Habitacion>()
                .HasOne(h => h.TipoHabitacion)
                .WithMany(t => t.Habitaciones)
                .HasForeignKey(h => h.TipoId);

            modelBuilder.Entity<Reserva>()
                .Property(r => r.Estado)
                .HasConversion<int>();


            base.OnModelCreating(modelBuilder);
        }
    }
}
