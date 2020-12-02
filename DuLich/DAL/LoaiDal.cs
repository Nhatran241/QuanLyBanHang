using DuLich.BUS;
using DuLich.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DuLich.DAL
{
    class LoaiDal
    {
        static DuLichContext context = DuLichContext.GetInstance();


        public static List<Loai> GetAll()
        {
            return context.Loai.ToList();
        }
    }
}
