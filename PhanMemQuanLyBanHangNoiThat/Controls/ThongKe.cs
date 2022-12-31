using PhanMemQuanLyBanHangNoiThat.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyBanHangNoiThat.Controls
{
    class ThongKe
    {
        DataProvider db = new DataProvider();
        public String BaoCaoTongTienHoaDonTrongNgay()
        {
            String dongia = "";
            if (db.connect())
            {
                String strcmd = "select sum(TongTien) from HoaDon Where Ngay=CAST( GETDATE() AS Date )";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    dongia = reader.GetInt32(0).ToString();
                }
            }
            return dongia;
        }
        public String BaoCaoTongsoHoaDonTrongNgay()
        {
            String demhoadon = "";
            if (db.connect())
            {
                String strcmd = "select count(MaHD) from HoaDon Where Ngay=CAST( GETDATE() AS Date )";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    demhoadon = reader.GetInt32(0).ToString();
                }
            }
            return demhoadon;
        }
    }
}
