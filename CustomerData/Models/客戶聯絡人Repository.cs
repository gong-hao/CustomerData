using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace CustomerData.Models
{
    public class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
    {
        public bool 信箱是否重複(客戶聯絡人 客戶聯絡人, bool isUpdate = false)
        {
            var query = this.All()
                .Where(x => x.客戶Id == 客戶聯絡人.客戶Id)
                .Where(x => !x.是否已刪除);

            //更新時忽略自身
            if (isUpdate)
            {
                query = query.Where(x => x.Id != 客戶聯絡人.Id);
            }

            var isExistEmail = query.Select(x => x.Email)
                .Any(x => x == 客戶聯絡人.Email);

            return isExistEmail;
        }

        public void 新增客戶聯絡人(客戶聯絡人 客戶聯絡人)
        {
            this.Add(客戶聯絡人);

            this.UnitOfWork.Commit();
        }

        public void 編輯客戶聯絡人(客戶聯絡人 客戶聯絡人)
        {
            this.Entry(客戶聯絡人).State = EntityState.Modified;

            this.UnitOfWork.Commit();
        }

        public void 刪除客戶聯絡人(int id)
        {
            客戶聯絡人 客戶聯絡人 = this.Find(id);

            客戶聯絡人.是否已刪除 = true;

            this.UnitOfWork.Commit();
        }
    }

    public interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
    {
        bool 信箱是否重複(客戶聯絡人 客戶聯絡人, bool isUpdate = false);

        void 新增客戶聯絡人(客戶聯絡人 客戶聯絡人);

        void 編輯客戶聯絡人(客戶聯絡人 客戶聯絡人);

        void 刪除客戶聯絡人(int id);
    }
}