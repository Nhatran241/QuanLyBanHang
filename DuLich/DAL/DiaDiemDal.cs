using DuLich.BUS;
using DuLich.Entity;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class DiaDiemDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static List<DiaDiem> GetAll()
        {
            return context.DiaDiem.ToList();
        }
        public static Task AddOrUpdate(DiaDiem diaDiem)
        {
            context.DiaDiem.AddOrUpdate(diaDiem);
            return context.SaveChangesAsync();
        }
        public static Task Delete(DiaDiem diaDiem)
        {
            context.DiaDiem.Remove(diaDiem);
            return context.SaveChangesAsync();
        }
     
        public static DiaDiem GetDiaDiemByName(string name)
        {
            return context.DiaDiem.Where(c => c.TenDiaDiem == name).FirstOrDefault();
        }
    }
}
