using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuLich.BUS
{
    public partial class Tour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTour { get; set; }
        public String TenTour { get; set; }
        public virtual Loai LoaiTour { get; set; }
        public virtual ICollection<Gia> GiaTour { get; set; }
        public virtual ICollection<Doan> DoanTour { get; set; }
        public virtual ICollection<ChiTietTour> ChiTietTour { get; set; }
        public override string ToString()
        {
            return TenTour;
        }

    }
}
