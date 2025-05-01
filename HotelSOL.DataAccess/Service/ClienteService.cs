using HotelSOL.DataAccess.Models;

namespace HotelSOL.DataAccess.Services
{
    public class ClienteService
    {
        private readonly HotelSolContext _context;

        // Constructor que recibe el contexto
        public ClienteService(HotelSolContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Agregar cliente
        public void AgregarCliente(Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException(nameof(cliente));

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // Listar clientes (devuelve una lista en lugar de imprimir en consola)
        public List<Cliente> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        // Actualizar cliente con validación de datos
        public bool ActualizarCliente(int ClienteId, string nuevoEmail)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteId == ClienteId);
            if (cliente == null) return false;

            if (!string.IsNullOrWhiteSpace(nuevoEmail))
            {
                cliente.Email = nuevoEmail;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        // Eliminar cliente con verificación de existencia
        public bool EliminarCliente(int ClienteId)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteId == ClienteId);
            if (cliente == null) return false;

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return true;
        }

        // Obtener lista de clientes VIP
        public List<Cliente> ObtenerClientesVIP()
        {
            return _context.Clientes.Where(c => c.VIP).ToList();
        }

        // Obtener clientes con reservas activas (manejo de `NULL`)
        public List<Cliente> ObtenerClientesConReservas()
        {
            return _context.Reservas
                .Where(r => r.FechaFin >= DateTime.Today)
                .Select(r => r.Cliente)
                .Where(c => c != null) // Evita errores si `Cliente` es `NULL`
                .Distinct()
                .ToList();
        }
    }
}
