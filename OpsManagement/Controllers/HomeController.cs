using OpsManagement.Models;
using System.Web.Mvc;

namespace OpsManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(User user)
        {
            return View(user);
        }

        public ActionResult Login(User user)
        {
            if(user == null) { user= new User { IsAuthenticated = false}; }
           if(!string.IsNullOrWhiteSpace(user.UserName) || !string.IsNullOrWhiteSpace(user.UserName))
            {
                user.IsAuthenticated= true;
            }
            return RedirectToAction("Index", "Home",user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Soon to be removed.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}