using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangKhongEntity
{
    public class EC_tableNhanVien
    {
        private string maNV;
        private string tenNV;
        private int luongNV;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int LuongNV { get => luongNV; set => luongNV = value; }
    }
}
