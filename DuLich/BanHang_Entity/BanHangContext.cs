namespace DuLich.BanHang_Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BanHangContext : DbContext
    {
        private static BanHangContext instance;
        public static BanHangContext GetInstance()
        {
            if (instance == null)
                instance = new BanHangContext();
            return instance;
        }
        public BanHangContext()
            : base("name=BanHangContext")
        {
            if(Roles.ToList().Count == 0 && Catalogs.ToList().Count == 0 && Customers.ToList().Count==0 && Employees.ToList().Count==0 && Products.ToList().Count==0)
            {
                Role admin = new Role { Role_Name = "admin" };
                Role shipper = new Role { Role_Name = "shipper" };
                Role nhanvien = new Role { Role_Name = "nhanvien" };

                Roles.Add(admin);
                Roles.Add(shipper);
                Roles.Add(nhanvien);

                Catalog vitinh = new Catalog { Catalog_Name = "Máy vi tính" };
                Catalog banphim = new Catalog { Catalog_Name = "Bàn phím" };
                Catalog chuot = new Catalog { Catalog_Name = "Chuột" };
                Catalog tainghe = new Catalog { Catalog_Name = "Tai nghe" };
                Catalog loa = new Catalog { Catalog_Name = "Loa" };

                Catalogs.Add(vitinh);
                Catalogs.Add(banphim);
                Catalogs.Add(chuot);
                Catalogs.Add(tainghe);
                Catalogs.Add(loa);

                Customer khach1 = new Customer { username = "abc", password = "abc", firstName = "Trần Minh", lastName = "Nhật", birthDate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joinDate = DateTime.Now, gender = true };
                Customer khach2 = new Customer { username = "123", password = "abc", firstName = "Trần Minh", lastName = "A", birthDate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joinDate = DateTime.Now, gender = true };
                Customer khach3 = new Customer { username = "456", password = "abc", firstName = "Trần Minh", lastName = "B", birthDate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joinDate = DateTime.Now, gender = true };

                Customers.Add(khach1);
                Customers.Add(khach2);
                Customers.Add(khach3);

                Employee employee1 = new Employee { username = "admin", password = "admin", firstName = "Trần Minh", lastName = "Nhật", birthDate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joinDate = DateTime.Now, gender = true, Role = admin };
                Employee employee2 = new Employee { username = "nhanvien", password = "nhanvien", firstName = "Trần Minh", lastName = "Nhan Vien", birthDate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joinDate = DateTime.Now, gender = true, Role = nhanvien };

                Employees.Add(employee1);
                Employees.Add(employee2);

                Product product1 = new Product
                {
                    Product_Name = "Laptop Acer Aspire 3 A315 56 36YS i3 1005G1 (NX.HS5SV.008)",
                    Catalog = vitinh,
                    Amount = 10,
                    Price = 13690000,
                    DiscountPercent = 10,
                    CreateTime = DateTime.Now,
                    Detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz;RAM: 8 GB, DDR4 (On board 4GB +1 khe 4GB), 2400 MHz;Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA;Màn hình: 15.6 inch, Full HD (1920 x 1080);Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics;Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN (RJ45);Hệ điều hành: Windows 10 Home SL;Thiết kế: Vỏ nhựa, PIN liền;Kích thước: Dày 19.9 mm, 1.7 kg",
                };
                Product product2 = new Product
                {
                    Product_Name = "Laptop Asus Gaming Rog Strix G512 i7 10750H/144Hz (IAL001T)",
                    Catalog = vitinh,
                    Amount = 10,
                    Price = 13690000,
                    DiscountPercent = 10,
                    CreateTime = DateTime.Now,
                    Detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz; RAM: 8 GB, DDR4(On board 4GB + 1 khe 4GB), 2400 MHz; Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA; Màn hình: 15.6 inch, Full HD(1920 x 1080); Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics; Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN(RJ45); Hệ điều hành: Windows 10 Home SL; Thiết kế: Vỏ nhựa, PIN liền; Kích thước: Dày 19.9 mm, 1.7 kg"
                };
                Product product3 = new Product
                {
                    Product_Name = "Bàn phím Newmen GM368",
                    Catalog = banphim,
                    Amount = 6,
                    Price = 790000,
                    DiscountPercent = 5,
                    CreateTime = DateTime.Now,
                    Detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz; RAM: 8 GB, DDR4(On board 4GB + 1 khe 4GB), 2400 MHz; Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA; Màn hình: 15.6 inch, Full HD(1920 x 1080); Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics; Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN(RJ45); Hệ điều hành: Windows 10 Home SL; Thiết kế: Vỏ nhựa, PIN liền; Kích thước: Dày 19.9 mm, 1.7 kg"
                };
                Product product4 = new Product
                {
                    Product_Name = "Bàn phím E-Dra EK311",
                    Catalog = banphim,
                    Amount = 3,
                    Price = 660000,
                    DiscountPercent = 5,
                    CreateTime = DateTime.Now,
                    Detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz; RAM: 8 GB, DDR4(On board 4GB + 1 khe 4GB), 2400 MHz; Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA; Màn hình: 15.6 inch, Full HD(1920 x 1080); Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics; Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN(RJ45); Hệ điều hành: Windows 10 Home SL; Thiết kế: Vỏ nhựa, PIN liền; Kích thước: Dày 19.9 mm, 1.7 kg"
                };

                Products.Add(product1);
                Products.Add(product2);
                Products.Add(product3);
                Products.Add(product4);

                SaveChanges();
            }
        }

        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalog>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Catalog);

            modelBuilder.Entity<Combo>()
                .HasMany(e => e.InvoiceDetails)
                .WithOptional(e => e.Combo);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.Shipper);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
               .HasMany(e => e.Storage)
               .WithRequired(e => e.Product)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Combo>()
               .HasMany(e => e.ComboProducts)
               .WithRequired(e => e.Combo)
               .WillCascadeOnDelete(false);


        }
    }
}
