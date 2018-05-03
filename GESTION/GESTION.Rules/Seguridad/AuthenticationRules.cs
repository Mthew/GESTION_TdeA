using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

using GESTION.Entity;
using GESTION.Dto;

namespace GESTION.Rules
{
    public class AuthenticationRules
    {
        private Gestion_TdeAEntities Entities = null;

        public AuthenticationRules()
        {
            this.Entities = new Gestion_TdeAEntities();
        }

        public AuthenticationDto Login(string userName, string password)
        {
            var user = Entities.Usuarios.Where(e => e.Nombre == userName && e.Clave == password).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("Usuario o clave no validos");
            }
            AuthenticationDto authentication = new AuthenticationDto();
            var persona = user.Personas;
            var rol = user.RolesUsuario.FirstOrDefault();
            var permisos = rol.Roles.PermisosRol.Select(e => e.Permisos.Nombre).ToList();
            authentication.Id = user.Id;
            authentication.FullName = string.Format("{0} {1} {2} {3}", persona.Nombre, persona.SegundoNombre, persona.Apellido, persona.SegundoApellido);
            authentication.UserName = user.Nombre;
            authentication.RolId = rol.Id;
            authentication.RolName = rol.Roles.Nombre;
            authentication.Permisos = permisos;
            return authentication;
        }
    }
}
