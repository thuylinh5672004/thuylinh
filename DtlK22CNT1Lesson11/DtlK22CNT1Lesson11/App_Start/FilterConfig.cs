using System.Web;
using System.Web.Mvc;

namespace DtlK22CNT1Lesson11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
