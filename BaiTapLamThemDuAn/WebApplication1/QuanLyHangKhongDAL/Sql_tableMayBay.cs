using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongEntity;
namespace QuanLyHangKhongDAL
{
    public class Sql_tableMayBay
    {
        KetNoiDataMySql ketNoiData = new KetNoiDataMySql();
        public void themDL(EC_tableMayBay themMayBay)
        {
         
             string insertQuery = "INSERT INTO MAYBAY(MaMB, LoaiMB, TamBay)VALUES(@MaNV, @Ten, @Luong)";

            ketNoiData.ThucThiCauLenhSQL(insertQuery);
            ketNoiData.ganCauLenhSQL("@MaMB", themMayBay.MaMB);
            ketNoiData.ganCauLenhSQL("@LoaiMB",themMayBay.LoaiMB);
            KetNoiDataMySql.dem++;
            ketNoiData.ganCauLenhSQL("@TamBay", themMayBay.TamBay.ToString());

        }
        public void suaDL(EC_tableMayBay suaMB)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE MAYBAY SET LoaiMB=" + suaMB.LoaiMB +"', TamBay=" + suaMB.TamBay + "' where MaMB=" + suaMB.MaMB + "'");
        }
        public void xoaDL(EC_tableMayBay xoaMayBay)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"Delete from MAYBAY WHERE MaMB=" + xoaMayBay.MaMB + "'");

        }
        public DataTable LayDuLieu(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select * from MAYBAY " + dieuKien);
        }
    }
}
