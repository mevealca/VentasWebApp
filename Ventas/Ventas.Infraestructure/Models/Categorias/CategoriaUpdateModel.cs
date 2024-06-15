

namespace Ventas.Infraestructure.Models.Categorias
{
    public class CategoriaUpdateModel
    {
        public int Id { get; set; }
        public string? Descripcion { get;set; }
        public bool EsActivo { get; set; }
        public DateTime? FechaMod { get; set; }
    }
}
