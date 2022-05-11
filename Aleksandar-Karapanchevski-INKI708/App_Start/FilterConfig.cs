using System.Web;
using System.Web.Mvc;

namespace Aleksandar_Karapanchevski_INKI708
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
