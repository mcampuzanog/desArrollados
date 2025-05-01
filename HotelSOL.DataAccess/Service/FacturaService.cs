using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DataAccess.Models;

namespace HotelSOL.DataAccess.Services
{
    public class FacturaService
    {
        private readonly HotelSolContext _context;

        // Constructor que recibe el contexto de la base de datos
        public FacturaService(HotelSolContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Generar una factura basada en una reserva y los servicios consumidos
        public Factura GenerarFactura(int reservaId, List<Servicio>? servicios)
        {
            // Obtener la reserva asociada
            var reserva = _context.Reservas.FirstOrDefault(r => r.Id == reservaId);
            if (reserva == null)
                throw new ArgumentException("La reserva no existe.");

            // Calcular el monto total de la factura
            decimal montoServicios = servicios?.Sum(s => s.Precio) ?? 0;
            decimal montoBase = CalcularMontoBase(reserva);
            decimal montoTotal = montoBase + montoServicios;

            // Crear la factura
            var factura = new Factura
            {
                ReservaId = reservaId,
                MontoTotal = montoTotal,
                FechaEmision = DateTime.Now
            };

            // Guardar la factura en la base de datos
            _context.Facturas.Add(factura);
            _context.SaveChanges();

            return factura;
        }

        // Método para calcular el costo base de la reserva
        private decimal CalcularMontoBase(Reserva reserva)
        {
            int diasReservados = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal tarifaDiaria = _context.Habitaciones.FirstOrDefault(h => h.Id == reserva.Id)?.Precio_base ?? 0;
            return diasReservados * tarifaDiaria;
        }
    }
}
