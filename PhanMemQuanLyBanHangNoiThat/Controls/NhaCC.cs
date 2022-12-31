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
    class NhaCC
    {

        DataProvider db = new DataProvider();
        public DataTable SelectNhaCC()
        {
            DataTable tbl = new DataTable();
            if (db.connect())
            {
                SqlCommand cmd = new SqlCommand("select * from NhaCC", db.connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tbl);
            }
            return tbl;
        }
        public bool InsertNhaCC(String MaNCC, String TenNCC, String DiaChi,String SDT)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "insert into NhaCC values(@MaNCC,@TenNCC,@DiaChi,@SDT)";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
                Cmd.Parameters.Add(new SqlParameter("@TenNCC", TenNCC));
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
        public bool DeleteNhaCC(String MaNCC)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "delete from NhaCC where MaNCC=@MaNCC";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
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
        public bool UpdateNhaCC(String MaNCC, String TenNCC, String DiaChi, String SDT)
        {
            int rec = 0;
            if (db.connect())
            {
                string strcmd = "update NhaCC set TenNCC=@TenNCC,Diachi=@DiaChi,SDT=@SDT where MaNCC=@MaNCC";
                SqlCommand Cmd = new SqlCommand(strcmd, db.connection);
                Cmd.Parameters.Add(new SqlParameter("@MaNCC", MaNCC));
                Cmd.Parameters.Add(new SqlParameter("@TenNCC", TenNCC));
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
