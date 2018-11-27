using System.Web;
using System.Web.Mvc;

namespace IrishHistoryAITProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
