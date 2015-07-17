using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace CustomerData.Models
{
    public class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
    {
        public void 新增客戶銀行資訊(客戶銀行資訊 客戶銀行資訊)
        {
            this.Add(客戶銀行資訊);

            this.UnitOfWork.Commit();
        }

        public void 修改客戶銀行資訊(客戶銀行資訊 客戶銀行資訊)
        {
            this.Entry(客戶銀行資訊).State = EntityState.Modified;

            this.UnitOfWork.Commit();
        }

        public void 刪除客戶銀行資訊(int id)
        {
            客戶銀行資訊 客戶銀行資訊 = this.Find(id);

            客戶銀行資訊.是否已刪除 = true;

            this.UnitOfWork.Commit();
        }
    }

    public interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
    {
        void 新增客戶銀行資訊(客戶銀行資訊 客戶銀行資訊);

        void 修改客戶銀行資訊(客戶銀行資訊 客戶銀行資訊);

        void 刪除客戶銀行資訊(int id);
    }
}