
using Ventas.Domain.Core;
using Ventas.Domain.Entities;

namespace Ventas.Domain.Models
{
   public class ProductoModel :BaseModels
    {
        public string? CodigoBarra { get; set; }
        public string? Marca { get; set; }
        public int? IdCategoria { get; set;}
        public string? Categoria { get; set; }
        public int Stock { get; set; }
        public string? UrlImagen { get; set; }
        public string? NombreImagen { get; set; }
    
    }
}
