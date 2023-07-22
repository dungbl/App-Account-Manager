using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class CN
    {
        public CN(int ID, string MaCn, string TenCN, string DiaChi)
            { 
                this.Id = ID;
                this.MACN = MaCn;
            this.TENCN = TenCN;
            this.DIACHI = DiaChi;
            }

        public CN(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.MACN = (string)row["MaCN"];
            this.TENCN = (string)row["TenCN"];
            this.DIACHI = (string)row["DiaChi"];
        }

        private int id;

        public int Id { get => id; set => id = value; }
        public string MACN { get => mACN; set => mACN = value; }
        public string TENCN { get => tENCN; set => tENCN = value; }
        public string DIACHI { get => dIACHI; set => dIACHI = value; }

        private string mACN;

        private string tENCN;

        private string dIACHI;
    }
}
