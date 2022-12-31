using PhanMemQuanLyBanHangNoiThat.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyBanHangNoiThat.Controls
{
    class Userlogin
    {
        DataProvider Db = new DataProvider();
        public bool getlogin(string MaNV, string pass)
        {
            int getlogin = 0;
            if (Db.connect())
            {
                string strcmd = "Select count(*) from Users where MaNV=@MaNV and Passwords=@pass";
                SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                Cmd.Parameters.Add(new SqlParameter("@pass", pass));
                getlogin = (int)Cmd.ExecuteScalar();
            }
            else
            {
                getlogin = -1;
            }
            if (getlogin == 1)
                return true;
            else
                return false;
        }
        public bool QuenMK(String MaNV)
        {
            int rec = 0;
            if (Db.connect())
            {
                string strcmd = "update Users set GhiChu=N'Cấp Lại Mật Khẩu' where MaNV=@MaNV";
                SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                rec = (int)Cmd.ExecuteNonQuery();
            }
            else
            {
                rec = -1;
            }
            if (rec == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool UpdatenMK(String MaNV, String Password)
        {
            int rec = 0;
            if (Db.connect())
            {
                string strcmd = "update Users set Passwords=@Passwords,GhiChu='' where MaNV=@MaNV";
                SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV",MaNV));
                Cmd.Parameters.Add(new SqlParameter("@Passwords",Password));
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
        public bool LayMaNVTrongHeThong(string MaNV)
        {
            Db.connect();
            string strcmd = "Select count(*) from Users where MaNV =@MaNV";
            SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
            Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            int getlogin = (int)Cmd.ExecuteScalar();
            if (getlogin == 1)
                return true;
            else
                return false;
        }
        public string layquyen(string MaNV)
        {
            string cv = "";
            SqlCommand cmd = new SqlCommand("SELECT MaCV FROM NhanVien WHERE MaNV ='" + MaNV + "'", Db.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cv = dr["MaCV"].ToString();
                }
            }
            return cv;
        }
    }
}
