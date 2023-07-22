using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord,string chinhanh)
        {
        //string query1 = "SELECT LoaiTK FROM dbo.TaiKhoan WHERE TenDN = N'" + userName + "' AND MatKhau = N'" + passWord + "' ";
            if (userName == "admin"|| userName == "")
            {
                string query = "SELECT * FROM dbo.TaiKhoan WHERE TenDN = N'" + userName + "' AND MatKhau = N'" + passWord + "'";
                DataTable result1 = DataProvider.Instance.ExecuteQuery(query);

                return result1.Rows.Count > 0;
            }
            else
            { 


                string query2 = "SELECT * FROM dbo.TaiKhoan WHERE TenDN = N'" + userName + "' AND MatKhau = N'" + passWord + "'AND MaCN = N'" + chinhanh + "'";
                DataTable result = DataProvider.Instance.ExecuteQuery(query2);

                return result.Rows.Count > 0;
            }

            

        }

        ////////

        
    }
}
