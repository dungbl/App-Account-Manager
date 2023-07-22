using QuanLyTaiKhoan.DAO;
using QuanLyTaiKhoan.DTO;
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
    public partial class fInDsKH : Form
    {
        public string lay;

        public fInDsKH()
        {
            InitializeComponent();
            

        }
        public fInDsKH(string chinhanh)
            : this()
        {
            lay = chinhanh;
            //MessageBox.Show(lay.ToString());
            LoadKhachHang();
        }

        void LoadKhachHang()
        {
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.GetListKhachHang(lay);
            cbMaKH.DataSource = listKhachHang;
            cbMaKH.DisplayMember = "ID";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fInDsKH_Load(object sender, EventArgs e)
        {
            this.lbCN.Text = this.lay.ToString();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            tbCmnd.Clear();

            tbDiaChi.Clear();

            tbNgaySinh.Clear();

            tbTen.Clear();

            ComboBox cb = sender as ComboBox;

            if (cbMaKH.SelectedItem == null)
                return;
            KhachHang selected = cbMaKH.SelectedItem as KhachHang;

            int select = selected.Id;
            string IdKhachHang = select.ToString();

            List<KhachHang> listKhachHang = KhachHangDAO.Instance.LoadKhachHang(select);
            foreach (KhachHang item in listKhachHang)
            {
                tbTen.Text = item.HOTEN;

                tbDiaChi.Text = item.DIACHI;

                tbNgaySinh.Text = item.NGAYCAP.ToString();

                tbCmnd.Text = item.Cmnd.ToString();
                
            }

            string soCMND = tbCmnd.Text.ToString();




        }

        private void lbCN_Click(object sender, EventArgs e)
        {

        }

        internal class TruyenChoCha
        {
            private Action<string> loadData;

            public TruyenChoCha(Action<string> loadData)
            {
                this.loadData = loadData;
            }
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
