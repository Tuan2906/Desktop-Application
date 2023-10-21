using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHangKhongEntity;
namespace QuanLyHangKhongDAL
{
   public class Sql_tableThongTinMuaVe
    {
        KetNoiDataMySql ketNoiData = new KetNoiDataMySql();
        public void themDL(EC_ThongTinMuaVe themVeMua)
        {
            string insertQuery = "INSERT INTO muave(MaCB, MAKH, tinhtrang,sotien,thue,soluongmua,soGhe,loaive)VALUES(@MaCB,@MAKH, @tinhtrang, @sotien,@thue,@soluongmua,@soGhe,@loaive)";

            ketNoiData.ThucThiCauLenhSQL(insertQuery);
            ketNoiData.ganCauLenhSQL("@MaCB", themVeMua.MaCB1);
            ketNoiData.ganCauLenhSQL("@MaKH", themVeMua.MAKH1.ToString());
            ketNoiData.ganCauLenhSQL("@tinhtrang", themVeMua.Tinhtrang);
            ketNoiData.ganCauLenhSQL("@sotien", themVeMua.Sotien.ToString()); 
            ketNoiData.ganCauLenhSQL("@thue", themVeMua.Thue); 
            ketNoiData.ganCauLenhSQL("@soluongmua", themVeMua.Soluongmua);
            ketNoiData.ganCauLenhSQL("@soGhe", themVeMua.Soghe);
            KetNoiDataMySql.dem++;
            ketNoiData.ganCauLenhSQL("@loaive", themVeMua.Soghe);
            KetNoiDataMySql.dem = 0;
        }
        public void suaDL(EC_ThongTinMuaVe suaVeMua)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE muave SET MaCB='" + suaVeMua.MaCB1 + "', tinhtrang='" + suaVeMua.Tinhtrang + "' where MAKH='" +suaVeMua.MAKH1 + "'");
        }
        public void updatesoGhe(EC_ThongTinMuaVe suaSoGhe)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"UPDATE muave SET soGhe='" + suaSoGhe.Soghe + "', tinhtrang='" + suaSoGhe.Tinhtrang + "' where MAKH='" + suaSoGhe.MAKH1 + "'and MACB='" + suaSoGhe.MaCB1+"'");
        }
        public void xoaDL(EC_ThongTinMuaVe xoaVeMua)
        {
            KetNoiDataMySql.demSua++;
            ketNoiData.ThucThiCauLenhSQL(@"Delete from muave WHERE MaCB=" + xoaVeMua.MaCB1+",and MAKH="+xoaVeMua.MAKH1);
        }
        public DataTable TaoBang(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select * from muave " + dieuKien);
        }
        public DataTable LaySoGhe(string dieuKien)
        {
            return ketNoiData.GetDataTable("Select soGhe from muave where MaCB like '" + dieuKien+ "'");
        }
        public DataTable LaytienTVe(int dieuKien)
        {
            return ketNoiData.GetDataTable("select macb,MAKH,sotien-thue as thanhtien,thue, soluongmua,sotien from muave where MAKH ='" + dieuKien + "'");
        }
    }
}
