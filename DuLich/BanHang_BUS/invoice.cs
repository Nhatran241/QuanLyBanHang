using DuLich.BanHang_Dal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    public partial class invoice
    {
        public Task AddOrUpdate()
        {
            return Invoice_Dal.getInstance().AddOrUpdate(this);
        }

        public long TotalMoney()
        {
            long tong = 0;
            if (invoicedetails == null)
                return tong;
            foreach (invoicedetail invoiceDetail in invoicedetails)
            {
                tong += invoiceDetail.price * invoiceDetail.amount;
            }
            return tong;
        }
    }
}
