using DuLich.BUS;
using DuLich.Entity;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class GiaDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static List<Gia> GetAll()
        {
            return context.Gia.ToList();
        }
        public static Task AddOrUpdate(Gia gia)
        {
            context.Gia.AddOrUpdate(gia);
            return context.SaveChangesAsync();
        }
        public static Task Delete(Gia gia)
        {
            context.Gia.Remove(gia);
            return context.SaveChangesAsync();
        }
    }
}
