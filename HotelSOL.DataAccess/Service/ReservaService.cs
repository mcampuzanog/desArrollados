using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DataAccess.Models;

namespace HotelSOL.DataAccess.Services
{
    public class ReservaService
    {
        private readonly HotelSolContext _context;

        // Constructor que recibe el contexto
        public ReservaService(HotelSolContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Obtener todas las reservas
        public List<Reserva> ObtenerReservas()
        {
            return _context.Reservas.ToList();
        }

        // Obtener reservas activas
        public List<Reserva> ObtenerReservasActivas()
        {
            return _context.Reservas.Where(r => r.FechaFin >= DateTime.Today).ToList();
        }

        // Registrar una nueva reserva
        public void RegistrarReserva(Reserva nuevaReserva, List<int> habitacionesIds)
        {
            if (nuevaReserva == null || habitacionesIds == null || !habitacionesIds.Any())
                throw new ArgumentNullException(nameof(nuevaReserva), "Reserva o habitaciones no pueden estar vacías.");

            _context.Reservas.Add(nuevaReserva);
            _context.SaveChanges();

            // Relacionar habitaciones con la reserva
            foreach (var habitacionId in habitacionesIds)
            {
                var reservaHabitacion = new ReservaHabitaciones
                {
                    ReservaId = nuevaReserva.Id,
                    HabitacionId = habitacionId
                };
                _context.ReservaHabitaciones.Add(reservaHabitacion);
            }

            _context.SaveChanges();
        }

        // Cancelar reserva por ID
        public bool CancelarReserva(int reservaId)
        {
            var reserva = _context.Reservas.FirstOrDefault(r => r.Id == reservaId);
            if (reserva == null) return false;

            _context.Reservas.Remove(reserva);
            _context.SaveChanges();
            return true;
        }
    }
}
