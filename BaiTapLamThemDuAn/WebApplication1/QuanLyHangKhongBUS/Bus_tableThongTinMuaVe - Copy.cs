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
    public class Bus_tableThonhTinMuaVe
    {
        Sql_tableThongTinMuaVe sqlVeMua = new Sql_tableThongTinMuaVe();
        public void themDL(EC_ThongTinMuaVe themVeMua)
        {
            sqlVeMua.themDL(themVeMua);

        }
        public void suaDL(EC_ThongTinMuaVe suaVeMua)
        {
            sqlVeMua.suaDL(suaVeMua);
        }
        public void suaSoGhe(EC_ThongTinMuaVe suaSoGhe)
        {
            sqlVeMua.updatesoGhe(suaSoGhe);
        }
        public void xoaDL(EC_ThongTinMuaVe xoaVeMua)
        {
            sqlVeMua.xoaDL(xoaVeMua);
        }
        public DataTable LayDuLieu(string dieuKien)
        {
            return sqlVeMua.TaoBang(dieuKien);
        }
        public DataTable LayDuLieuGHe(string dieuKien)
        {
            return sqlVeMua.LaySoGhe(dieuKien);
        }
        public DataTable LayDuLieuTienVe(int dieuKien)
        {
            return sqlVeMua.LaytienTVe(dieuKien);
        }
    }
}
