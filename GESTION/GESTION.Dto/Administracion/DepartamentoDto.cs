namespace GESTION.Dto
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
        public int IdPais { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public PaisDto Pais { get; set; }
    }
}
