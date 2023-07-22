using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class KhachHang
    {
        public KhachHang(int ID, string CMND, string HoTen, string DiaChi, DateTime  NgayCap, string MaCn)
        {
            this.Id = ID;
            this.Cmnd = CMND;
            this.HOTEN = HoTen;
            this.DIACHI = DiaChi;
            this.NGAYCAP = NgayCap;
            this.MACN = MaCn;
        }
        public KhachHang(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Cmnd = row["CMND"].ToString();
            this.HOTEN = row["HoTen"].ToString();
            this.DIACHI = row["DiaChi"].ToString();
            this.NGAYCAP = (DateTime)row["NgayCap"];
            this.MACN = row["MaCn"].ToString();
        }
        private int id;
        public int Id { get => id; set => id = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public string DIACHI { get => dIACHI; set => dIACHI = value; }
        public DateTime NGAYCAP { get => nGAYCAP; set => nGAYCAP = value; }
        public string MACN { get => mACN; set => mACN = value; }

        private string cmnd;

        private string hOTEN;

        private string dIACHI;

        private DateTime nGAYCAP;

        private string mACN;


    }
}
