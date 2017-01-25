using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace scubadivelogs.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : scubadivelogsControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}