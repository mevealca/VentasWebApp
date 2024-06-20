

namespace Ventas.Infraestructure.Core
{
    public abstract class BaseModelSave : AuditableSaveBaseModel
    {
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }

    }
}
