using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.GUI.QuanLyTouris;

namespace DuLich.GUI.QuanLyKhoHang
{

    public partial class DanhSachXuatNhap : UserControl,TimKiemKhoHang.ITimKiemKhoHangListener
    {
        private IDanhSachXuatNhapListener danhSachXuatNhapListener;
        private List<Storage> storage_list;
        private List<Product> products;

        public DanhSachXuatNhap()
        {
            InitializeComponent();
        }
        public DanhSachXuatNhap(List<Storage> storages_list,List<Product> products, IDanhSachXuatNhapListener danhSachXuatNhapListener)
        {
            InitializeComponent();
            this.danhSachXuatNhapListener = danhSachXuatNhapListener;
            this.storage_list = storages_list;
            this.products = products;
            if(storages_list.Count >0)
                InitData();
        }

        private void InitData()
        {
            DateTime ngaytu = storage_list.First().createTime;
            DateTime ngayden = storage_list.First().createTime;
            long soluongtu = storage_list.First().Amount;
            long soluongden = storage_list.First().Amount;

            foreach (Storage storage in storage_list)
            {
                if (storage.createTime < ngaytu)
                    ngaytu = storage.createTime;
                if (storage.createTime > ngayden)
                    ngayden = storage.createTime;
                if (storage.Amount > soluongtu)
                    soluongtu = storage.Amount;
                if (storage.Amount < soluongden)
                    soluongden = storage.Amount;
                ListViewItem item = new ListViewItem(new string[] {
                    storage.ID.ToString(),
                    storage.Product.Product_Name,
                    storage.Amount.ToString(),
                    storage.createTime.ToString()
                }, -1);
                lv_product.Items.Add(item);
            }
            
            search1.SetData(products,ngaytu,ngayden,soluongtu,soluongden, this);
        }

        private void initListViewData(List<Storage> newlist)
        {
            lv_product.Items.Clear();
            foreach (Storage storage in newlist)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    storage.ID.ToString(),
                    storage.Product.Product_Name,
                    storage.Amount.ToString(),
                    storage.createTime.ToString()
                }, -1);
                lv_product.Items.Add(item);
            }
        }

        public interface IDanhSachXuatNhapListener
        {
            void onDanhSachXuatNhap_SuaClick(Storage storage);
            void onDanhSachXuatNhap_ThemClick();
            void onDanhSachXuatNhap_XoaClick(Storage storage);
        }
      

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_product.SelectedItems.Count <= 0)
                return;
            int position = lv_product.SelectedItems[0].Index;
            danhSachXuatNhapListener.onDanhSachXuatNhap_XoaClick(storage_list.ToList()[position]);
        }

        private void tourisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void onTimKiem(Product product, long soluongtu, long soluongden, DateTime ngaytu, DateTime ngayden,bool isNhap, bool isXuat)
        {
            if (product.ID != -1)
            {
                    if (isNhap && isXuat)
                    {
                        initListViewData(storage_list.Where(c => c.Product.ID == product.ID
                        && c.createTime >= ngaytu && c.createTime <= ngayden
                        && Math.Abs(c.Amount) >= soluongtu && c.Amount <= soluongden
                        ).ToList());
                    }
                    else if (isNhap)
                    {
                        initListViewData(storage_list.Where(c => c.Product.ID == product.ID
                        && c.createTime >= ngaytu && c.createTime <= ngayden
                        && c.Amount > 0
                        && c.Amount >= soluongtu && c.Amount <= soluongden
                        ).ToList());
                    }
                    else if (isXuat)
                    {
                        initListViewData(storage_list.Where(c => c.Product.ID == product.ID
                       && c.createTime >= ngaytu && c.createTime <= ngayden
                       && c.Amount < 0
                       && Math.Abs(c.Amount) >= soluongtu && c.Amount <= soluongden
                       ).ToList());
                    }
                    else
                    {
                        initListViewData(storage_list.Take(0).ToList());
                    }
                    
            }
            else
            {
                    if (isNhap && isXuat)
                    {
                        initListViewData(storage_list.Where(c => 
                        c.createTime >= ngaytu && c.createTime <= ngayden
                        && Math.Abs(c.Amount) >= soluongtu && c.Amount <= soluongden
                        ).ToList());
                    }
                    else if (isNhap)
                    {
                        initListViewData(storage_list.Where(c =>
                        c.createTime >= ngaytu && c.createTime <= ngayden
                        && c.Amount > 0
                        && c.Amount >= soluongtu && c.Amount <= soluongden
                        ).ToList());
                    }
                    else if (isXuat)
                    {
                        initListViewData(storage_list.Where(c =>
                       c.createTime >= ngaytu && c.createTime <= ngayden
                       && c.Amount < 0
                       && Math.Abs(c.Amount) >= soluongtu && c.Amount <= soluongden
                       ).ToList());
                    }
                    else
                    {
                        initListViewData(storage_list.Take(0).ToList());
                    }
                }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            danhSachXuatNhapListener.onDanhSachXuatNhap_ThemClick();
        }

        private void lv_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_product.SelectedItems.Count <= 0)
                return;
            int position = lv_product.SelectedItems[0].Index;
            danhSachXuatNhapListener.onDanhSachXuatNhap_SuaClick(storage_list.ToList()[position]);
        }
    }
}
