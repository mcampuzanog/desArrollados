using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSOL.DataAccess.Models
{
    public class Servicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Descripcion { get; set; } = "Pendiente";

        [Range(0.01, double.MaxValue)]
        public decimal Precio { get; set; }

        [Required]
        public TipoServicio Tipo { get; set; } // 🔹 Nuevo campo para definir el tipo de servicio

        [ForeignKey("ReservaId")]
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }

        [ForeignKey("FacturaId")]
        public int? FacturaId { get; set; }
        public Factura? Factura { get; set; }

        public bool DescuentoAplicado { get; set; } = false; // 🔹 Nuevo campo para descuentos
    }

    // Enum para definir tipos de servicio
    public enum TipoServicio
    {
        Bebida,
        Spa,
        Transporte,
        Restaurante,
        Lavanderia,
        Otro
    }
}
