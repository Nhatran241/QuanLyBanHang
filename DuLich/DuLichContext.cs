using DuLich.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich.Entity
{
    public class DuLichContext : DbContext
    {
        public DuLichContext() : base("dulichdb")
        {
            try
            {
                if (DiaDiem.ToList().Count == 0)
                {
                    new List<DiaDiem>
            {
                new DiaDiem { TenDiaDiem ="Hà Nội"},
                new DiaDiem { TenDiaDiem ="Lạng Sơn" },
                new DiaDiem { TenDiaDiem ="Cao Bằng" },
                new DiaDiem { TenDiaDiem ="Nha Trang" },
                new DiaDiem { TenDiaDiem ="Mũi Né" },
                new DiaDiem { TenDiaDiem ="Phú Quốc" },
                new DiaDiem { TenDiaDiem ="Nghệ An" },
                new DiaDiem { TenDiaDiem ="Hội An" },
                new DiaDiem { TenDiaDiem ="Huế" },
                new DiaDiem {TenDiaDiem="Tp Hồ Chí Minh" },
                new DiaDiem {TenDiaDiem="Vũng Tàu" }
            }.ForEach(x => DiaDiem.Add(x));
                    SaveChanges();
                }
                if (Loai.ToList().Count == 0)
                {
                    new List<Loai>
            {
                new Loai { TenLoai= "Tour cao cấp"},
                new Loai { TenLoai= "Tour bình dân"},
                new Loai { TenLoai= "Tour truyền thống"}
            }.ForEach(x => Loai.Add(x));
                    SaveChanges();
                }
            }
            catch(Exception e) { }
               
            

        }
        public DbSet<Touris> Touris { get; set; }
        public DbSet<Gia> Gia { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<DiaDiem> DiaDiem { get; set; }
        public DbSet<ChiTietTour> ChiTietTour { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // XÓa tour xóa giá luôn
            modelBuilder.Entity<Touris>()
                        .HasMany<Gia>(g => g.Gias)
                        .WithRequired(s => s.touris)
                        .WillCascadeOnDelete();
            // Xóa luôn chi tiết
            modelBuilder.Entity<Touris>()
                        .HasMany<ChiTietTour>(g => g.ChiTietTours)
                        .WithRequired(s => s.touris)
                        .WillCascadeOnDelete();
            // configures one-to-many relationship {Touris} - [Gia]
            //modelBuilder.Entity<Gia>()
            //  .HasRequired<Touris>(s => s.touris)
            // .WithMany(g => g.Gias)
            //  .HasForeignKey<int>(s => s.TourisId);

            // configures one-to-many relationship {Touris} - [ChiTietTour]
            //modelBuilder.Entity<ChiTietTour>()
            //   .HasRequired<Touris>(s => s.touris)
            //    .WithMany(g => g.ChiTietTours)
            //  .HasForeignKey<int>(s => s.TourisId);
        }
    }
}
