using System;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelSOL.DataAccess.Services
{
    public class FacturaService
    {
        private readonly HotelSolContext _context;

        public FacturaService(HotelSolContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // 🔹 Generar una factura basada en la reserva y servicios consumidos
        public Factura GenerarFactura(int reservaId, decimal impuestoPorcentaje)
        {
            var reserva = _context.Reservas.Include(r => r.Cliente).FirstOrDefault(r => r.Id == reservaId);
            if (reserva == null)
                throw new ArgumentException("La reserva no existe.");

            var serviciosConsumidos = _context.Servicios.Where(s => s.ReservaId == reservaId).ToList();
            decimal montoServicios = serviciosConsumidos.Sum(s => s.Precio);
            decimal montoBase = CalcularMontoBase(reserva);
            decimal montoImpuestos = CalcularImpuesto(montoBase + montoServicios, impuestoPorcentaje);
            decimal montoTotal = montoBase + montoServicios + montoImpuestos;

            var factura = new Factura
            {
                ReservaId = reservaId,
                ClienteId = reserva.ClienteId,
                MontoTotal = montoTotal,
                MontoImpuestos = montoImpuestos,
                FechaEmision = DateTime.Now,
                Pagada = false
            };

            _context.Facturas.Add(factura);
            _context.SaveChanges();

            foreach (var servicio in serviciosConsumidos)
            {
                servicio.FacturaId = factura.Id;
                _context.Servicios.Update(servicio);
            }
            _context.SaveChanges();

            return factura;
        }

        // 🔹 Calcular el costo base de la reserva
        private decimal CalcularMontoBase(Reserva reserva)
        {
            int diasReservados = (reserva.FechaFin - reserva.FechaInicio).Days;
            decimal tarifaDiaria = _context.ReservaHabitaciones
                .Where(rh => rh.ReservaId == reserva.Id)
                .Select(rh => rh.Habitacion.TipoHabitacion.PrecioBase)
                .DefaultIfEmpty(0)
                .FirstOrDefault();

            // Verificar si la reserva aplica para un descuento VIP
            if (reserva.Cliente.VIP)
            {
                tarifaDiaria *= 0.9m; // Aplicando 10% de descuento para clientes VIP
            }

            // Validaciones para fechas especiales (Ejemplo: precios elevados en temporada alta)
            if (EsTemporadaAlta(reserva.FechaInicio, reserva.FechaFin))
            {
                tarifaDiaria *= 1.2m; // Aumento del 20% en temporada alta
            }

            return diasReservados * tarifaDiaria;
        }

        // Función auxiliar para verificar si las fechas están en temporada alta
        private bool EsTemporadaAlta(DateTime inicio, DateTime fin)
        {
            var temporadaAlta = new List<(int mesInicio, int mesFin)>
    {
        (6, 8),  // Verano: Junio - Agosto
        (12, 1)  // Navidad: Diciembre - Enero
    };

            return temporadaAlta.Any(t => inicio.Month >= t.mesInicio && fin.Month <= t.mesFin);
        }


        // 🔹 Calcular impuestos
        private const decimal IMPUESTO_POR_DEFECTO = 10m; // 10% de impuesto

        public decimal CalcularImpuesto(decimal monto, decimal? porcentaje = null)
        {
            decimal impuestoAplicado = porcentaje ?? IMPUESTO_POR_DEFECTO;
            return monto * (impuestoAplicado / 100);
        }


        // 🔹 Verificar si una factura está pagada
        public bool FacturaPagada(int facturaId)
        {
            var factura = _context.Facturas.FirstOrDefault(f => f.Id == facturaId);
            return factura?.Pagada ?? false;
        }

        // 🔹 Obtener todas las facturas de un cliente
        public List<Factura> ObtenerFacturasPorCliente(int clienteId)
        {
            return _context.Facturas.Include(f => f.Reserva).Where(f => f.ClienteId == clienteId).ToList();
        }
    }
}

