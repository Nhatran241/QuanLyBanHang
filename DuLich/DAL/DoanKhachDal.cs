using DuLich.BUS;
using DuLich.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class DoanKhachDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static void DeleteAllKhach(Doan doan)
        {
            if (doan.DoanKhachs != null)
            {
                context.DoanKhachs.RemoveRange(doan.DoanKhachs);
            }
        }

        public static Task UpdateListDoanKhach(List<DoanKhach> danhSachDoanKhach)
        {
            foreach(DoanKhach doanKhach in danhSachDoanKhach)
            {
                context.DoanKhachs.Add(doanKhach);
                context.SaveChanges();
            }
            return context.SaveChangesAsync();
        }

    }
}
