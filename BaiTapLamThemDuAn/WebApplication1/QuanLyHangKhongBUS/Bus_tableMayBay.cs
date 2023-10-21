using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongDAL;
using QuanLyHangKhongEntity;
using System.Data;
namespace QuanLyHangKhongBUS
{
    public class Bus_tableMayBay
    {
        Sql_tableMayBay sqlMB = new Sql_tableMayBay();
        public void themDL(EC_tableMayBay themMayBay)
        {
            sqlMB.themDL(themMayBay);

        }
        public void suaDL(EC_tableMayBay suaMB)
        {
            sqlMB.suaDL(suaMB);
        }
        public void xoaDL(EC_tableMayBay xoaMayBay)
        {
            sqlMB.xoaDL(xoaMayBay);
        }
        public DataTable LayDuLieu(string dieuKien)
        {
            return sqlMB.LayDuLieu(dieuKien);
        }
    }
}
