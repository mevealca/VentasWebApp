using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Roles
{
    public class RolRemoveModel : BaseModelRemove
    {
        public bool EsActivo { get; set; }
    }
}
