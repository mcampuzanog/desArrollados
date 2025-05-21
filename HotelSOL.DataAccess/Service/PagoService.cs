using System;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelSOL.DataAccess.Services
{
    public class PagoService
    {
        private readonly HotelSolContext _context;

        public PagoService(HotelSolContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // 🔹 Registrar un pago parcial o completo de una factura
        public void RegistrarPago(int facturaId, decimal monto, string metodoPago)
        {
            var factura = _context.Facturas.Include(f => f.Pagos).FirstOrDefault(f => f.Id == facturaId);
            if (factura == null) throw new ArgumentException("Factura no encontrada.");

            var pago = new Pago
            {
                FacturaId = facturaId,
                Monto = monto,
                MetodoPago = metodoPago,
                FechaPago = DateTime.Now
            };

            factura.Pagos.Add(pago);
            _context.SaveChanges();

            // 🔹 Marcar factura como pagada si el total cubre el monto total
            decimal totalPagado = factura.Pagos.Sum(p => p.Monto);
            if (totalPagado >= factura.MontoTotal)
                factura.Pagada = true;

            _context.SaveChanges();
        }

        // 🔹 Obtener pagos de una factura específica
        public List<Pago> ObtenerPagosPorFactura(int facturaId)
        {
            return _context.Pagos.Where(p => p.FacturaId == facturaId).ToList();
        }
    }
}     