namespace GESTION.Dto
{
    public class UsiarioDto
    {
        public int Id { get; set; }
        public int? IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }

        public PaisDto Persona { get; set; }
    }
}
