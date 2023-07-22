using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiKhoan.DTO
{
    public class Phieu
    {
        public Phieu(int ID, string MaPhieu, string CMND, string MaDV, DateTime NgayGui, 
            double LaiSuat, double SoTienGui, DateTime NgayDeNhan, string MaGDV_LPG, DateTime NgayRut,
            double TienLai, string MaGDV_LPR)
        {
            this.Id = ID;
            this.MAphieu = MaPhieu;
            this.CMnd = CMND;
            this.MAdv = MaDV;
            this.NGaygui = NgayGui;
            this.LAisuat = LaiSuat;
            this.SOtiengui = SoTienGui;
            this.NGaydenhan = NgayDeNhan;
            this.MAgdv_lpg = MaGDV_LPG;
            this.NGayrut = NgayRut;
            this.TIenlai = TienLai;
            this.MAgdv_lpr = MaGDV_LPR;
        }

        public Phieu(DataRow row)
        {
            

            this.Id = (int)row["ID"];
            this.MAphieu = (string)row["MaPhieu"];
            this.CMnd = (string)row["CMND"];
            this.MAdv = (string)row["MaDV"];
            this.NGaygui = (DateTime)row["NgayGui"];
            this.LAisuat = (double)row["LaiSuat"];
            this.SOtiengui = (double)row["SoTienGui"];
            this.NGaydenhan = (DateTime)row["NgayDeNhan"];
            this.MAgdv_lpg = (string)row["MaGDV_LPG"];
            this.NGayrut = (DateTime)row["NgayRut"];
            this.TIenlai = (double)row["TienLai"];
            this.MAgdv_lpr = (string)row["MaGDV_LPR"];
        }

        private int id;
        private string mAphieu;
        private string cMnd;
        private string mAdv;
        private DateTime nGaygui;
        private double lAisuat;
        private double sOtiengui;
        private DateTime nGaydenhan;
        private string mAgdv_lpg;
        private DateTime nGayrut;
        private double tIenlai;
        private string mAgdv_lpr;

        public int Id { get => id; set => id = value; }
        public string MAphieu { get => mAphieu; set => mAphieu = value; }
        public string CMnd { get => cMnd; set => cMnd = value; }
        public string MAdv { get => mAdv; set => mAdv = value; }
        public DateTime NGaygui { get => nGaygui; set => nGaygui = value; }
        public double LAisuat { get => lAisuat; set => lAisuat = (double)value; }
        public double SOtiengui { get => sOtiengui; set => sOtiengui = value; }
        public DateTime NGaydenhan { get => nGaydenhan; set => nGaydenhan = value; }
        public string MAgdv_lpg { get => mAgdv_lpg; set => mAgdv_lpg = value; }
        public DateTime NGayrut { get => nGayrut; set => nGayrut = value; }
        public double TIenlai { get => tIenlai; set => tIenlai = value; }
        public string MAgdv_lpr { get => mAgdv_lpr; set => mAgdv_lpr = value; }
    }
}
