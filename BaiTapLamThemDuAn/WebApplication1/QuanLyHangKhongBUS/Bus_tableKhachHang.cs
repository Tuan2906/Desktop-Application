using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongDAL;
using QuanLyHangKhongEntity;

namespace QuanLyHangKhongBUS
{
   public class Bus_tableKhachHang1
    {
        Sql_tableKhachHang sqlKhacHang = new Sql_tableKhachHang();
        public void themDL(EC_tableKhachHang themKH)
        {
            sqlKhacHang.themDL(themKH);

        }
        public void suaDL(EC_tableKhachHang suaKH)
        {
            sqlKhacHang.suaDL(suaKH);
        }

        public void xoaDL(EC_tableKhachHang xoaKH)
        {
            sqlKhacHang.xoaDL(xoaKH);
        }
        public DataTable LayDuLieuKH(string dieuKien)
        {
            return sqlKhacHang.TaoBang(dieuKien);
        }
        public DataTable LayDuLieuTTKH(int dieuKien)// lay ho va ten, sdt
        {
            return sqlKhacHang.LaythongtinKH(dieuKien);
        }

        
    }
}
