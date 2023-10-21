using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using QuanLyHangKhongDAL;
using QuanLyHangKhongEntity;
using System.Data;
namespace QuanLyHangKhongBUS
{
    public class Bus_tableChuyenBay
    {
        Sql_tableChuyenBay  sqlCB = new Sql_tableChuyenBay();
        public void themDL(EC_tableChuyenBay themCB)
        {
            sqlCB.themDL(themCB);

        }
        public void suaDL(EC_tableChuyenBay suaDLCB)
        {
            sqlCB.suaDL(suaDLCB);
        }
        public void xoaDL(EC_tableChuyenBay xoaDLCB)
        {
            sqlCB.xoaDL(xoaDLCB);

        }
        public DataTable TaoBang(string dieuKien)
        {
            return sqlCB.TaoBang(dieuKien);
        }
        public DataTable LayThongTin(string dieuKien)
        {
            return sqlCB.LayThongTin(dieuKien);
        }
        public DataTable LayThongTinGaDen(string dieukien)
        {
            return sqlCB.LayThongTinGaDen(dieukien);
        }
        public DataTable LayThongTinKhuHoi(string dieukien)
        {
            return sqlCB.LayThongTinKhuHoi(dieukien);
        }
    }
}
