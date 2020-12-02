using DuLich.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuLich.BUS
{
    public class DoanKhach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDoanKhach { get; set; }
        public virtual Khach Khach { get; set; }
        public virtual Doan Doan { get; set; }
      
    }
}
