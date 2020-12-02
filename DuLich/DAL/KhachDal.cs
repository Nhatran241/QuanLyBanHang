using DuLich.BUS;
using DuLich.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.DAL
{
    class KhachDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static List<Khach> GetAll()
        {
            return context.Khaches.ToList();
        }
        public static Task AddOrUpdate(Khach khach)
        {
            context.Khaches.AddOrUpdate(khach);
            return context.SaveChangesAsync();
        }
        public static Task Delete(Khach khach)
        {
            context.Khaches.Remove(khach);
            return context.SaveChangesAsync();
        }
    }
}
