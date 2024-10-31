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
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            BanHang f = new BanHang();
            f.Show();
            //this.Hide();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            f.Show();
           // this.Hide();

        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
