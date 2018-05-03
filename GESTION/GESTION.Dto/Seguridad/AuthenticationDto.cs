using System.Collections.Generic;

namespace GESTION.Dto
{
    public class AuthenticationDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string RolName { get; set; }
        public int RolId { get; set; }
        public List<string> Permisos { get; set; }
    }
}
