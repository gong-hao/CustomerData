using CustomerData.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CustomerData.Controllers
{
    public class 客戶資料Controller : Controller
    {
        private I客戶資料Repository 客戶資料Repository = RepositoryHelper.Get客戶資料Repository();

        private ActionResult FindById(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            客戶資料 客戶資料 = 客戶資料Repository.Find(id);

            if (客戶資料 == null || 客戶資料.是否已刪除)
            {
                return HttpNotFound();
            }

            return View(客戶資料);
        }

        public ActionResult Index()
        {
            var 客戶資料 = 客戶資料Repository.Where(x => !x.是否已刪除);

            return View(客戶資料.ToList());
        }

        public ActionResult Details(int? id)
        {
            return FindById(id);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(客戶資料 客戶資料)
        {
            if (ModelState.IsValid)
            {
                客戶資料Repository.新增客戶資料(客戶資料);

                return RedirectToAction("Index");
            }

            return View(客戶資料);
        }

        public ActionResult Edit(int? id)
        {
            return FindById(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(客戶資料 客戶資料)
        {
            if (ModelState.IsValid)
            {
                客戶資料Repository.編輯客戶資料(客戶資料);

                return RedirectToAction("Index");
            }

            return View(客戶資料);
        }

        public ActionResult Delete(int? id)
        {
            return FindById(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶資料Repository.刪除客戶資料(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                客戶資料Repository.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}