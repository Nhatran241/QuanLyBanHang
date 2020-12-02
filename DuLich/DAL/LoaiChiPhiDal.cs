using DuLich.BUS;
using DuLich.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DuLich.DAL
{
    class LoaiChiPhiDal
    {
        static DuLichContext context = DuLichContext.GetInstance();

        public static List<LoaiChiPhi> GetAll()
        {
            return context.LoaiChiPhis.ToList();
        }
     
    }
}
