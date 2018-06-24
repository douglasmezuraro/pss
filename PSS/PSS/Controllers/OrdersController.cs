using System.Web.Mvc;
using PSS.Models;
using PSS.Utils;

namespace PSS.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            User user = (User)Session["User"];
            OrderFactory factory = new OrderFactory();
            return RedirectToAction("Index", factory.GetControllerName(user));
        }
    }
}