using GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HangHoa : Form
    {
        private Model1 context;
        public HangHoa()
        {
            InitializeComponent();
            context = new Model1();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            List<LoaiHang> dsHangHoa = context.LoaiHangs.ToList();
            List<Hang> dsHH = context.Hangs.ToList();
            DoDuLieuDSHangHoa(dsHangHoa);
            DoDuLieuDSHH(dsHH);
        }
        private void DoDuLieuDSHH(List<Hang> dsHH)
        {
            dgvHangHoa.Rows.Clear();
            foreach (var item in dsHH)
            {
                int index = dgvHangHoa.Rows.Add();
                dgvHangHoa.Rows[index].Cells[0].Value = item.MaHang;
                dgvHangHoa.Rows[index].Cells[1].Value = item.TenHang;
                dgvHangHoa.Rows[index].Cells[2].Value = item.MaLoaiHang;
                dgvHangHoa.Rows[index].Cells[3].Value = item.SoLuong;
                dgvHangHoa.Rows[index].Cells[4].Value = item.DonGiaBan;
               
                
                dgvHangHoa.Rows[index].Cells[5].Value = item.MaLoaiHang;
            }
        }
        private void DoDuLieuDSHangHoa(List<LoaiHang> dsHangHoa)
        {
            cboLoaiHang.DataSource = dsHangHoa;
            cboLoaiHang.ValueMember = "MaLoaiHang";
            cboLoaiHang.DisplayMember = "TenLoaiHang";
        }
        private bool KiemTraRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Chỉ nhập khoảng trắng đầu dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(cboLoaiHang.Text))
            {
                MessageBox.Show("Không được để trống loại hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiHang.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Chỉ nhập khoảng trắng đầu dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonGiaBan.Text))
            {
                MessageBox.Show("Chỉ nhập khoảng trắng đầu dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBan.Focus();
                return false;
            }
            return true;
        }
    }
}
