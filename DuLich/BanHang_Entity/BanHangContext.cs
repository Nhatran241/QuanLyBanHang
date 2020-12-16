namespace DuLich.BanHang_Entity
{
    using System;
    using System.Data.Entity;
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
            : base("name=banhang")
        {
            if(Roles.ToList().Count == 0 && Catalogs.ToList().Count == 0 && Customers.ToList().Count==0 && Employees.ToList().Count==0 && Products.ToList().Count==0)
            {
                role admin = new role { role_name = "admin" };
                role shipper = new role { role_name = "shipper" };
                role nhanvien = new role { role_name = "nhanvien" };

                Roles.Add(admin);
                Roles.Add(shipper);
                Roles.Add(nhanvien);

                catalog vitinh = new catalog { catalog_name = "Máy vi tính" };
                catalog banphim = new catalog { catalog_name = "Bàn phím" };
                catalog chuot = new catalog { catalog_name = "Chuột" };
                catalog tainghe = new catalog { catalog_name = "Tai nghe" };
                catalog loa = new catalog { catalog_name = "Loa" };

                Catalogs.Add(vitinh);
                Catalogs.Add(banphim);
                Catalogs.Add(chuot);
                Catalogs.Add(tainghe);
                Catalogs.Add(loa);

                customer khach1 = new customer { username = "abc", password = "abc", firstname = "Trần Minh", lastname = "Nhật", birthdate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joindate = DateTime.Now, gender = true };
                customer khach2 = new customer { username = "123", password = "abc", firstname = "Trần Minh", lastname = "A", birthdate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joindate = DateTime.Now, gender = true };
                customer khach3 = new customer { username = "456", password = "abc", firstname = "Trần Minh", lastname = "B", birthdate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joindate = DateTime.Now, gender = true };

                Customers.Add(khach1);
                Customers.Add(khach2);
                Customers.Add(khach3);

                employee employee1 = new employee { username = "admin", password = "admin", firstname = "Trần Minh", lastname = "Nhật", birthdate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joindate = DateTime.Now, gender = true, role = admin };
                employee employee2 = new employee { username = "nhanvien", password = "nhanvien", firstname = "Trần Minh", lastname = "Nhan Vien", birthdate = DateTime.Now.AddDays(-365 * 20), address = "TPHCM", joindate = DateTime.Now, gender = true, role = nhanvien };

                Employees.Add(employee1);
                Employees.Add(employee2);

                product product1 = new product
                {
                    product_name = "Laptop Acer Aspire 3 A315 56 36YS i3 1005G1 (NX.HS5SV.008)",
                    catalog = vitinh,
                    amount = 10,
                    price = 13690000,
                    discountpercent = 10,
                    createtime = DateTime.Now,
                    detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz;RAM: 8 GB, DDR4 (On board 4GB +1 khe 4GB), 2400 MHz;Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA;Màn hình: 15.6 inch, Full HD (1920 x 1080);Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics;Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN (RJ45);Hệ điều hành: Windows 10 Home SL;Thiết kế: Vỏ nhựa, PIN liền;Kích thước: Dày 19.9 mm, 1.7 kg",
                };
                product product2 = new product
                {
                    product_name = "Laptop Asus Gaming Rog Strix G512 i7 10750H/144Hz (IAL001T)",
                    catalog = vitinh,
                    amount = 10,
                    price = 13690000,
                    discountpercent = 10,
                    createtime = DateTime.Now,
                    detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz; RAM: 8 GB, DDR4(On board 4GB + 1 khe 4GB), 2400 MHz; Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA; Màn hình: 15.6 inch, Full HD(1920 x 1080); Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics; Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN(RJ45); Hệ điều hành: Windows 10 Home SL; Thiết kế: Vỏ nhựa, PIN liền; Kích thước: Dày 19.9 mm, 1.7 kg"
                };
                product product3 = new product
                {
                    product_name = "Bàn phím Newmen GM368",
                    catalog = banphim,
                    amount = 6,
                    price = 790000,
                    discountpercent = 5,
                    createtime = DateTime.Now,
                    detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz; RAM: 8 GB, DDR4(On board 4GB + 1 khe 4GB), 2400 MHz; Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA; Màn hình: 15.6 inch, Full HD(1920 x 1080); Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics; Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN(RJ45); Hệ điều hành: Windows 10 Home SL; Thiết kế: Vỏ nhựa, PIN liền; Kích thước: Dày 19.9 mm, 1.7 kg"
                };
                product product4 = new product
                {
                    product_name = "Bàn phím E-Dra EK311",
                    catalog = banphim,
                    amount = 3,
                    price = 660000,
                    discountpercent = 5,
                    createtime = DateTime.Now,
                    detail = "CPU: Intel Core i3 Ice Lake, 1005G1, 1.20 GHz; RAM: 8 GB, DDR4(On board 4GB + 1 khe 4GB), 2400 MHz; Ổ cứng: SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA; Màn hình: 15.6 inch, Full HD(1920 x 1080); Card màn hình: Card đồ họa tích hợp, Intel UHD Graphics; Cổng kết nối: 2 x USB 2.0, USB 3.1, HDMI, LAN(RJ45); Hệ điều hành: Windows 10 Home SL; Thiết kế: Vỏ nhựa, PIN liền; Kích thước: Dày 19.9 mm, 1.7 kg"
                };

                Products.Add(product1);
                Products.Add(product2);
                Products.Add(product3);
                Products.Add(product4);

                SaveChanges();
            }
        }

        public virtual DbSet<catalog> Catalogs { get; set; }
        public virtual DbSet<combo> Comboes { get; set; }
        public virtual DbSet<customer> Customers { get; set; }
        public virtual DbSet<employee> Employees { get; set; }
        public virtual DbSet<invoice> Invoices { get; set; }
        public virtual DbSet<product> Products { get; set; }
        public virtual DbSet<role> Roles { get; set; }
        public virtual DbSet<storage> Storages { get; set; }
        public virtual DbSet<invoicedetail> InvoiceDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<catalog>()
                .HasMany(e => e.products)
                .WithOptional(e => e.catalog);

            modelBuilder.Entity<combo>()
                .HasMany(e => e.invoicedetails)
                .WithOptional(e => e.combo);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.invoices)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<invoice>()
                .HasMany(e => e.invoicedetails)
                .WithRequired(e => e.invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.invoicedetails);

            modelBuilder.Entity<product>()
               .HasMany(e => e.storage)
               .WithRequired(e => e.product)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<combo>()
               .HasMany(e => e.comboproducts)
               .WithRequired(e => e.combo)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
               .HasMany(e => e.comboproducts);


        }
    }
}
