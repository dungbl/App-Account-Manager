using QuanLyTaiKhoan.DAO;
using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan
{
    public partial class fLogin : Form
    {
        public delegate string TruyenChoCha(string text);
        public TruyenChoCha truyenData;
        public string chiN = "";
        public fLogin()
        {
            InitializeComponent();
            LoadCN();
        }
        
        void LoadCN()
        {
            List<CN> listChinhanh = CNDAO.Instance.GetListCN();
            cbCN.DataSource = listChinhanh;
            cbCN.DisplayMember = "MaCN";


        }


        private void fLogin_Load(object sender, EventArgs e)
        {

        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// ///////////////////////////////////////////////////////
   
        

        public void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            ComboBox cb = sender as ComboBox;

            if (cbCN.SelectedItem == null)
                return;
            CN selected = cbCN.SelectedItem as CN;

            string select = selected.MACN;
            string chinhanh = select;

            chiN = chinhanh;
            //MessageBox.Show(chinhanh);


            if (Login(userName,passWord, chinhanh))
            {
                fMain f = new QuanLyTaiKhoan.fMain(chiN.ToString());

              
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập, mật khẩu hoặc chi nhánh");
            }
        }



        bool Login(String userName, String passWord, string chinhanh)
        {
            return AccountDAO.Instance.Login(userName, passWord, chinhanh);
        }

        public void cbCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
