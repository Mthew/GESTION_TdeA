using System;

namespace GESTION.Dto
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public int IdCiudad { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public CiudadDto Ciudad { get; set; }
        public TipoDocumentoDto TipoDocumento { get; set; }
    }
}
