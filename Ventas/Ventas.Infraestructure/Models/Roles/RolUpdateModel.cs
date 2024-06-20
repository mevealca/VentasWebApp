using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Roles
{
    public class RolUpdateModel: BaseModelUpdate
    {
        public string? Descripcion { get; set; }
        public bool EsActivo { get; set; }
    }
}
