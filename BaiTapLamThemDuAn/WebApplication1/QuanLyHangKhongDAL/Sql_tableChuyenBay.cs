using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongEntity;
using System.Data;
namespace QuanLyHangKhongDAL
{
   public  class Sql_tableChuyenBay
    {
        KetNoiDataMySql ketNoiData = new KetNoiDataMySql();
        public void themDL(EC_tableChuyenBay themCB)
        {
            ketNoiData.ThucThiCauLenhSQL(@"INSERT INTO ChuyenBay(MaCB, GaDi,GaDen,GioDi,GioDen,MaMB) 
        VALUES('" + themCB.MaCB + "','" + themCB.GaDi + "','" + themCB.GioDen + "','" + themCB.GioDi+  themCB.GioDen + "','"
        +themCB.MaMB +  "')");
            string insertQuery = "INSERT INTO ChuyenBay(MaCB, GaDi,GaDen, GioDi,GioDen,ChiPhi,MaNV,MaMB)VALUES(@MaCB, @GaDi, @GaDen,@GioDi,@GioDen,@ChiPhi,@MaNV,@MaMB)";

            ketNoiData.ThucThiCauLenhSQL(insertQuery);
            ketNoiData.ganCauLenhSQL("@MaCB", themCB.MaCB);
      
            ketNoiData.ganCauLenhSQL("@GaDi", themCB.GaDi);
            ketNoiData.ganCauLenhSQL("@GaDen", themCB.GaDen);
            ketNoiData.ganCauLenhSQL("@GioDi", themCB.GioDi);
            ketNoiData.ganCauLenhSQL("@GioDen", themCB.GioDen);
            ketNoiData.ganCauLenhSQL("@ChiPhi", themCB.ChiPhi.ToString());
            ketNoiData.ganCauLenhSQL("@MaNV", themCB.MaNV);
            KetNoiDataMySql.dem++;
            ketNoiData.ganCauLenhSQL("@MaMB", themCB.MaMB);

        }
        public void suaDL(EC_tableChuyenBay suaDLCB)
        {
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE CHUYENBAY SET GaDi=" + suaDLCB.GaDi + "',GaDen=" + suaDLCB.GaDen + "', GioDi=" + suaDLCB.GioDi + "', GioDen=" + suaDLCB.GioDen + "', MaMB=" + suaDLCB.MaMB + "' where MaCB=N'" + suaDLCB.MaCB + "'");
        }
        public void xoaDL(EC_tableChuyenBay xoaDLCB)
        {
            ketNoiData.ThucThiCauLenhSQL(@"Delete from CHUYENBAY WHERE MaCB=" + xoaDLCB.MaCB + "'");

        }
        public DataTable TaoBang(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select MaCB,GaDi,GaDen,GioDi,GioDen,Round(ChiPhi-0.1*ChiPhi +100000) as giave  from  CHUYENBAY where " + dieuKien);
        }
        public DataTable LayThongTin(string dieuKien)
        {
            return ketNoiData.GetDataTable(dieuKien);
        }
        public DataTable LayThongTinGaDen(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select GaDen from ChuyenBay " + dieuKien+ "Group by GaDen");
        }

        public DataTable LayThongTinKhuHoi(string dieuKien)
        {
            return ketNoiData.GetDataTable(" select A.MaCB,A.GaDi,A.GaDen,A.GioDi,A.GioDen,Round(ChiPhi-0.1*ChiPhi +100000) as giave    from chuyenbay A  " +
                "join("+dieuKien);
        }
    }
}
