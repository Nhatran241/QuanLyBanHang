using DuLich.BUS;
using DuLich.Entity;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class NhanVienDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }
        public static Task AddOrUpdate(NhanVien newNhanVien)
        {
            context.NhanViens.AddOrUpdate(newNhanVien);
            return context.SaveChangesAsync();

        }
        public static Task Delete(NhanVien nhanVien)
        {
            context.NhanViens.Remove(nhanVien);
            return context.SaveChangesAsync();

        }
    }
}
