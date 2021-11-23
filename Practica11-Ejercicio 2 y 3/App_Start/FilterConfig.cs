using System.Web;
using System.Web.Mvc;

namespace Practica11_Ejercicio2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
