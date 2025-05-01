using HotelSOL.DataAccess.Models;
using System.Linq;
using System.Collections.Generic;


namespace HotelSOL.DataAccess.Services
{
    public class HabitacionService
    {
        private readonly HotelSolContext _context;

        public HabitacionService(HotelSolContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Devuelve una lista de habitaciones disponibles en lugar de imprimir en consola
        public List<Habitacion> ObtenerHabitacionesDisponibles()
        {
            return _context.Habitaciones
                .Where(h => h.disponibilidad) // Solo habitaciones disponibles
                .ToList();
        }


    }
}
