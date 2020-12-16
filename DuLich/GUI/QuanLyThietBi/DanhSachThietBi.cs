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
        private IDanhSachThietBiChonThietBiListener chonThietBiListener;
        private List<product> product_list;
        private List<catalog> catalog_list;

        public DanhSachThietBi()
        {
            InitializeComponent();
        }
        public DanhSachThietBi(List<product> _products_list, List<catalog> _catalog_list, IDanhSachThietBiListener danhSachThietBiListener)
        {
            InitializeComponent();
            this.danhSachThietBiListener = danhSachThietBiListener;
            this.product_list = _products_list;
            this.catalog_list = _catalog_list;
            InitData();
        }
        public DanhSachThietBi(List<product> _products_list, List<catalog> _catalog_list, IDanhSachThietBiChonThietBiListener chonThietBiListener)
        {
            InitializeComponent();
            this.chonThietBiListener = chonThietBiListener;
            this.product_list = _products_list;
            this.catalog_list = _catalog_list;
            InitData();
        }

        private void InitData()
        {
            if(danhSachThietBiListener == null && chonThietBiListener != null)
            {
                btn_them.Visible = false;
                btn_xoa.Visible = false;
            }


            DateTime ngaytu = product_list.First().createtime;
            DateTime ngayden = product_list.First().createtime;
            long giatu = product_list.First().price;
            long giaden = product_list.First().price;

            foreach (product product in product_list)
            {
                if (product.createtime < ngaytu)
                    ngaytu = product.createtime;
                if (product.createtime > ngayden)
                    ngayden = product.createtime;
                if (product.price > giaden)
                    giaden = product.price;
                if (product.price < giatu)
                    giatu = product.price;
                ListViewItem item = new ListViewItem(new string[] {
                    product.id.ToString(),
                    product.product_name,
                    product.price.ToString("N0")+"đ",
                    product.discountpercent.ToString()+"%",
                    product.PriceAfterDiscount().ToString("N0")+"đ",
                    product.amount.ToString(),
                    product.catalog.catalog_name,
                    product.createtime.ToString(),
                    product.detail
                }, -1);
                lv_product.Items.Add(item);
            }

            search1.SetData(catalog_list,ngaytu,ngayden,giatu,giaden, this);
        }

        private void initListViewData(List<product> newlist)
        {
            lv_product.Items.Clear();
            foreach (product product in newlist)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    product.id.ToString(),
                    product.product_name,
                    product.price.ToString("N0")+"đ",
                    product.discountpercent.ToString()+"%",
                    product.PriceAfterDiscount().ToString("N0")+"đ",
                    product.amount.ToString(),
                    product.catalog.catalog_name,
                    product.createtime.ToString(),
                    product.detail
                }, -1);
                lv_product.Items.Add(item);
            }
        }

        public interface IDanhSachThietBiListener
        {
            void onDanhSachThietBi_DoubleClick(product product);
            void onDanhSachThietBi_ThemClick();
            void onDanhSachThietBi_XoaClick(product product);
        }
        public interface IDanhSachThietBiChonThietBiListener
        {
            void onDanhSachThietBi_DoubleClick(product product);
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            danhSachThietBiListener.onDanhSachThietBi_ThemClick();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_product.SelectedItems.Count <= 0)
                return;
            int position = lv_product.SelectedItems[0].Index;
            danhSachThietBiListener.onDanhSachThietBi_XoaClick(product_list.ToList()[position]);
        }

        private void tourisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void onTimKiem(catalog cat, string ten, long giatu, long giaden, DateTime ngaytu, DateTime ngayden)
        {
            if (!ten.Equals(""))
            {
                if (cat.id == -1)
                {
                    initListViewData(product_list.Where(c => c.product_name.ToLower().Contains(ten)
                        && c.createtime >= ngaytu && c.createtime <=ngayden
                        && c.price >= giatu && c.price <= giaden
                    ).ToList());
                }
                else
                {
                    initListViewData(product_list.Where(c => c.product_name.ToLower().Contains(ten)
                    && c.catalog.id == cat.id
                       && c.createtime >= ngaytu && c.createtime <= ngayden
                       && c.price >= giatu && c.price <= giaden
                   ).ToList());
                }
            }
            else
            {
                if (cat.id == -1)
                {
                    initListViewData(product_list.Where(c => c.createtime >= ngaytu && c.createtime <= ngayden
                        && c.price >= giatu && c.price <= giaden
                    ).ToList());
                }
                else
                {
                    initListViewData(product_list.Where(c => c.catalog.id == cat.id
                       && c.createtime >= ngaytu && c.createtime <= ngayden
                       && c.price >= giatu && c.price <= giaden
                   ).ToList());
                }
            }
        }

        private void lv_product_item_doubleclick(object sender, EventArgs e)
        {
            if (lv_product.SelectedItems.Count <= 0)
                return;
            int position = lv_product.SelectedItems[0].Index;
            if(danhSachThietBiListener != null)
                danhSachThietBiListener.onDanhSachThietBi_DoubleClick(product_list.ToList()[position]);
            if(chonThietBiListener !=null)
                chonThietBiListener.onDanhSachThietBi_DoubleClick(product_list.ToList()[position]);

        }
    }
}
