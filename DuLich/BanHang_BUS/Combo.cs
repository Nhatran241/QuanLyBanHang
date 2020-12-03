using DuLich.BanHang_Dal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    public partial class Combo
    {
        public Task AddOrUpdate()
        {
            return Combo_Dal.getInstance().AddOrUpdate(this);
        }
    }
}
