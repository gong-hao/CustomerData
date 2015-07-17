using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace CustomerData.Models
{
    public class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
    {
        public void 新增客戶資料(客戶資料 客戶資料)
        {
            this.Add(客戶資料);

            this.UnitOfWork.Commit();
        }

        public void 編輯客戶資料(客戶資料 客戶資料)
        {
            this.Entry(客戶資料).State = EntityState.Modified;

            this.UnitOfWork.Commit();
        }

        public void 刪除客戶資料(int id)
        {
            客戶資料 客戶資料 = this.Find(id);

            客戶資料.是否已刪除 = true;

            客戶資料.客戶銀行資訊.ToList().ForEach(x => x.是否已刪除 = true);

            客戶資料.客戶聯絡人.ToList().ForEach(x => x.是否已刪除 = true);

            this.UnitOfWork.Commit();
        }
    }

    public interface I客戶資料Repository : IRepository<客戶資料>
    {
        void 新增客戶資料(客戶資料 客戶資料);

        void 編輯客戶資料(客戶資料 客戶資料);

        void 刪除客戶資料(int id);
    }
}