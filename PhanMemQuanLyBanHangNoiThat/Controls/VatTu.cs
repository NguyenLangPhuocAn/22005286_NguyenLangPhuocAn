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
    class VatTu
    {
        DataProvider db = new DataProvider();
        public DataTable SelectVT()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select NhaCC.MaNCC,NhaCC.TenNCC,VatTu.TenVT,VatTu.Dongia,VatTu.MaVT,VatTu.Soluong from VatTu inner join NhaCC ON VatTu.MaNCC = NhaCC.MaNCC", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public DataTable SelectNhaCC()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select MaNCC from NhaCC", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public bool InsertVatTu(String MaVT,String TenVT,String MaNCC,int SL,int DG)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into VatTu values(@MaVT,@TenVT,@MaNCC,@SL,@DG)";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                Cmd.Parameters.Add(new SqlParameter("@TenVT", TenVT));
                Cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
                Cmd.Parameters.Add(new SqlParameter("@SL", SL));
                Cmd.Parameters.Add(new SqlParameter("@DG", DG));
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
        public bool DeleteVatTu(String MaVT)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from VatTu where MaVT=@MaVT";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
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
        public bool UpdateVatTu(String MaVT, String TenVT, String MaNCC, int SL, int DG)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "update VatTu set TenVt=@TenVT,MaNCC=@MaNCC,Soluong=@SL,Dongia=@DG where MaVT=@MaVT";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaVT", MaVT));
                Cmd.Parameters.Add(new SqlParameter("@TenVT", TenVT));
                Cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
                Cmd.Parameters.Add(new SqlParameter("@SL", SL));
                Cmd.Parameters.Add(new SqlParameter("@DG", DG));
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
