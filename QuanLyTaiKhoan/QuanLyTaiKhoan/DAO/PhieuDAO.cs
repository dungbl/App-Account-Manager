using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyTaiKhoan.DAO
{
    public class PhieuDAO
    {
        private static PhieuDAO instance;

        public static PhieuDAO Instance
        {
            get { if (instance == null) instance = new PhieuDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuDAO() { }

        public List<Phieu> GetListPhieu(string cmnd)
        {
            List<Phieu> list = new List<Phieu>();

            string query = "select * from Phieu where CMND = N'"+cmnd+"'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phieu phieu = new Phieu(item);
                list.Add(phieu);
            }
            return list;
        }
        public List<Phieu> GetListPhieuByMP(string MaPhieu)
        {
            List<Phieu> list = new List<Phieu>();

            string query = "select * from Phieu where MaPhieu = N'" + MaPhieu + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phieu phieu = new Phieu(item);
                list.Add(phieu);
            }
            return list;
        }

        public List<Phieu> GetPhieuCuoi()
        {
            List<Phieu> list = new List<Phieu>();

            string query = "select top(1) * from Phieu order by ID DESC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phieu phieu = new Phieu(item);
                list.Add(phieu);
            }
            return list;
        }
        public void InsertPhieu(int id,string MaPhieu, string CMND, string MaDV, string NgayGui, float LaiSuat, 
            float SoTienGui,string ngaydenhan, string magdv_g, string ngayrut, float tienlai ,string magdv_r)
        {
            string query = "INSERT INTO dbo.Phieu VALUES ( '" + id + "' , '" + MaPhieu + "' ,'" + CMND 
                + "', '" + MaDV + "','" + NgayGui + "', '" + LaiSuat + "' , '" + SoTienGui + "' , '" + ngaydenhan +
                "', '" + magdv_g + "','" + ngayrut + "', '" + tienlai + "', '" + magdv_r + "')";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeletePhieu(string MaPhieu)
        {
            string query = "delete dbo.Phieu where MaPhieu = '" + MaPhieu+"'";

            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdatePhieu(int id, string MaPhieu, string CMND, string MaDV, string NgayGui, float LaiSuat,
            float SoTienGui, string ngaydenhan, string magdv_g, string ngayrut, float tienlai, string magdv_r,string maphieu)
        {
            string query = "UPDATE dbo.Phieu set ID ='"+ id + "' , MaPhieu = '" + 
                MaPhieu + "' ,CMND = '" + CMND
                + "', MaDV = '" + MaDV + "', NgayGui = '" + NgayGui + "', LaiSuat = '" + 
                LaiSuat + "' , SoTienGui = '" + SoTienGui + "' , NgayDeNhan = '" + ngaydenhan +
                "', MaGDV_LPG = '" + magdv_g + "', NgayRut = '" + ngayrut + "', TienLai = '" + 
                tienlai + "', MaGDV_LPR = '" + magdv_r + "' WHERE MaPhieu = '"+maphieu+"'";

            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
