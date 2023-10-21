using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangKhongEntity
{
    public class EC_tableChuyenBay
    {
        private string maCB;
        private string gaDi;
        private string gaDen;
        private string gioDi;
        private string gioDen;
        private int chiPhi;
        private string maMB;
        private string maNV;

        public string MaCB { get => maCB; set => maCB = value; }
        public string GaDi { get => gaDi; set => gaDi = value; }
        public string GaDen { get => gaDen; set => gaDen = value; }
        public string GioDi { get => gioDi; set => gioDi = value; }
        public string GioDen { get => gioDen; set => gioDen = value; }
        public int ChiPhi { get => chiPhi; set => chiPhi = value; }
        public string MaMB { get => maMB; set => maMB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
