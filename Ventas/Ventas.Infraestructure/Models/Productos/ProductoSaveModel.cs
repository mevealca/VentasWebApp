﻿using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Productos
{
    public class ProductoSaveModel : BaseModelSave
    {
        public string? CodigoBarra { get; set; }
        public string? Marca {  get; set; }
        public int IdCategoria { get; set; }
        public int Stock { get; set; }
        public string? UrlImagen { get; set; }
        public string? NombreImagen { get; }
        public decimal Precio { get; set; }

    }
}
