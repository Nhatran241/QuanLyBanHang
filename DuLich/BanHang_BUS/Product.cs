using DuLich.BanHang_Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    public partial class Product
    {
       public Task AddOrUpdate()
        {
            return Product_Dal.getInstance().AddOrUpdate(this);
        }

        public long PriceAfterDiscount()
        {
            return (Price - (Price * DiscountPercent) / 100);
        }

        public int GetAmountInStorageByTime(DateTime time)
        {
            int amount = Amount;
            foreach(Storage storages in Storage)
            {
                if(storages.createTime.Day > time.Day)
                {
                    amount -= storages.Amount;
                }
            }
            return amount;
        }
       
    }
}
