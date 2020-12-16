using DuLich.BanHang_Dal;
using System;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    
    public partial class storage
    {
        public void Map(storage storage)
        {
            this.amount = storage.amount;
            this.createtime = storage.createtime;
            this.id = storage.id;
            this.product = storage.product;
        }

        public Task AddOrUpdate(int difAmount)
        {
            product.amount += difAmount;
            return Storage_Dal.getInstance().AddOrUpdate(this);
        }

        public Task Delete()
        {
            product.amount -= amount;
            return Storage_Dal.getInstance().Delete(this);
        }
    }
}
