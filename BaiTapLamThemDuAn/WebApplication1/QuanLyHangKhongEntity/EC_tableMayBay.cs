using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangKhongEntity
{
   public class EC_tableMayBay
    {
        private string maMB;
        private string loaiMB;
        private int tamBay;

        public string MaMB { get => maMB; set => maMB = value; }
        public string LoaiMB { get => loaiMB; set => loaiMB = value; }
        public int TamBay { get => tamBay; set => tamBay = value; }
    }
}
