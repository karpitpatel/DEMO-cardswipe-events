using System.Web;
using System.Web.Mvc;

namespace DEMO_jquery.cardswipe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
