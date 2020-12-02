using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuLich.BUS
{
    public class ChiTietTour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChiTietTour { get; set; }
        public virtual DiaDiem DiaDiem { get; set; }
        public virtual Tour Tour { get; set; }
        public int ThuTu { get; set; }
    }
}
