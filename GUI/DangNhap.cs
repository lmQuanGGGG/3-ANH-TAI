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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLyBanHang q = new QuanLyBanHang();
            if (txtTaiKhoan.Text == "lmquang04" && txtMatKhau.Text == "1234")
            {
                q.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản vui lòng nhập lại !", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';  // Hiện mật khẩu
            }
            else
            {
                 txtMatKhau.PasswordChar = '*';  // Ẩn mật khẩu
            }
        }

        private void eye2_Click(object sender, EventArgs e)
        {

        }

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            BanHang bh = new BanHang();
            if (txtTaiKhoan.Text == "LVTL04" && txtMatKhau.Text == "1234")
            {
                bh.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản vui lòng nhập lại !", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
