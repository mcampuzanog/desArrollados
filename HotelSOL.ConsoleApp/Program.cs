using System;
using HotelSOL.DataAccess;
using HotelSOL.DataAccess.Services;
using Microsoft.Extensions.Configuration;
using System.IO;

class Program
{
    static void Main()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString = configuration.GetConnectionString("HotelSOLDB");
        using (var context = new HotelSolContext(connectionString))
        {
            var clienteService = new ClienteService(context);
            var habitacionService = new HabitacionService(context);

            // Insertar un cliente
            clienteService.AgregarCliente(new Cliente
            {
                DNI = "456236543A",
                Nombre = "Juan",
                Apellido = "González",
                Direccion = "Calle Vieja 2",
                Email = "Juan.gonzalez@mail.com",
                Telefono = "9954654321",
                VIP = false
            });
             
            // Listar clientes
            clienteService.ListarClientes();

            // Listar habitaciones disponibles
            var habitacionesDisponibles = habitacionService.ObtenerHabitacionesDisponibles(fechaInicio, fechaFin, tipo);

        }
    }
}
