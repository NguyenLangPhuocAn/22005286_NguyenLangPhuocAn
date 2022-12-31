using PhanMemQuanLyBanHangNoiThat.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PhanMemQuanLyBanHangNoiThat.Controls
{
    class KhachHang
    {
        DataProvider db = new DataProvider();
        public DataTable SelectKhachHang()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select * from KhachHang",db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public bool InsertKhachHang(String TenKH,String DiaChi,String SDT)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into KhachHang values(@TenKH,@DiaChi,@SDT)";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@TenKH", TenKH));
                Cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
                Cmd.Parameters.Add(new SqlParameter("@SDT", SDT));
                rec = (int)Cmd.ExecuteNonQuery();
            }
            else
            {
                rec = -1;
            }
            if (rec == 1)
                return true;
            else
                return false;
        }
        public bool DeleteKhachHang(String MaKH)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from KhachHang where MaKH=@MaKH";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                rec = (int)Cmd.ExecuteNonQuery();
            }
            else
            {
                rec = -1;
            }
            if (rec == 1)
                return true;
            else
                return false;
        }
        public bool UpdateKhachHang(String MaKH,String TenKH, String DiaChi, String SDT)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "update KhachHang set TenKH=@TenKH,DiaChi=@DiaChi,SDT=@SDT where MaKH=@MaKH";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                Cmd.Parameters.Add(new SqlParameter("@TenKH", TenKH));
                Cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
                Cmd.Parameters.Add(new SqlParameter("@SDT", SDT));
                rec = (int)Cmd.ExecuteNonQuery();
            }
            else
            {
                rec = -1;
            }
            if (rec == 1)
                return true;
            else
                return false;
        }
    }
}
