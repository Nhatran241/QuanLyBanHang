using System;
using System.Windows.Forms;
using DuLich.BUS;

namespace DuLich.GUI.QuanLyDiaDiem
{
    public partial class ChiTietDiaDiem : Form
    {
        private IChiTietDiaDiemListener chiTietDiaDiemListener;
        private DiaDiem baseDiaDiem;
        private DiaDiem editDiaDiem;
        private bool isEditing = false;
        public ChiTietDiaDiem(DiaDiem diaDiem, IChiTietDiaDiemListener chiTietDiaDiemListener)
        {
            InitializeComponent();
            this.chiTietDiaDiemListener = chiTietDiaDiemListener;
            baseDiaDiem = diaDiem;
            editDiaDiem = new DiaDiem();
            editDiaDiem.Map(diaDiem);
            InitUI();
        }

        private void InitUI()
        {
            if (editDiaDiem.MaDienDiem == 0)
            {
                tb_madiadiem.Text = "Mã tự động";
            }
            else
            {
                tb_madiadiem.Text = editDiaDiem.MaDienDiem.ToString();
                tb_tendiadiem.Text = editDiaDiem.TenDiaDiem.ToString();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Validation(editDiaDiem))
            {
                baseDiaDiem.Map(editDiaDiem);
                chiTietDiaDiemListener.onLuuDiaDiem(baseDiaDiem);
            }
            else
            {
                MessageBox.Show("Tên địa điểm không được để trống hoặc không được trùng");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            chiTietDiaDiemListener.onHuyDiaDiemClick();
        }
        public interface IChiTietDiaDiemListener
        {
            void onLuuDiaDiem(DiaDiem diaDiem);
            void onHuyDiaDiemClick();
        }
        private bool Validation(DiaDiem diaDiem)
        {
            if (diaDiem.TenDiaDiem == null || diaDiem.TenDiaDiem.Equals(""))
                return false;
            if (diaDiem.GetDiaDiemByName(diaDiem.TenDiaDiem) != null)
                return false;
            return true;
        }

    
        private void tb_TenDiaDiem_TextChanged(object sender, EventArgs e)
        {
            editDiaDiem.TenDiaDiem = tb_tendiadiem.Text.Trim();
        }

    }
}
