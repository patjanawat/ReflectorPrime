using System.Web.Mvc;
using PCMI.DeveloperTest.BLL;

namespace PCMI.DeveloperTest.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var contracts = new Contracts();
            return View(contracts.GetAllContracts());
        }

        public ActionResult GridViewPartialView()
        {
            var contracts = new Contracts();
            return PartialView("GridViewPartialView", contracts.GetAllContracts());
        }
    }
}