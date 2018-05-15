using System.Web;
using GESTION.Dto;
namespace GESTION.View.Models
{
    public class Utilities
    {
        private static string UsuarioActual = "UsuarioActual";

        public static void SetCurrentUser(AuthenticationDto usuario)
        {
            HttpContext.Current.Session[Utilities.UsuarioActual] = usuario;
        }

        public static AuthenticationDto GetCurrentUser()
        {
            try
            {
                return HttpContext.Current.Session[Utilities.UsuarioActual] as AuthenticationDto;
            }
            catch
            {
                return new AuthenticationDto();
            }
        }
    }
}