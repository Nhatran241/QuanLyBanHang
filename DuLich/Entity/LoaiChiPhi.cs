using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuLich.BUS
{
    public class LoaiChiPhi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLoaiChiPhi { get; set; }
        public String TenLoaiChiPhi { get; set; }
        public override string ToString()
        {
            return TenLoaiChiPhi;
        }

    }
}
