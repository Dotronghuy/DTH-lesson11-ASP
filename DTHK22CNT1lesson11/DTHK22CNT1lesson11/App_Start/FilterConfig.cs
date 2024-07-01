using System.Web;
using System.Web.Mvc;

namespace DTHK22CNT1lesson11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
