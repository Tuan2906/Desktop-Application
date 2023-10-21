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
    public class Bus_tableNhanVien
    {
        Sql_tableNhanVien sql_NV = new Sql_tableNhanVien();
        public void themDL(EC_tableNhanVien themNV)
        {
            sql_NV.themDL(themNV);
            
        }
        public void suaDL(EC_tableNhanVien suaNV)
        {
            sql_NV.suaDL(suaNV);
        }
        public void xoaDL(EC_tableNhanVien xoaNhanVien)
        {
            sql_NV.xoaDL(xoaNhanVien);

        }
        public DataTable TaoBang(string dieuKien)
        {
            return sql_NV.TaoBang(dieuKien);
        }
    }
}
