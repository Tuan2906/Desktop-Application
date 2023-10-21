using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongEntity;
namespace QuanLyHangKhongDAL
{
    public class Sql_tableNhanVien
    {
        KetNoiDataMySql ketNoiData = new KetNoiDataMySql();
        public void themDL(EC_tableNhanVien themNV)
        {
            string insertQuery = "INSERT INTO nhanvien(MaNV, Ten, Luong)VALUES(@MaNV, @Ten, @Luong)";

            ketNoiData.ThucThiCauLenhSQL(insertQuery);
            ketNoiData.ganCauLenhSQL("@MaNV", themNV.MaNV);
            ketNoiData.ganCauLenhSQL("@Ten",themNV.TenNV);
            KetNoiDataMySql.dem++;
            ketNoiData.ganCauLenhSQL("@Luong", themNV.LuongNV.ToString());

            
        }
        public void suaDL(EC_tableNhanVien suaNV)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE NHANVIEN SET Ten='" + suaNV.TenNV + "', Luong='" + suaNV.LuongNV +"' where MaNV='"+suaNV.MaNV+"'");
        }
        public void xoaDL(EC_tableNhanVien xoaNhanVien)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"Delete from NHANVIEN WHERE MaNV=" + xoaNhanVien.MaNV);
        }
        public DataTable TaoBang(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select * from NHANVIEN" + dieuKien);
        }
        
    }
}
