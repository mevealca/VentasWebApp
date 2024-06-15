using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static class UsuarioExtentions
    {
        public static UsuarioModel ConvertUsuarioEntityToUsuarioModel(this Usuario usuario) {

            return new UsuarioModel() {
                Id = usuario.Id,
                Correo = usuario.Correo,
                IdRol = usuario?.IdRol,
                Nombre = usuario?.Nombre,
                Rol = usuario?.Rol.Descripcion,
                Telefono = usuario?.Telefono
            };
        }
    }
}
