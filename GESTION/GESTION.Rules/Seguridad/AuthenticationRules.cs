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
        private EntitiesDataContext Entities = null;

        public AuthenticationRules()
        {
            this.Entities = new EntitiesDataContext();
        }

        public AuthenticationDto Login(string userName, string password)
        {
            var user = Entities.Usuarios.Where(e => e.Nombre == userName && e.Clave == password).FirstOrDefault();

            if (user == null)
            {
                throw new Exception("Usuario o clave no validos");
            }

            AuthenticationDto authentication = new AuthenticationDto();
            var persona = user.Persona;
           
            authentication.Id = user.Id;
            authentication.FullName = string.Format("{0} {1} {2} {3}", persona.Nombre, persona.SegundoNombre, persona.Apellido, persona.SegundoApellido);
            authentication.UserName = user.Nombre;
            var rol = user.RolesUsuarios.FirstOrDefault();
            if (rol != null)
            {
                authentication.RolId = rol.Id;
                authentication.RolName = rol.Role.Nombre;
                var permisos = rol.Role.PermisosRols;
                if (permisos != null)
                {
                    authentication.Permisos = permisos.Select(e => e.Permiso.Nombre).ToList();
                }
            }
            return authentication;
        }
    }
}
