using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using HotelSOL.DataAccess;

namespace HotelSOL1.FormsAPP
{
    internal static class Program
    {
        public static HotelSolContext DbContext { get; private set; } = null!;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cargar configuración desde appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Asegura que busca en la ubicación correcta
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Obtener la cadena de conexión correcta
            string? connectionString = config.GetConnectionString("HotelDb"); // Permite valores nulos
            if (connectionString == null)
            {
                throw new InvalidOperationException("La cadena de conexión no puede ser nula.");
            }


            // Configurar DbContext correctamente
            var options = new DbContextOptionsBuilder<HotelSolContext>()
             .UseSqlServer(connectionString, options => options.EnableRetryOnFailure())
             .Options;

            DbContext = new HotelSolContext(options);

            // Iniciar la aplicación Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipalForm()); // Asegúrate de que este es el formulario principal
        }
    }
}
