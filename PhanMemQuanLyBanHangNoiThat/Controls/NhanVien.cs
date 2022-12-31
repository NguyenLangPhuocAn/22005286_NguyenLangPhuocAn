using PhanMemQuanLyBanHangNoiThat.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyBanHangNoiThat.Controls
{
    class NhanVien
    {
        DataProvider db = new DataProvider();
        public DataTable SelectNhanVien()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select NhanVien.MaNV,NhanVien.TenNV,NhanVien.Ngaysinh,NhanVien.MaCV,ChucVu.TenCV from NhanVien inner join ChucVu ON NhanVien.MaCV=ChucVu.MaCV", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public DataTable LayMax()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select max(MANV)as MaNV from NhanVien", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public DataTable SelectMaCV()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select MaCV,TenCV from ChucVu", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public bool InsertNhanVien(String MaNV, String TenNV, DateTime NS, int MaCV)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into NhanVien values(@MaNV,@TenNV,@NS,@MaCV)";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                Cmd.Parameters.Add(new SqlParameter("@TenNV", TenNV));
                Cmd.Parameters.Add(new SqlParameter("@NS", NS));
                Cmd.Parameters.Add(new SqlParameter("@MaCV",MaCV));
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
        public bool DeleteNhanVien(String MaNV)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from NhanVien where MaNV=@MaNV";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
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
        public bool DeleteUsers(String MaNV)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from Users where MaNV=@MaNV";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
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
        public DataTable LayGhiChu()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select MaNV,GhiChu from Users", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public bool CapMK(String MaNV, String pass)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into Users values(@MaNV,@Password,'')";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                Cmd.Parameters.Add(new SqlParameter("@Password", pass));
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
        public bool UpdateNhanVien(String MaNV, String TenNV, DateTime NS, int MaCV)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "update NhanVien set TenNV=@TenNV,NgaySinh=@NS,MaCV=@MaCV where MaNV=@MaNV";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                Cmd.Parameters.Add(new SqlParameter("@TenNV", TenNV));
                Cmd.Parameters.Add(new SqlParameter("@NS", NS));
                Cmd.Parameters.Add(new SqlParameter("@MaCV", MaCV));
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
