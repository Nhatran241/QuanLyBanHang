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
        private List<storage> storage_list;
        private List<product> products;

        public DanhSachXuatNhap()
        {
            InitializeComponent();
        }
        public DanhSachXuatNhap(List<storage> storages_list,List<product> products, IDanhSachXuatNhapListener danhSachXuatNhapListener)
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
            DateTime ngaytu = storage_list.First().createtime;
            DateTime ngayden = storage_list.First().createtime;
            long soluongtu = storage_list.First().amount;
            long soluongden = storage_list.First().amount;

            foreach (storage storage in storage_list)
            {
                if (storage.createtime < ngaytu)
                    ngaytu = storage.createtime;
                if (storage.createtime > ngayden)
                    ngayden = storage.createtime;
                if (storage.amount > soluongtu)
                    soluongtu = storage.amount;
                if (storage.amount < soluongden)
                    soluongden = storage.amount;
                ListViewItem item = new ListViewItem(new string[] {
                    storage.id.ToString(),
                    storage.product.product_name,
                    storage.amount.ToString(),
                    storage.createtime.ToString()
                }, -1);
                lv_product.Items.Add(item);
            }
            
            search1.SetData(products,ngaytu,ngayden,soluongtu,soluongden, this);
        }

        private void initListViewData(List<storage> newlist)
        {
            lv_product.Items.Clear();
            foreach (storage storage in newlist)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    storage.id.ToString(),
                    storage.product.product_name,
                    storage.amount.ToString(),
                    storage.createtime.ToString()
                }, -1);
                lv_product.Items.Add(item);
            }
        }

        public interface IDanhSachXuatNhapListener
        {
            void onDanhSachXuatNhap_SuaClick(storage storage);
            void onDanhSachXuatNhap_ThemClick();
            void onDanhSachXuatNhap_XoaClick(storage storage);
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

        public void onTimKiem(product product, long soluongtu, long soluongden, DateTime ngaytu, DateTime ngayden,bool isNhap, bool isXuat)
        {
            if (product.id != -1)
            {
                    if (isNhap && isXuat)
                    {
                        initListViewData(storage_list.Where(c => c.product.id == product.id
                        && c.createtime >= ngaytu && c.createtime <= ngayden
                        && Math.Abs(c.amount) >= soluongtu && c.amount <= soluongden
                        ).ToList());
                    }
                    else if (isNhap)
                    {
                        initListViewData(storage_list.Where(c => c.product.id == product.id
                        && c.createtime >= ngaytu && c.createtime <= ngayden
                        && c.amount > 0
                        && c.amount >= soluongtu && c.amount <= soluongden
                        ).ToList());
                    }
                    else if (isXuat)
                    {
                        initListViewData(storage_list.Where(c => c.product.id == product.id
                       && c.createtime >= ngaytu && c.createtime <= ngayden
                       && c.amount < 0
                       && Math.Abs(c.amount) >= soluongtu && c.amount <= soluongden
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
                        c.createtime >= ngaytu && c.createtime <= ngayden
                        && Math.Abs(c.amount) >= soluongtu && c.amount <= soluongden
                        ).ToList());
                    }
                    else if (isNhap)
                    {
                        initListViewData(storage_list.Where(c =>
                        c.createtime >= ngaytu && c.createtime <= ngayden
                        && c.amount > 0
                        && c.amount >= soluongtu && c.amount <= soluongden
                        ).ToList());
                    }
                    else if (isXuat)
                    {
                        initListViewData(storage_list.Where(c =>
                       c.createtime >= ngaytu && c.createtime <= ngayden
                       && c.amount < 0
                       && Math.Abs(c.amount) >= soluongtu && c.amount <= soluongden
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
