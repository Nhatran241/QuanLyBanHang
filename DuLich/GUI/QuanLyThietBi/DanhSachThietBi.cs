using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.GUI.QuanLyTouris;

namespace DuLich.GUI.QuanLyThietBi
{

    public partial class DanhSachThietBi : UserControl,TimKiemThietBi.ITimKiemThietBiListener
    {
        private IDanhSachThietBiListener danhSachThietBiListener;
        private List<Product> product_list;
        private List<Catalog> catalog_list;

        public DanhSachThietBi()
        {
            InitializeComponent();
        }
        public DanhSachThietBi(List<Product> _products_list, List<Catalog> _catalog_list, IDanhSachThietBiListener danhSachThietBiListener)
        {
            InitializeComponent();
            this.danhSachThietBiListener = danhSachThietBiListener;
            this.product_list = _products_list;
            this.catalog_list = _catalog_list;
            InitData();
        }

        private void InitData()
        {
            DateTime ngaytu = product_list.First().CreateTime;
            DateTime ngayden = product_list.First().CreateTime;
            long giatu = product_list.First().Price;
            long giaden = product_list.First().Price;

            foreach (Product product in product_list)
            {
                if (product.CreateTime < ngaytu)
                    ngaytu = product.CreateTime;
                if (product.CreateTime > ngayden)
                    ngayden = product.CreateTime;
                if (product.Price > giaden)
                    giaden = product.Price;
                if (product.Price < giatu)
                    giatu = product.Price;
            }


            search1.SetData(catalog_list,ngaytu,ngayden,giatu,giaden, this);
            dataGridViewTour.DataSource = product_list;
        }

     
        public interface IDanhSachThietBiListener
        {
            void onDanhSachThietBi_DoubleClick(Product product);
            void onDanhSachThietBi_ThemClick();
            void onDanhSachThietBi_XoaClick(Product product);
        }

        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridViewTour.CurrentCell.RowIndex;
            danhSachThietBiListener.onDanhSachThietBi_DoubleClick(product_list.ToList()[position]);
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            danhSachThietBiListener.onDanhSachThietBi_ThemClick();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int position = dataGridViewTour.CurrentCell.RowIndex;
            danhSachThietBiListener.onDanhSachThietBi_XoaClick(product_list.ToList()[position]);
        }

        private void tourisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void onTimKiem(Catalog cat, string ten, long giatu, long giaden, DateTime ngaytu, DateTime ngayden)
        {
            if (!ten.Equals(""))
            {
                if (cat.ID == -1)
                {
                    dataGridViewTour.DataSource = product_list.Where(c => c.Product_Name.ToLower().Contains(ten)
                        && c.CreateTime >= ngaytu && c.CreateTime <=ngayden
                        && c.Price >= giatu && c.Price <= giaden
                    ).ToList();
                }
                else
                {
                    dataGridViewTour.DataSource = product_list.Where(c => c.Product_Name.ToLower().Contains(ten)
                    && c.Catalog.ID == cat.ID
                       && c.CreateTime >= ngaytu && c.CreateTime <= ngayden
                       && c.Price >= giatu && c.Price <= giaden
                   ).ToList();
                }
            }
            else
            {
                if (cat.ID == -1)
                {
                    dataGridViewTour.DataSource = product_list.Where(c =>c.CreateTime >= ngaytu && c.CreateTime <= ngayden
                        && c.Price >= giatu && c.Price <= giaden
                    ).ToList();
                }
                else
                {
                    dataGridViewTour.DataSource = product_list.Where(c =>c.Catalog.ID == cat.ID
                       && c.CreateTime >= ngaytu && c.CreateTime <= ngayden
                       && c.Price >= giatu && c.Price <= giaden
                   ).ToList();
                }
            }
        }
    }
}
