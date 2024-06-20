

using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Categorias
{
    public class CategoriaUpdateModel : BaseModelUpdate
    {
        public string? Descripcion { get;set; }
        public bool EsActivo { get; set; }
    }
}
