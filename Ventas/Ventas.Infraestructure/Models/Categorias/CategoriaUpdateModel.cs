

namespace Ventas.Infraestructure.Models.Categorias
{
    public class CategoriaUpdateModel
    {
        public CategoriaUpdateModel() {
            this.FechaMod = new DateTime();
        }   
        public int Id { get; set; }
        public string? Descripcion { get;set; }
        public bool EsActivo { get; set; }
        public DateTime? FechaMod { get; set; }
        public int IdUsuarioMod { get; set; }
    }
}
