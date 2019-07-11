using System.Web;
using System.Web.Mvc;

namespace MebelDis.WebAPI.FrondEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
