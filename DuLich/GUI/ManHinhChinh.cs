using DuLich.BanHang_Dal;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.DAL;
using DuLich.GUI.QuanLyChiPhi;
using DuLich.GUI.QuanLyCombo;
using DuLich.GUI.QuanLyDiaDiem;
using DuLich.GUI.QuanLyDoan;
using DuLich.GUI.QuanLyKhach;
using DuLich.GUI.QuanLyKhoHang;
using DuLich.GUI.QuanLyNhanVien;
using DuLich.GUI.QuanLyPhanCong;
using DuLich.GUI.QuanLyThietBi;
using DuLich.GUI.QuanLyTouris;
using DuLich.GUI.ThongKe;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DuLich
{
    public partial class ManHinhChinh : Form
       
    {
        private UserControl userControl;
        private Product_Dal product_Dal = Product_Dal.getInstance();
        private Combo_Dal combo_Dal = Combo_Dal.getInstance();
        private Storage_Dal storage_Dal = Storage_Dal.getInstance();
        public ManHinhChinh()
        {
            InitializeComponent();
            OnManHinhChinhLoad();
        }
     
        private void OnManHinhChinhLoad(){
            ShowDanhSachThietBi();
        }
        public void ShowDanhSachThietBi()
        {
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(new DanhSachThietBi(product_Dal.GetAll(), Catalog_Dal.GetAll(), this));
        }
        public void ShowDanhSachCombo()
        {
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(new DanhSachCombo(combo_Dal.GetAll(), this));
        }

        private void showDanhSachXuatNhap()
        {
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(new DanhSachXuatNhap(storage_Dal.GetAll(),product_Dal.GetAll(), this));
        }
        private void showThongKe()
        {
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(new ThongKe(product_Dal.GetAll()));
        }


    }

}
/**
 * Quản Lý Thiết Bị
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachThietBi.IDanhSachThietBiListener,ChiTietThietBi.IChiTietThietBiListener
    {
        ChiTietThietBi chiTietThietBi;
        private void Btn_DanhSachThietBiClick(object sender, EventArgs e)
        {
            ShowDanhSachThietBi();
        }


        public void onDanhSachThietBi_DoubleClick(Product product)
        {
            chiTietThietBi = new ChiTietThietBi(product, Catalog_Dal.GetAll(),this);
            chiTietThietBi.ShowDialog();
        }

        public void onDanhSachThietBi_ThemClick()
        {
            Product product = new Product();
            chiTietThietBi = new ChiTietThietBi(product, Catalog_Dal.GetAll(), this);
            chiTietThietBi.ShowDialog();
        }

        public void onDanhSachThietBi_XoaClick(Product product)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thiết bị này ", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(product.ComboProducts != null && product.ComboProducts.Count >0 || product.Storage != null && product.Storage.Count > 0)
                {
                    DialogResult kq = MessageBox.Show("Không thể xóa thiết bị này vì thiết bị đang thuộc combo hoặc đơn hàng khác", "", MessageBoxButtons.YesNo);
                }

            }
        }

        public void onLuuClick(Product product)
        {
            product.AddOrUpdate().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    chiTietThietBi.Close();
                    ShowDanhSachThietBi();
                });

            });
        }

        public void onHuyChiTietThietBiClick()
        {
            chiTietThietBi.Close();
        }
    }

}
/**
 *  Quản lý Combo
 */

namespace DuLich
{
    public partial class ManHinhChinh : DanhSachCombo.IDanhSachComboListener,ChiTietCombo.IChiTietComboListener
    {
        ChiTietCombo chiTietCombo;
        private void Btn_DanhSachComboClick(object sender, EventArgs e)
        {
            ShowDanhSachCombo();
        }
        public void onDanhSachCombo_SuaClick(Combo combo)
        {
            chiTietCombo = new ChiTietCombo(combo, this);
            chiTietCombo.ShowDialog();
        }

        public void onDanhSachCombo_ThemClick()
        {
            Combo combo = new Combo();
            chiTietCombo = new ChiTietCombo(combo, this);
            chiTietCombo.ShowDialog();

        }

        public void onDanhSachCombo_XoaClick(Combo combo)
        {
            
        }

        public void onLuuClick(Combo combo)
        {
            combo.AddOrUpdate().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    chiTietCombo.Close();
                    ShowDanhSachCombo();
                });

            });
        }

        public void onHuyChiTietComboClick()
        {
            chiTietCombo.Close();
        }
    }
}



/**
 * Quản Lý Tour - Danh Sách Chọn Địa ĐIểm
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachChonDiaDiem.IDanhSachChonDiaDiemListener
    {
        //if (newDiaDiemCuaTour.Count() != 0)
        //     {
        //   if (diaDiemCuaTour.Count > 0)
        // {
        //   for (int i = 0; i < diaDiemCuaTour.Count(); i++)

        //     Console.WriteLine("dia diem " + diaDiemCuaTour.ToArray()[i].TenDiaDiem);
        //   ChiTietTour chiTietTour = new ChiTietTour();
        // if (listChiTietTour.Count() > 0)
        /**
         * {
            ChiTietTour tempChiTiet = listChiTietTour.First();
            if (tempChiTiet != null)
            {
                chiTietTour.MaChiTietTour = tempChiTiet.MaChiTietTour;
                listChiTietTour.RemoveAt(0);
            }
        }
        chiTietTour.diaDiem = diaDiemCuaTour.ToArray()[i];
        chiTietTour.touris = touris;
        chiTietTour.ThuTu = i + 1;
        duLichContext.ChiTietTour.AddOrUpdate(chiTietTour);
    }
}
//  else
//{
  //  for (int i = 0; i < newDiaDiemCuaTour.Count(); i++)
    //{
      //  ChiTietTour chiTietTour = new ChiTietTour();
        //chiTietTour.diaDiem = newDiaDiemCuaTour.ToArray()[i];
        //chiTietTour.touris = touris;
        //chiTietTour.ThuTu = i + 1;
        //duLichContext.ChiTietTour.AddOrUpdate(chiTietTour);
   // }
// }

//            }
foreach (ChiTietTour chiTiet in listChiTietTour) {

Console.WriteLine(chiTiet.diaDiem.TenDiaDiem);
}
        */

        public void onDanhSachChonDiaDiem_LuuClick(Tour tourHienTai, List<DiaDiem> danhSachDiaDiemTrongDoanUpdate)
        {
            tourHienTai.DeleteAllChiTietTour();
            tourHienTai.UpdateListDiaDiemTour(danhSachDiaDiemTrongDoanUpdate).ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    (userControl as ChiTietTouris).UpdateData(
                          tourHienTai.GetListGiaOfTour(),
                          tourHienTai.GetListDiaDiemOfTour());
                });
            });
        }
    }

}
/**
 * Quản Lý Tour - Danh Sach Gia
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachGia.IDanhSachGiaListener, ChiTietGia.IChiTietGiaListener
    {
        ChiTietGia chiTietGia;

        public void onDanhSachGiaThemClick(Tour tourHienTai)
        {
            Gia gia = new Gia();
            gia.Tour = tourHienTai;
            chiTietGia = new ChiTietGia(gia, this);
            chiTietGia.ShowDialog();
        }

        public void onDanhSachGiaSuaClick(Gia gia)
        {
            chiTietGia = new ChiTietGia(gia, this);
            chiTietGia.ShowDialog();
        }

        public void onDanhSachGiaXoaClick(Tour tourHienTai,Gia gia)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa Giá với mã là :" + gia.MaGia, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<Doan> doanDangKhaiThac = tourHienTai.GetListDoanOfTourWithPrice(gia);
                if (doanDangKhaiThac.Count > 0)
                {
                    String message = "";
                    foreach (Doan doan in doanDangKhaiThac)
                    {
                        message += "- "+doan.TenDoan + " \n";
                    }
                    DialogResult innerDialogResukt = MessageBox.Show("Giá này đang được áp dụng ở các đoàn : \n" + message + " nên không thể xóa được giá này");
                }
                else
                {
                    gia.Delete().ContinueWith(task =>
                    {
                        if (userControl is ChiTietTouris)
                        {
                            panel_main_content.Invoke((MethodInvoker)delegate
                            {
                                panel_main_content.Invoke((MethodInvoker)delegate
                                {
                                    (userControl as ChiTietTouris).UpdateData(tourHienTai.GetListGiaOfTour(), tourHienTai.GetListDiaDiemOfTour());
                                    panel_main_content.Controls.Clear();
                                    panel_main_content.Controls.Add(userControl);
                                });
                            });
                        }
                    });
                }
            }

        }

        public void onChiTietGia_LuuClick(Gia gia)
        {
            gia.AddOrUpdate().ContinueWith(task =>
            {
                if (userControl is ChiTietTouris)
                {
                    panel_main_content.Invoke((MethodInvoker)delegate
                    {
                        chiTietGia.Close();
                        (userControl as ChiTietTouris).UpdateData(gia.Tour.GetListGiaOfTour(),gia.Tour.GetListDiaDiemOfTour());
                    });
                }
            });
        }

        public void onChiTietGia_HuyClick()
        {
            chiTietGia.Close();
        }
    }

}
/**
 * Quản Lý Đoàn
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachDoan.IDanhSachDoanListener
    {
        private void button1_Click(object sender, EventArgs e)
        {
            userControl = new DanhSachDoan(DoanDal.GetAll(), TourDal.GetAll(),NhanVienDal.GetAll(),KhachDal.GetAll(), this);
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(userControl);
        }



        public void onDanhSachDoan_DoanDoubleClick(Doan doan)
        {
            List<Tour> listTourHasPrice = TourDal.GetListTourHasPrice();
            userControl = new ChiTietDoan(doan,listTourHasPrice,
                doan.GetListPhanCong(),
                doan.GetListChiPhi(),
                KhachDal.GetAll(),
                doan.GetListKhach(), this, this, this, this); ;
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(userControl);
        }

        public void onDanhSachDoan_ThemClick()
        {
            userControl = new ChiTietDoan(new Doan(), TourDal.GetListTourHasPrice(), null, null, null, null, this, this, this, this);
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(userControl);
        }

        public void onDanhSachDoan_XoaClick(Doan doan)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa Đoàn với mã là :" + doan.MaDoan, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                doan.Delete().ContinueWith(task =>
                {
                    panel_main_content.Invoke((MethodInvoker)delegate
                    {
                        userControl = new DanhSachDoan(DoanDal.GetAll(), TourDal.GetAll(), NhanVienDal.GetAll(), KhachDal.GetAll(), this);
                        panel_main_content.Controls.Clear();
                        panel_main_content.Controls.Add(userControl);
                    });
                });
            }
           
        }
    }
}

/**
 * Quản Lý Đoàn - Chi Tiết Đoàn -Thêm- Cập Nhật - Xóa
 */

namespace DuLich
{
    public partial class ManHinhChinh : ChiTietDoan.IChiTietDoanListener
    {
        public void onChiTietDoanClick_CapNhat(Doan doanSauKhiCapNhat)
        {
            doanSauKhiCapNhat.AddOrUpdate().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    userControl = new ChiTietDoan(
                        doanSauKhiCapNhat,
                        TourDal.GetListTourHasPrice(),
                        doanSauKhiCapNhat.GetListPhanCong(),
                        doanSauKhiCapNhat.GetListChiPhi(),
                        KhachDal.GetAll(),
                        doanSauKhiCapNhat.GetListKhach(),this,this,this,this);
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);
                });
            });
        }

        public void onChiTietDoanClick_Xoa(Doan doanCanXoa)
        {
            /**
             * Chỗ này nên hỏi trước khi xóa
             */
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa Đoàn với mã là :" + doanCanXoa.MaDoan, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                doanCanXoa.Delete().ContinueWith(task =>
                {
                    panel_main_content.Invoke((MethodInvoker)delegate
                    {
                        userControl = new DanhSachDoan(DoanDal.GetAll(), TourDal.GetAll(), NhanVienDal.GetAll(), KhachDal.GetAll(), this);
                        panel_main_content.Controls.Clear();
                        panel_main_content.Controls.Add(userControl);
                    });
                });
            }

               
        }


    

    }
}

/**
 * Quản Lý Đoàn - Chi Phí
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachChiPhi.IDanhSachChiPhiListener, ChiTietChiPhi.IChiTietChiPhiListener
    {
        ChiTietChiPhi formChiPhi;
        public void onDanhSachChiPhi_ThemClick(Doan doanHienTai)
        {
            ChiPhi chiPhi = new ChiPhi();
            chiPhi.Doan = doanHienTai;
            formChiPhi = new ChiTietChiPhi(chiPhi, LoaiChiPhiDal.GetAll(), this);
            formChiPhi.ShowDialog();
        }

        public void onDanhSachChiPhi_SuaClick(ChiPhi chiPhi)
        {
            formChiPhi = new ChiTietChiPhi(chiPhi, LoaiChiPhiDal.GetAll(), this);
            formChiPhi.ShowDialog();
        }

        public void onDanhSachChiPhi_XoaClick(Doan doanHienTai,ChiPhi chiPhi)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa chi phí với mã là :" + chiPhi.MaChiPhi, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                doanHienTai.DeleteChiPhi(chiPhi).ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    (userControl as ChiTietDoan).UpdateData(
                          doanHienTai.GetListPhanCong(),
                          doanHienTai.GetListChiPhi(),
                          KhachDal.GetAll(),
                          doanHienTai.GetListKhach()); ;
                });
            });
            }
        }

        public void onChiTietChiPhi_LuuClick(Doan doanHienTai,ChiPhi chiPhi)
        {
            doanHienTai.AddOrUpdateChiPhi(chiPhi).ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    formChiPhi.Close();
                    (userControl as ChiTietDoan).UpdateData(
                          doanHienTai.GetListPhanCong(),
                          doanHienTai.GetListChiPhi(),
                          KhachDal.GetAll(),
                          doanHienTai.GetListKhach());
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);
                });

            });
        }
        public void onChiTietChiPhi_HuyClick()
        {
            formChiPhi.Close();
        }

    }
}
/**
 * Quản Lý Đoàn - Phân Công
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachPhanCong.IDanhSachPhanCongListener,
        ChiTietPhanCong.IChiTietPhanCongListener
    {
        ChiTietPhanCong form;
        public void onDanhSachPhanCongThemClick(Doan doanHienTai)
        {
            PhanCong phanCong = new PhanCong();
            phanCong.Doan = doanHienTai;
            form = new ChiTietPhanCong(phanCong,NhanVienDal.GetAll(),this);
            form.ShowDialog();
        }

        public void onDanhSachPhanCongSuaClick(PhanCong phanCong)
        {
            form = new ChiTietPhanCong(phanCong, NhanVienDal.GetAll(), this);
            form.ShowDialog();
        }

        public void onDanhSachPhanCongXoaClick(Doan doanHienTai,PhanCong phanCong)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa phân công với mã là :" + phanCong.MaPhanCong, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                doanHienTai.DeletePhanCong(phanCong).ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    (userControl as ChiTietDoan).UpdateData(
                          doanHienTai.GetListPhanCong(),
                          doanHienTai.GetListChiPhi(),
                          KhachDal.GetAll(),
                          doanHienTai.GetListKhach());
                });
            });
            }
        }

        public void onChiTietPhanCong_LuuClick(Doan doanHienTai,PhanCong phanCong)
        {
            doanHienTai.AddOrUpdatePhanCong(phanCong).ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    form.Close();
                    (userControl as ChiTietDoan).UpdateData(
                         doanHienTai.GetListPhanCong(),
                         doanHienTai.GetListChiPhi(),
                         KhachDal.GetAll(),
                         doanHienTai.GetListKhach());
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);

                });
            });
        }
        public void onChiTietPhanCong_HuyClick()
        {
            form.Close();
        }

    }
}
/**
 * Quản Lý Đoàn - Khách
 */

namespace DuLich
{
    public partial class ManHinhChinh :  SelectKhach.ISelectKhachListener
    {
        public void onSelectKhach_LuuClick(Doan doanHienTai, List<Khach> danhSachKhachTrongDoanUpdate)
        {
            doanHienTai.DeleteAllKhach();
            doanHienTai.UpdateListDoanKhach(danhSachKhachTrongDoanUpdate).ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    (userControl as ChiTietDoan).UpdateData(
                        doanHienTai.GetListPhanCong(),
                        doanHienTai.GetListChiPhi(),
                        KhachDal.GetAll(),
                        doanHienTai.GetListKhach());
                });
            });
        }
      
    }
}

/**
 * Quản Lý Kho Hàng
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachXuatNhap.IDanhSachXuatNhapListener,ChiTietXuatNhap.IChiTietXuatNhapListener
    {
        ChiTietXuatNhap chiTietXuatNhap;

        private void btn_quanlykhoclick(object sender, EventArgs e)
        {
            showDanhSachXuatNhap();
        }

        public void onDanhSachXuatNhap_SuaClick(Storage storage)
        {
            chiTietXuatNhap = new ChiTietXuatNhap(storage, product_Dal.GetAll(), this);
            chiTietXuatNhap.ShowDialog();
        }

        public void onDanhSachXuatNhap_ThemClick()
        {
            Storage storage = new Storage();
            chiTietXuatNhap = new ChiTietXuatNhap(storage, product_Dal.GetAll(), this);
            chiTietXuatNhap.ShowDialog();
        }

        public void onDanhSachXuatNhap_XoaClick(Storage storage)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa phiếu này không , khi xóa số lượng của thiết bị sẽ được cập nhật lại", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(storage.Product.Amount - storage.Amount < 0)
                {
                    DialogResult a = MessageBox.Show("Số lượng của thiết bị trong kho hiện tại không thể nhỏ hơn số lượng của phiếu nhập này", "", MessageBoxButtons.YesNo);
                    return;
                }
                storage.Delete().ContinueWith(task =>
                {
                    panel_main_content.Invoke((MethodInvoker)delegate
                    {

                        showDanhSachXuatNhap();
                    });
                });
            }

        }

        public void onLuuClick(Storage storage,int difAmount)
        {
            storage.AddOrUpdate(difAmount).ContinueWith(task =>
             {
                 panel_main_content.Invoke((MethodInvoker)delegate
                 {
                     chiTietXuatNhap.Close();
                     showDanhSachXuatNhap();
                 });

             });
        }

     

        public void onHuyChiTietXuatNhapClick()
        {
            chiTietXuatNhap.Close();
        }
    }
}
/**
 *  Quản Lý Khách
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachKhach.IDanhSachKhachListener,ChiTietKhach.IChiTietKhachListener
    {
        ChiTietKhach chiTietKhach;
        private void button2_Click(object sender, EventArgs e)
        {
            userControl = new DanhSachKhach(KhachDal.GetAll(), this);
            panel_main_content.Controls.Clear();
            panel_main_content.Controls.Add(userControl);
        }

        public void onLuuKhachClick(Khach khach)
        {
            Console.WriteLine("luu"+khach.GetHashCode());
            khach.AddOrUpdate().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    chiTietKhach.Close();
                    userControl = new DanhSachKhach(KhachDal.GetAll(), this);
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);
                });
            });
        }

        public void onHuyKhachClick()
        {
            chiTietKhach.Close();
        }

        public void onDanhSachKhach_ThemClick() {
            Khach khach = new Khach();
            Console.WriteLine("new"+khach.GetHashCode());
            chiTietKhach = new ChiTietKhach(khach, this);
            chiTietKhach.ShowDialog();
        }

        public void onDanhSachKhach_SuaClick(Khach khach)
        {
            chiTietKhach = new ChiTietKhach(khach, this);
            chiTietKhach.ShowDialog();
        }

        public void onDanhSachKhach_XoaClick(Khach khach)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa khách với mã là :" + khach.MaKhach, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                khach.Delete().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    userControl = new DanhSachKhach(KhachDal.GetAll(), this);
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);
                });
            });
            }
        }
    }
}
/**
 * Quản Lý Nhân Viên 
 */
namespace DuLich
{
    public partial class ManHinhChinh : DanhSachNhanVien.IDanhSachNhanVienListener,ChiTietNhanVien.IChiTietNhanVienListener{
    ChiTietNhanVien chiTietNhanVien;
     private void btn_quanlynhanvien_Click(object sender, EventArgs e)
    {
        userControl = new DanhSachNhanVien(NhanVienDal.GetAll(), this);
        panel_main_content.Controls.Clear();
        panel_main_content.Controls.Add(userControl);
    }
    public void onDanhSachNhanVien_SuaClick(NhanVien nhanVien)
    {
        chiTietNhanVien = new ChiTietNhanVien(nhanVien, this);
        chiTietNhanVien.ShowDialog();
    }

    public void onDanhSachNhanVien_ThemClick()
    {
       NhanVien nhanVien = new NhanVien();
       chiTietNhanVien = new ChiTietNhanVien(nhanVien, this);
       chiTietNhanVien.ShowDialog();
    }

    public void onDanhSachNhanVien_XoaClick(NhanVien nhanVien)
    {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên với mã là :" + nhanVien.MaNhanVien, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                nhanVien.Delete().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    userControl = new DanhSachNhanVien(NhanVienDal.GetAll(), this);
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);
                });
            });
            }
        }
    public void onChiTietNhanVien_LuuClick(NhanVien nhanVien)
    {
            nhanVien.AddOrUpdate().ContinueWith(task =>
            {
                panel_main_content.Invoke((MethodInvoker)delegate
                {
                    chiTietNhanVien.Close();
                    userControl = new DanhSachNhanVien(NhanVienDal.GetAll(), this);
                    panel_main_content.Controls.Clear();
                    panel_main_content.Controls.Add(userControl);
                });
            });
        }

    public void onChiTietNhanVien_HuyClick()
        {
            chiTietNhanVien.Close();
        }
    }
}

/**
 * Thống Kê 
 */
namespace DuLich
{
    public partial class ManHinhChinh
    {
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            showThongKe();
        }
    }
}