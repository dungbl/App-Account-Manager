using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class GDV
    {
        public GDV(int ID, string MaGDV, string HoTen, string DiaChi, string MaCN)
        {
            this.Id = ID;
            this.MAGDV = MaGDV;
            this.HOTEN = HoTen;
            this.DIACHI = DiaChi;
            this.MACN = MaCN;
        }

        public GDV(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.MAGDV = (string)row["MaGDV"];
            this.HOTEN = (string)row["HoTen"];
            this.DIACHI = (string)row["DiaChi"];
            this.MACN = (string)row["MaCN"];
        }

        private int id;

        private string mAGDV;

        private string hOTEN;

        private string dIACHI;

        private string mACN;

        public int Id { get => id; set => id = value; }
        public string MAGDV { get => mAGDV; set => mAGDV = value; }
        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public string DIACHI { get => dIACHI; set => dIACHI = value; }
        public string MACN { get => mACN; set => mACN = value; }
    }
}
