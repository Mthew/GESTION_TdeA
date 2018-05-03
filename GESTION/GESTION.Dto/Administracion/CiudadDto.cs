namespace GESTION.Dto
{
    public class CiudadDto
    {
        public int Id { get; set; }
        public int IdDepartamento { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public DepartamentoDto Departamento { get; set; }
    }
}
