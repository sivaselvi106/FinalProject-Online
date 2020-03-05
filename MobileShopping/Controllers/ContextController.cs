
using MobileShopping.Models;
using MobileShopping.Repository;
using System.Linq;
using System.Web.Mvc;

namespace MobileShopping.Controllers
{
    public class ContextController : Controller
    {
        AccountContext accountContext = new AccountContext();
        public ActionResult SignUpDB()
        {
            accountContext.AccountDB.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult SignUpDB_Post()
        {
            return View();
        }
    }
}