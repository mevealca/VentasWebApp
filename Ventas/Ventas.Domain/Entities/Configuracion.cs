﻿
namespace Ventas.Domain.Entities
{
    public sealed class Configuracion
    {
        public int Id { get; set; }
        public string Recurso { get; set; }
        public string Propiedad { get; set; }
        public string Valor { get; set; }

    }
}
