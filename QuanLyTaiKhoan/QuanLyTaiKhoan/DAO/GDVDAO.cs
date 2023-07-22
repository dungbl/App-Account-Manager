using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class GDVDAO
    {
        private static GDVDAO instance;

        public static GDVDAO Instance
        {
            get { if (instance == null) instance = new GDVDAO(); return instance; }
            private set { instance = value; }
        }
        private GDVDAO() { }

        public List<GDV> GetListGDV(string magdv)
        {
            List<GDV> list = new List<GDV>();

            string query = "select * from GiaoDichVien where MaGDV = '"+magdv+"'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GDV gdv = new GDV(item);
                list.Add(gdv);
            }
            return list;
        }
    }
}
