using CustomerData.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CustomerData.Controllers
{
    public class 客戶銀行資訊Controller : Controller
    {
        private I客戶銀行資訊Repository 客戶銀行資訊Repository = RepositoryHelper.Get客戶銀行資訊Repository();

        private ActionResult FindById(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            客戶銀行資訊 客戶銀行資訊 = 客戶銀行資訊Repository.Find(id);

            if (客戶銀行資訊 == null || 客戶銀行資訊.是否已刪除)
            {
                return HttpNotFound();
            }

            return View(客戶銀行資訊);
        }

        private void SetModify()
        {
            I客戶資料Repository 客戶資料Repository = RepositoryHelper.Get客戶資料Repository();

            ViewBag.客戶Id = new SelectList(客戶資料Repository.All(), "Id", "客戶名稱");
        }

        public ActionResult Index()
        {
            var 客戶銀行資訊 = 客戶銀行資訊Repository.Where(x => !x.是否已刪除).Include(x => x.客戶資料);

            return View(客戶銀行資訊.ToList());
        }

        public ActionResult Details(int? id)
        {
            return FindById(id);
        }

        public ActionResult Create()
        {
            SetModify();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(客戶銀行資訊 客戶銀行資訊)
        {
            if (ModelState.IsValid)
            {
                客戶銀行資訊Repository.新增客戶銀行資訊(客戶銀行資訊);

                return RedirectToAction("Index");
            }

            SetModify();

            return View(客戶銀行資訊);
        }

        public ActionResult Edit(int? id)
        {
            SetModify();

            return FindById(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(客戶銀行資訊 客戶銀行資訊)
        {
            if (ModelState.IsValid)
            {
                客戶銀行資訊Repository.修改客戶銀行資訊(客戶銀行資訊);

                return RedirectToAction("Index");
            }

            SetModify();

            return View(客戶銀行資訊);
        }

        public ActionResult Delete(int? id)
        {
            return FindById(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶銀行資訊Repository.刪除客戶銀行資訊(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                客戶銀行資訊Repository.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}