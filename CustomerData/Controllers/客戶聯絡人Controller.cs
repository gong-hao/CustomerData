using CustomerData.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CustomerData.Controllers
{
    public class 客戶聯絡人Controller : Controller
    {
        private I客戶聯絡人Repository 客戶聯絡人Repository = RepositoryHelper.Get客戶聯絡人Repository();

        private ActionResult FindById(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            客戶聯絡人 客戶聯絡人 = 客戶聯絡人Repository.Find(id);

            if (客戶聯絡人 == null || 客戶聯絡人.是否已刪除)
            {
                return HttpNotFound();
            }

            return View(客戶聯絡人);
        }

        private void SetModify()
        {
            I客戶資料Repository 客戶資料Repository = RepositoryHelper.Get客戶資料Repository();

            ViewBag.客戶Id = new SelectList(客戶資料Repository.All(), "Id", "客戶名稱");
        }

        public ActionResult Index()
        {
            var 客戶聯絡人 = 客戶聯絡人Repository.Where(x => !x.是否已刪除).Include(x => x.客戶資料);

            return View(客戶聯絡人.ToList());
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
        public ActionResult Create(客戶聯絡人 客戶聯絡人)
        {
            if (ModelState.IsValid)
            {
                var isExistEmail = 客戶聯絡人Repository.信箱是否重複(客戶聯絡人);

                if (!isExistEmail)
                {
                    客戶聯絡人Repository.新增客戶聯絡人(客戶聯絡人);

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email 已存在");
                }
            }

            SetModify();

            return View(客戶聯絡人);
        }

        public ActionResult Edit(int? id)
        {
            SetModify();

            return FindById(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(客戶聯絡人 客戶聯絡人)
        {
            if (ModelState.IsValid)
            {
                var isExistEmail = 客戶聯絡人Repository.信箱是否重複(客戶聯絡人, isUpdate: true);

                if (!isExistEmail)
                {
                    客戶聯絡人Repository.編輯客戶聯絡人(客戶聯絡人);

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email 已存在");
                }
            }

            SetModify();

            return View(客戶聯絡人);
        }

        public ActionResult Delete(int? id)
        {
            return FindById(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶聯絡人Repository.刪除客戶聯絡人(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                客戶聯絡人Repository.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}