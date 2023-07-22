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
    public partial class fGuiTien : Form
    {
        public string lay;
        public fGuiTien()
        {
            InitializeComponent();
        }
        public fGuiTien(string chinhanh)
            : this()
        {
            lay = chinhanh;
            //MessageBox.Show(lay.ToString());
            LoadKhachHang();
        }

        void LoadKhachHang()
        {
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.GetListKhachHang(lay);
            cbKH.DataSource = listKhachHang;
            cbKH.DisplayMember = "ID";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fMain f = new QuanLyTaiKhoan.fMain();
            this.Close();
        }

        private void fGuiTien_Load(object sender, EventArgs e)
        {

        }

        private void btChon_Click(object sender, EventArgs e)
        {
            tbCmnd.Clear();

            tbDiaChi.Clear();


            tbTen.Clear();

            ComboBox cb = sender as ComboBox;

            if (cbKH.SelectedItem == null)
                return;
            KhachHang selected = cbKH.SelectedItem as KhachHang;

            int select = selected.Id;
            string IdKhachHang = select.ToString();

            List<KhachHang> listKhachHang = KhachHangDAO.Instance.LoadKhachHang(select);
            foreach (KhachHang item in listKhachHang)
            {
                tbTen.Text = item.HOTEN;

                tbDiaChi.Text = item.DIACHI;

                dtNgayCap.Text = item.NGAYCAP.ToString();

                tbCmnd.Text = item.Cmnd.ToString();
            }

            string select2 = tbCmnd.Text.ToString();
            
            List<Phieu> listPhieu = PhieuDAO.Instance.GetListPhieu(select2);
            cbPhieu.DataSource = listPhieu;
            cbPhieu.DisplayMember = "MaPhieu";

           
        }

        private void cbPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phieu selected2 = cbPhieu.SelectedItem as Phieu;

            string select3 = selected2.MAphieu;

            List<Phieu> listPhieu2 = PhieuDAO.Instance.GetListPhieuByMP(select3);
            foreach (Phieu item in listPhieu2)
            {
                
                dtNgayCap.Text = item.NGaygui.ToString();

                tbMaDV.Text = item.MAdv;

                tbG.Text = item.MAgdv_lpg;

                tbR.Text = item.MAgdv_lpr;

                //MessageBox.Show(item.MAdv);

                switch (item.MAdv.ToString())
                {
                    case "DV1  ":
                        tbTenDV.Text = "Dịch vụ có kì hạn 3 tháng";
                        tbKyHan.Text = "3";
                        tbLaiSuat.Text = "0.005";
                        break;

                    case "DV2  ":
                        tbTenDV.Text = "Dịch vụ có kì hạn 6 tháng";
                        tbKyHan.Text = "6";
                        tbLaiSuat.Text = "0.010";
                        break;

                    case "DV3  ":
                        tbTenDV.Text = "Dịch vụ có kì hạn 1 năm";
                        tbKyHan.Text = "12";
                        tbLaiSuat.Text = "0.020";
                        break;

                    case "DV4  ":
                        tbTenDV.Text = "Dịch vụ có kì hạn 2 năm";
                        tbKyHan.Text = "24";
                        tbLaiSuat.Text = "0.030";
                        break;

                    case "DV5  ":
                        tbTenDV.Text = "Dịch vụ có kì hạn 3 năm";
                        tbKyHan.Text = "36";
                        tbLaiSuat.Text = "0.050";
                        break;
                }

                dtDH.Text = item.NGaydenhan.ToString();
                tbSoTienGui.Text = item.SOtiengui.ToString();
                //tbCmnd.Text = item.Cmnd.ToString();
            }
            //MessageBox.Show(select3);
            //MessageBox.Show(cbPhieu.SelectedItem.DisplayMember.ToString());

        }

        private void tbKyHan_TextChanged(object sender, EventArgs e)
        {

        }
        string cuoi;

        string cnKH;

        string magdv1;

        string magdv2;
        private void button1_Click(object sender, EventArgs e)
        {
            string NgayGui = dtGui.Value.ToShortDateString();

            string NgayDenHan = dtDH.Value.ToShortDateString();

            string Ten = tbTen.Text;

            string cmnd = tbCmnd.Text;

            string ngayLap = dtNgayCap.Value.ToShortDateString();

            string diachi = tbDiaChi.Text;

            string maDv = tbMaDV.Text;

            float soTien = float.Parse(tbSoTienGui.Text);

            string gdvg = tbG.Text;

            string gdvr = tbR.Text;

            string ngayrut = NgayDenHan;

            double laisuat = 0;

            if (ngayLap == "" || NgayGui == "" || NgayDenHan == "" || Ten == "" || cmnd == "" || maDv == ""  || ngayLap == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin, vui lòng nhập lại");
            }
            else

            {
                List<KhachHang> CNKH = KhachHangDAO.Instance.getCNKH(cmnd);

                foreach (KhachHang item in CNKH)
                {
                    cnKH = item.MACN.ToString().Trim();
                }
                //MessageBox.Show(cnKH);
                List<GDV> GDV1 = GDVDAO.Instance.GetListGDV(gdvg);

                foreach (GDV item in GDV1)
                {
                    magdv1 = item.MACN.ToString().Trim();
                }
                List<GDV> GDV2 = GDVDAO.Instance.GetListGDV(gdvr);

                foreach (GDV item in GDV2)
                {
                    magdv2 = item.MACN.ToString().Trim();
                }
                //MessageBox.Show(magdv2);
                if (cnKH != magdv1 || cnKH != magdv2)
                {
                    MessageBox.Show("Nhập sai mã giao dịch viên, khách hàng chi nhánh nào thì giao " +
                        "dịch viên chi nhánh đó!");
                }
                else
                {
                    // code tính toán
                    List<Phieu> phieucuoi = PhieuDAO.Instance.GetPhieuCuoi();

                    foreach (Phieu item in phieucuoi)
                    {
                        cuoi = item.MAphieu.ToString();
                    }
                    int a = Int32.Parse(cuoi.Substring(1, 2));
                    a = a + 1;
                    int d = a;
                    string b = cuoi.Substring(0, 1);

                    string c = b + a.ToString();
                    //MessageBox.Show(c);

                    switch (maDv)
                    {
                        case "DV1":
                            laisuat = 0.005;
                            break;

                        case "DV2":

                            laisuat = 0.010;
                            break;

                        case "DV3":

                            laisuat = 0.020;
                            break;

                        case "DV4":

                            laisuat = 0.030;
                            break;

                        case "DV5":

                            laisuat = 0.050;
                            break;
                    }


                    PhieuDAO.Instance.InsertPhieu(d, c, cmnd, maDv, NgayGui,
                        Convert.ToSingle(laisuat), soTien, NgayDenHan, gdvg, ngayrut, 0, gdvr);
                    MessageBox.Show("Thêm thành công, bạn cần bấm lại nút 'Chọn' để load lại form");
                }
                
                
                //double TienLai = LaiSuat*
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cbPhieu.SelectedItem == null)
                return;
            Phieu selected = cbPhieu.SelectedItem as Phieu;

            string select = selected.MAphieu;
            //string chinhanh = select;
            //MessageBox.Show(select.ToString());
            PhieuDAO.Instance.DeletePhieu(select);
            MessageBox.Show("Xóa thành công, bạn cần bấm lại nút 'Chọn' để load lại form");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NgayGui = dtGui.Value.ToShortDateString();

            string NgayDenHan = dtDH.Value.ToShortDateString();

            string Ten = tbTen.Text;

            string cmnd = tbCmnd.Text;

            string ngayLap = dtNgayCap.Value.ToShortDateString();

            string diachi = tbDiaChi.Text;

            string maDv = tbMaDV.Text;

            float soTien = float.Parse(tbSoTienGui.Text);

            string gdvg = tbG.Text;

            string gdvr = tbR.Text;

            string ngayrut = NgayDenHan;

            double laisuat = 0;

            if (ngayLap == "" || NgayGui == "" || NgayDenHan == "" || Ten == "" || cmnd == "" || maDv == "" || ngayLap == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin, vui lòng nhập lại");
            }
            else

            {
                List<KhachHang> CNKH = KhachHangDAO.Instance.getCNKH(cmnd);

                foreach (KhachHang item in CNKH)
                {
                    cnKH = item.MACN.ToString().Trim();
                }
                //MessageBox.Show(cnKH);
                List<GDV> GDV1 = GDVDAO.Instance.GetListGDV(gdvg);

                foreach (GDV item in GDV1)
                {
                    magdv1 = item.MACN.ToString().Trim();
                }
                List<GDV> GDV2 = GDVDAO.Instance.GetListGDV(gdvr);

                foreach (GDV item in GDV2)
                {
                    magdv2 = item.MACN.ToString().Trim();
                }
                //MessageBox.Show(magdv2);
                if (cnKH != magdv1 || cnKH != magdv2)
                {
                    MessageBox.Show("Nhập sai mã giao dịch viên, khách hàng chi nhánh nào thì giao " +
                        "dịch viên chi nhánh đó!");
                }
                else
                {
                    // code tính toán
                    ComboBox cb = sender as ComboBox;

                    if (cbPhieu.SelectedItem == null)
                        return;
                    Phieu selected = cbPhieu.SelectedItem as Phieu;

                    string select = selected.MAphieu;
                    // code tính toán 2
                    
                    int a = Int32.Parse(select.Substring(1, 2));
                    a = a;
                    int d = a;
                    string b = select.Substring(0, 1);

                    string c = b + a.ToString();
                    //MessageBox.Show(c);

                    switch (maDv)
                    {
                        case "DV1":
                            laisuat = 0.005;
                            break;

                        case "DV2":

                            laisuat = 0.010;
                            break;

                        case "DV3":

                            laisuat = 0.020;
                            break;

                        case "DV4":

                            laisuat = 0.030;
                            break;

                        case "DV5":

                            laisuat = 0.050;
                            break;
                    }



                    PhieuDAO.Instance.UpdatePhieu(d, c, cmnd, maDv, NgayGui,
                        Convert.ToSingle(laisuat), soTien, NgayDenHan, gdvg, ngayrut, 0, gdvr,select);
                    MessageBox.Show("Sửa thành công, bạn cần bấm lại nút 'Chọn' để load lại form");
                }


                //double TienLai = LaiSuat*
            }
        }
    }
}
