﻿
namespace Ventas.Domain.Core
{
    public abstract class BaseModels
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
    }
}
