using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyTouris
{
    public partial class DanhSachGia : UserControl
    {
        private IDanhSachGiaListener danhSachGiaListener;
        private List<Gia> gias;
        private Tour currentTour;
        public DanhSachGia(Tour currentTouris,List<Gia> gias, IDanhSachGiaListener danhSachGiaListener)
        {
            InitializeComponent();
            this.danhSachGiaListener = danhSachGiaListener;
            this.gias = gias;
            this.currentTour = currentTouris;
            InitData(gias);
        }
        private void InitData(IEnumerable<Gia> gias)
        {
            dataGridViewGia.DataSource = gias;
        }


        private void GiaClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GiaDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridViewGia.CurrentCell.RowIndex;
            danhSachGiaListener.onDanhSachGiaSuaClick(gias.ToList()[position]);
        }

        private void btn_them_gia_Click(object sender, EventArgs e)
        {
            danhSachGiaListener.onDanhSachGiaThemClick(currentTour);
        }
     

        private void btn_sua_gia_Click(object sender, EventArgs e)
        {
            if(dataGridViewGia.CurrentCell != null)
            {
                int position = dataGridViewGia.CurrentCell.RowIndex;
                danhSachGiaListener.onDanhSachGiaSuaClick(gias.ToArray()[position]);
            }
        }

        private void btn_xoa_gia_Click(object sender, EventArgs e)
        {
            if (dataGridViewGia.CurrentCell != null)
            {
                int position = dataGridViewGia.CurrentCell.RowIndex;
                danhSachGiaListener.onDanhSachGiaXoaClick(currentTour,gias.ToArray()[position]);
            }
        }
        public interface IDanhSachGiaListener
        {
            void onDanhSachGiaThemClick(Tour tourHienTai);
            void onDanhSachGiaSuaClick(Gia gia);
            void onDanhSachGiaXoaClick(Tour tourHienTai,Gia gia);
        }

    }
}
