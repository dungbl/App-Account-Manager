using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan
{
    public partial class fMain : Form
    {
        public string lay = "";
        public string cho = "";
        public fMain()
        {
            InitializeComponent();
        }
        public fMain(string chinhanh)
            :this()
        {
            lay = chinhanh;
            //MessageBox.Show(lay.ToString());
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.lbCN.Text = this.lay.ToString();
            cho = this.lbCN.Text.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            fInDsKH f = new QuanLyTaiKhoan.fInDsKH(cho.ToString());

            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fRutTien f = new QuanLyTaiKhoan.fRutTien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fGuiTien f = new QuanLyTaiKhoan.fGuiTien(cho.ToString());

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fReport f = new QuanLyTaiKhoan.fReport();

            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
