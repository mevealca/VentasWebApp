
namespace Ventas.Domain.Entities
{
    public sealed class NumeroCorrelativo
    {
        public int Id { get; set; }
        public int UltimoNumero { get; set; }
        public int CantidadDigitos { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
