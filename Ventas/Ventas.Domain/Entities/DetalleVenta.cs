﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace Ventas.Domain.Entities
{
    [Table("DetalleVenta")]
    public sealed class DetalleVenta
    {
        public int Id { get; set; }
        public int?   IdVenta { get; set; }
        public int? IdProducto { get; set;}
        public string? MarcaProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public string? CategoriaProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Total { get; set; }

    }
}
