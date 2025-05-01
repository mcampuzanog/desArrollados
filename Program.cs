using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

public class HotelSolContext : DbContext
{
    private readonly IConfiguration _configuration;

    public HotelSolContext()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        _configuration = builder.Build();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Usar la cadena de conexión del archivo appsettings.json
        var connectionString = _configuration.GetConnectionString("HotelSOLDB");
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Habitacion> Habitaciones { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<ReservaHabitaciones> ReservaHabitaciones { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Incidencia> Incidencias { get; set; }
}
