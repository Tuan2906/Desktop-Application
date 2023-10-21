using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongEntity;
using System.Data;
namespace QuanLyHangKhongDAL
{
    public class Sql_tableKhachHang
    {
        KetNoiDataMySql ketNoiData = new KetNoiDataMySql();
        public void themDL(EC_tableKhachHang themKH)
        {
            string insertQuery = "INSERT INTO khachang(MAKH, TenKH, SDT, gioitinh,ghichu,CCCD, NgaySinh)VALUES(@MAKH, @TenKH, @SDT,@gioitinh,@ghichu,@CCCD, @NgaySinh)";

            ketNoiData.ThucThiCauLenhSQL(insertQuery);
            ketNoiData.ganCauLenhSQL("@MAKH",themKH.MAKH1.ToString());
            ketNoiData.ganCauLenhSQL("@TenKH", themKH.TenKH1);
            ketNoiData.ganCauLenhSQL("@SDT", themKH.SDT1);
            ketNoiData.ganCauLenhSQL("@gioitinh", themKH.GoiTinh);
            ketNoiData.ganCauLenhSQL("@ghichu", themKH.GhChu);
            ketNoiData.ganCauLenhSQL("@CCCD", themKH.CCCD1);
            KetNoiDataMySql.dem++;
            ketNoiData.ganCauLenhSQL("@NgaySinh", themKH.NgaySinh1);
            KetNoiDataMySql.dem = 0;
        }
        public void suaDL(EC_tableKhachHang suaKH)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE khachang SET TenKH='" + suaKH.TenKH1 + "',SDT='" + suaKH.SDT1 + "',gioitinh='" + suaKH.GoiTinh+ "',ghichu='" + suaKH.GhChu  + "' where MAKH='" + suaKH.MAKH1 + "'");
        }
        public void xoaDL(EC_tableKhachHang xoaKH)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"Delete from khachang WHERE MAKH=" + xoaKH.MAKH1);
        }
        public DataTable TaoBang(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select * from khachang" + dieuKien);
        }
        public DataTable LaythongtinKH(int dieuKien)
        {
            return ketNoiData.GetDataTable("Select TenKH, SDT from khachang where MAKH=" + dieuKien);
        }


    }
}
