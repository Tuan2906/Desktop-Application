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
    public class Bus_tableChungNhan
    {
        Sql_tableChungNhan sqlCN = new Sql_tableChungNhan();
        public int kiemtra(string manv, string mamb)
        {
            return sqlCN.kiemtra(manv, mamb);
        }
        public void themDL(EC_tableChungNhan themDLCN)
        {
            sqlCN.themDL(themDLCN);

        }
        public void suaDL(EC_tableChungNhan suaDLCN)
        {
            sqlCN.suaDL(suaDLCN);
        }
        public void xoaDL(EC_tableChungNhan xoaDLCN)
        {
            sqlCN.xoaDL(xoaDLCN);

        }
        public DataTable TaoBang(string dieuKien)
        {
            return sqlCN.TaoBang(dieuKien);
        }
        public DataTable GetinfoPilot(string dk)
        {
            return sqlCN.GetinfoPilot(dk);
        }
    }
}
