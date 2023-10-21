using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongEntity;
using System.Data;
namespace QuanLyHangKhongDAL
{
    public class Sql_tableChungNhan
    {
        KetNoiDataMySql ketNoiData = new KetNoiDataMySql();
        public int kiemtra(string manv, string mamb)
        {
            return int.Parse(ketNoiData.Getvalue("select Count(*) from chungnhan where MaNV='" + manv + "'and MaMB=N'" + mamb + "'"));// KIEM TRA XEM CO PILOT 
        }
        public void themDL(EC_tableChungNhan themDLCN)
        {
            string q = @"INSERT INTO CHUNGHNHAN(MaNV,MAMB) 
        VALUES(N'" + themDLCN.MaNV + "',N'" + themDLCN.MaMB + "')";
            ketNoiData.ThucThiCauLenhSQL(q);

        }
        public void suaDL(EC_tableChungNhan suaDLCN)
        {
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE CHUNGNHAN SET MaNV=N'" + suaDLCN.MaNV + "', MaMB =N'" + suaDLCN.MaMB + "' where MaNV=N'" + suaDLCN.MaNV + "'" + "' and MAMB=N'" + suaDLCN.MaMB + "'");
        }
        public void xoaDL(EC_tableChungNhan xoaDLCN)
        {
            ketNoiData.ThucThiCauLenhSQL(@"Delete from CHUNGNHAN WHERE MaNV=N'" + xoaDLCN.MaNV + "'and MAMB=N'" + xoaDLCN.MaMB + "'");

        }
        public DataTable TaoBang(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select * from chungnhan " + dieuKien);
        }
        public DataTable GetinfoPilot(string dk)
        {
            return ketNoiData.GetDataTable("Select maNV,tenNV, from nhanvien " + dk);
        }
    }
}
