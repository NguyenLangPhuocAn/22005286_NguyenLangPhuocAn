using PhanMemQuanLyBanHangNoiThat.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyBanHangNoiThat.Controls
{
    class Users
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
        public bool CheckNVQuenMK(String MaNV, DateTime NgaySinh)
        {
            int rec = 0;
            if (Db.connect())
            {
                string strcmd = "select count(*) from NhanVien where MaNV=@MaNV And NgaySinh=@NgaySinh";
                SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                Cmd.Parameters.Add(new SqlParameter("@NgaySinh", NgaySinh));
                rec = (int)Cmd.ExecuteScalar();
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
        public bool UpdatenMK(String MaNV, String Password)
        {
            int rec = 0;
            if (Db.connect())
            {
                string strcmd = "update Users set Passwords=@Passwords,GhiChu='' where MaNV=@MaNV";
                SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                Cmd.Parameters.Add(new SqlParameter("@Passwords", Password));
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
        public bool UpdatePassWordChoNhanVienQuen(string MaNV,String PassWord)
        {
            Db.connect();
            string strcmd = "update Users set Passwords=@Passwords,GhiChu='' where MaNV =@MaNV";
            SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
            Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            Cmd.Parameters.Add(new SqlParameter("@Passwords", PassWord));
            int getlogin = (int)Cmd.ExecuteNonQuery();
            if (getlogin == 1)
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
            string strcmd = "SELECT MaCV FROM NhanVien WHERE MaNV =@MaNV";
            SqlCommand Cmd = new SqlCommand(strcmd, Db.connection);
            Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                cv = Convert.ToString(reader.GetInt32(0));
            }
            return cv;
        }

    }
}
