using DuLich.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace DuLich.BUS
{
    public partial class DiaDiem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDienDiem { get; set; }
        public String TenDiaDiem { get; set; }
        public virtual ICollection<ChiTietTour> ChiTietTour { get; set; }
        public override string ToString()
        {
            return TenDiaDiem;
        }
    }
}
