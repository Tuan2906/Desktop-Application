using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangKhongEntity
{
   public  class EC_ThongTinMuaVe
    {
        private string MaCB;
        private int MAKH;
        private int MaMB;
        private string tinhtrang;
        private double sotien;
        private string soghe;
        private string thue;
        private string soluongmua;
        private string loaive;
        public string MaCB1 { get => MaCB; set => MaCB = value; }
        public int MAKH1 { get => MAKH; set => MAKH = value; }
        public int MaMB1 { get => MaMB; set => MaMB = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public double Sotien { get => sotien; set => sotien = value; }
        public string Soghe { get => soghe; set => soghe = value; }
        public string Thue { get => thue; set => thue = value; }
        public string Soluongmua { get => soluongmua; set => soluongmua = value; }
        public string Loaive { get => loaive; set => loaive = value; }
    }
}
