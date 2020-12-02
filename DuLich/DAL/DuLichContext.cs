using DuLich.BUS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DuLich.Entity
{
    public class DuLichContext : DbContext
    {
        private static DuLichContext instance;
        public static DuLichContext GetInstance()
        {
            if (instance == null)
                instance = new DuLichContext();
            return instance;
        }
        public DuLichContext() : base("dulichdbs")
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
                if (NhanViens.ToList().Count == 0)
                {
                    new List<NhanVien>{
                        new NhanVien { TenNhanVien= "Nhật",DiaChi="35/2b khu phố 5 nhà bè",SoCmnd="025711770",SoDienThoai="0909228923",NgaySinh=DateTime.Now.AddDays(-20*365),GioiTinh="Nam"},
                        new NhanVien { TenNhanVien= "Nam",DiaChi="35/2b khu phố 5 nhà bè",SoCmnd="025711770",SoDienThoai="0909228923",NgaySinh=DateTime.Now.AddDays(-20*365),GioiTinh="Nam"},
                        new NhanVien { TenNhanVien= "Phat",DiaChi="35/2b khu phố 5 nhà bè",SoCmnd="025711770",SoDienThoai="0909228923",NgaySinh=DateTime.Now.AddDays(-20*365),GioiTinh="Nam"},
                        new NhanVien { TenNhanVien= "Kha",DiaChi="35/2b khu phố 5 nhà bè",SoCmnd="025711770",SoDienThoai="0909228923",NgaySinh=DateTime.Now.AddDays(-20*365),GioiTinh="Nam"}
                    }.ForEach(x => NhanViens.Add(x));
                    SaveChanges();
                }
                if (LoaiChiPhis.ToList().Count == 0)
                {
                    new List<LoaiChiPhi>
            {
                new LoaiChiPhi { TenLoaiChiPhi= "Ăn Uống"},
                new LoaiChiPhi { TenLoaiChiPhi= "Khách Sạn "},
                new LoaiChiPhi { TenLoaiChiPhi= "Phương Tiện"}
            }.ForEach(x => LoaiChiPhis.Add(x));
                    SaveChanges();
                }
               
        }
            catch(Exception e) { }
        }
        public DbSet<Tour> Touris { get; set; }
        public DbSet<Gia> Gia { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<DiaDiem> DiaDiem { get; set; }
        public DbSet<ChiTietTour> ChiTietTour { get; set; }
        public DbSet<Doan> Doans { get; set; }
        public DbSet<DoanKhach> DoanKhachs { get; set; }
        public DbSet<Khach> Khaches { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhanCong> PhanCongs { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }
        public DbSet<LoaiChiPhi> LoaiChiPhis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // XÓa tour xóa giá luôn
            modelBuilder.Entity<Tour>()
                        .HasMany<Gia>(g => g.GiaTour)
                        .WithRequired(s => s.Tour)
                        .WillCascadeOnDelete();

            modelBuilder.Entity<Tour>()
                      .HasMany<Doan>(g => g.DoanTour)
                      .WithRequired(s => s.Tour)
                      .WillCascadeOnDelete();
            // Xóa luôn chi tiết
            modelBuilder.Entity<Tour>()
                        .HasMany<ChiTietTour>(g => g.ChiTietTour)
                        .WithRequired(s => s.Tour)
                        .WillCascadeOnDelete();

            // Xóa đoàn xóa luôn những phân công liên quan
            modelBuilder.Entity<Doan>()
                       .HasMany<PhanCong>(g => g.PhanCong)
                       .WithRequired(s => s.Doan)
                       .WillCascadeOnDelete();

            // Xóa đoàn xóa luôn những chi phí liên quan
            modelBuilder.Entity<Doan>()
                       .HasMany(g => g.ChiPhi)
                       .WithRequired(s => s.Doan)
                       .WillCascadeOnDelete();

            // xóa đoàn thì xóa những đoàn khách liên quan nhưng ko xóa đoàn
            modelBuilder.Entity<Doan>()
                       .HasMany<DoanKhach>(g => g.DoanKhach)
                       .WithRequired(s => s.Doan)
                       .WillCascadeOnDelete();

            modelBuilder.Entity<Khach>()
                     .HasMany<DoanKhach>(g => g.DoanKhach)
                       .WithRequired(s => s.Khach)
                       .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                    .HasMany<PhanCong>(g => g.PhanCong)
                      .WithRequired(s => s.NhanVien)
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
