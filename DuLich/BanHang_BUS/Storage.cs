using DuLich.BanHang_Dal;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    
    public partial class Storage
    {
        public void Map(Storage storage)
        {
            this.Amount = storage.Amount;
            this.createTime = storage.createTime;
            this.ID = storage.ID;
            this.Product = storage.Product;
        }

        public Task AddOrUpdate(int difAmount)
        {
            Product.Amount += difAmount;
            return Storage_Dal.getInstance().AddOrUpdate(this);
        }
    }
}
