using System.Web;
using System.Web.Mvc;

namespace Time_Series_Serach_Engine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
