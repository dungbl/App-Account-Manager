using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachHangDAO() { }

        public List<KhachHang> LoadRoomList()
        {
            List<KhachHang> KhachHangList = new List<KhachHang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KhachHang");

            foreach (DataRow item in data.Rows)
            {
                KhachHang kh = new KhachHang(item);

                KhachHangList.Add(kh);
            }
            return KhachHangList;
        }
        public List<KhachHang> LoadKhachHang( int id)
        {
            List<KhachHang> KhachHangList = new List<KhachHang>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KhachHang where ID ="+id+"");

            foreach (DataRow item in data.Rows)
            {
                KhachHang kh = new KhachHang(item);

                KhachHangList.Add(kh);
            }
            return KhachHangList;
        }
        public List<KhachHang> GetListKhachHang(string cn)
        {
            List<KhachHang> list = new List<KhachHang>();

            if (cn=="Admin")
            {
                string query = "select * from KhachHang";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    KhachHang KhachHang = new KhachHang(item);
                    list.Add(KhachHang);
                }
                return list;
            }
            else
            {
                string query = "select * from KhachHang where MaCN=N'" + cn + "'";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    KhachHang KhachHang = new KhachHang(item);
                    list.Add(KhachHang);
                }
                return list;
            }
        }
        public List<KhachHang> getCNKH(string cmnd)
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = "select * from KhachHang where CMND = N'" + cmnd + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang KhachHang = new KhachHang(item);
                list.Add(KhachHang);
            }
            return list;
        }

    }
}
