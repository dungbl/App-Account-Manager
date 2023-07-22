using QuanLyTaiKhoan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DAO
{
    public class CNDAO
    {
        private static CNDAO instance;

        public static CNDAO Instance {
            get { if (instance == null) instance = new CNDAO(); return instance; }
            private set { instance = value; }
        }
        private CNDAO() { }

        public List<CN> GetListCN()
        {
            List<CN> list = new List<CN>();

            string query = "select * from ChiNhanh";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                CN chinhanh = new CN(item);
                list.Add(chinhanh);
            }
            return list;
        }
    }
}
