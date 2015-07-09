using CustomerData.Models;
using System.Linq;
using System.Web.Mvc;

namespace CustomerData.Controllers
{
    public class 簡易報表Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: 簡易報表
        public ActionResult Index()
        {
            return View(db.vw_簡易報表.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}