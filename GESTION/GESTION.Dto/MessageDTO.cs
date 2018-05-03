using GESTION.Comun;

namespace GESTION.Dto
{
    public class MessageDto
    {
        public string Message { get; set; }
        public CommonEnums.StatusEnums Type { get; set; }
        public string ResponseType { get; set; }
        public bool Flag { get; set; }
    }
}
