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
    class HoaDon
    {
        DataProvider db = new DataProvider();
        public int SelectDongia(String MaVT)
        {
            int dongia=0 ;
            if (db.connect())
            {
                String strcmd = ("select Top 1 DonGia from VatTu Where MaVT=@MaVT");
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    dongia = reader.GetInt32(0);
                }
            }
            return dongia;
        }
        public bool UpdateVTXoa(String MaVT,int SL)
        {
            int rec = 0;
            if (db.connect())
            {
                String strcmd = ("update VatTu set Soluong=(SoLuong+@SL) where MaVT=@MaVT");
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                Cmd.Parameters.Add(new SqlParameter("@SL", SL));
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
        public bool UpdateVTThem(String MaVT, int SL)
        {
            int rec = 0;
            if (db.connect())
            {
                String strcmd = ("update VatTu set Soluong=(SoLuong-@SL) where MaVT=@MaVT");
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                Cmd.Parameters.Add(new SqlParameter("@SL", SL));
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
        public int SumTongTien(int MaHD)
        {
            int tong = 0;
            if (db.connect())
            {
                String strcmd = ("select Sum(Soluong*Dongia) from ChiTietHoaDon where MaHD=@MaHD");
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    tong = reader.GetInt32(0);
                }
            }
            return tong;
        }
        public int MaxHD()
        {
            int HD = 0;
            if (db.connect())
            {
                String strcmd = ("select Max(MaHD) from HoaDon");
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    HD = reader.GetInt32(0);
                }
            }
            return HD;
        }
        public int SLVT(String MaVT)
        {
            int VT = 0;
            if (db.connect())
            {
                String strcmd = ("select SoLuong from VatTu Where MaVT=@MaVT");
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                SqlDataReader reader = Cmd.ExecuteReader();
                if (reader.Read())
                {
                    VT = reader.GetInt32(0);
                }
            }
            return VT;
        }
        public DataTable SelectVatTu()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select TenVT,MaVT from VatTu", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public DataTable SelectHoaDon()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select * from HoaDon", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public DataTable SelectCTHoaDon(String MaHD)
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                String sql="select * from ChiTietHoaDon where MaHD=@MaHD";
                SqlCommand cmd = new SqlCommand(sql,db.connection);
                cmd.Parameters.AddWithValue("@MaHD", MaHD);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public bool InsertCTHoaDon(String MaHD,int SL,String MaVT,int DongGia)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into ChiTietHoaDon values(@MaHD,@SL,@MaVT,@Dongia)";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaHD",MaHD));
                Cmd.Parameters.Add(new SqlParameter("@SL", SL));
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                Cmd.Parameters.Add(new SqlParameter("@Dongia", DongGia));
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
        public bool DeleteCTHoaDon1(String MaCTHD) //XOA RIENG CHI TIET HOA DON
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from ChiTietHoaDon where MaCTHD=@MaCTHD";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaCTHD", MaCTHD));
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
        public bool InsertHoaDon(DateTime Ngay,int MaKH,int TongTien)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into HoaDon values(@Ngay,@MaKH,@TongTien)";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@Ngay", Ngay));
                Cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                Cmd.Parameters.Add(new SqlParameter("@TongTien", TongTien));
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
        public bool DeleteCTHoaDon(int MaHD) //xoa TOAN BO CTHD
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from ChiTietHoaDon where MaHD=@MaHD";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
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
        public bool DeleteHoaDon(int MaHD)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from HoaDon where MaHD=@MaHD";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
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
        public bool UpdateHoaDonTien(int MaHD,int TongTien)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "update HoaDon set TongTien=@TongTien where MaHD=@MaHD";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
                Cmd.Parameters.Add(new SqlParameter("@TongTien", TongTien));
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
        public bool UpdateHoaDon(int MaHD, int MaKH,int TongTien)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "update HoaDon set MaKH=@MaKH,TongTien=@TongTien where MaHD=@MaHD";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
                Cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                Cmd.Parameters.Add(new SqlParameter("@TongTien", TongTien));
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
