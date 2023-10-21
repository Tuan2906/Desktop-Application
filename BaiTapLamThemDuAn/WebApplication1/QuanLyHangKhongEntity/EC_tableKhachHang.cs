using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangKhongEntity
{
   public class EC_tableKhachHang
    {
         private int MAKH;
        private string TenKH;
        private string SDT;
        private string goiTinh;
        private string ghChu;
        private string NgaySinh;
        private string CCCD;
   
        public int MAKH1 { get => MAKH; set => MAKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string GoiTinh { get => goiTinh; set => goiTinh = value; }
        public string GhChu { get => ghChu; set => ghChu = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
    }
}
