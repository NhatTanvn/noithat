using DoAn.Models;
using DoAn.Sercurity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace DoAn.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/login")]
    public class LoginController : Controller
    {
        private  MainDbContext db = new MainDbContext();
        private SercurityManager sercurityManager = new SercurityManager();

        public LoginController(MainDbContext _db)
        {
            db = _db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process(string username, string password)
        {
            var account = ProcessLogin(username, password);
            if(account != null)
            {
                sercurityManager.SignIn(this.HttpContext, account);
                return RedirectToAction("index", "dashboard", new { area ="admin"});
            }else
            {
                ViewBag.error = "Invalia account!";
                return View("index");
            }          
        } 
        private Account ProcessLogin(string username, string password)
        {
            var account = db.Accounts.SingleOrDefault(ac =>
                ac.UserName.Equals(username) && ac.Status == true);
            if (account != null)
            {
                if(password == account.Password)
                {
                    return account; 
                }
            }         
            return null;
        }

        [Route("signout")]
        public IActionResult SigOut()
        {
            sercurityManager.SingnOut(this.HttpContext);
            return RedirectToAction("Index","Login", new { area = "admin" });
        }   
        [Route("accessdenied")]
        public IActionResult Accessdenied()
        {
            return View("AccessDenied");
        }
    }
}
