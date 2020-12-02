using DuLich.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuLich.BUS
{
    public class ChiPhi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChiPhi { get; set; }
        public virtual Doan Doan { get; set; }
        public virtual LoaiChiPhi LoaiChiPhi { get; set; }
        public long GiaTri { get; set; }
        public string GhiChu { get; set; }

        public void Map(ChiPhi chiphi)
        {
            LoaiChiPhi = chiphi.LoaiChiPhi;
            Doan =chiphi.Doan;
            GhiChu =chiphi.GhiChu;
            GiaTri = chiphi.GiaTri;
            MaChiPhi =chiphi.MaChiPhi;
        }

    }
}
