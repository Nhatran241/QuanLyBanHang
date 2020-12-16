using DuLich.BanHang_Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    public partial class product
    {
       public Task AddOrUpdate()
        {
            return Product_Dal.getInstance().AddOrUpdate(this);
        }

        public long PriceAfterDiscount()
        {
            return (price - (price * discountpercent) / 100);
        }

        public int GetAmountInStorageByTime(DateTime time)
        {
            int amount = this.amount;
            foreach(storage storages in storage)
            {
                if(storages.createtime.Day > time.Day)
                {
                    amount -= storages.amount;
                }
            }
            return amount;
        }
       
    }
}
