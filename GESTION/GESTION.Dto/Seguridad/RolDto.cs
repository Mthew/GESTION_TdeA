using System.Collections.Generic;

namespace GESTION.Dto
{
    public class RolDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public List<PermisoDto> Permisos { get; set; }
    }
}
