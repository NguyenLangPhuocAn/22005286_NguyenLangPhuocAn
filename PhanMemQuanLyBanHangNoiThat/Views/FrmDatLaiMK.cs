using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmDatLaiMK : Form
    {
        private string MaNV;
        public FrmDatLaiMK(String manv)
        {
            InitializeComponent();
            MaNV = manv;
        }
        bool InputIsCommand = false;
        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            Userlogin user = new Userlogin();
            if (Txt_Password.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
            }
            else
            {
                if (Txt_Password.Text.Length < 3)
                {
                    MessageBox.Show("Vui Lòng Nhập Mật Khẩu Hơn 3 Ký Tự");
                }
                else
                {
                    bool rec = false;
                    try
                    {
                        rec = user.UpdatenMK(MaNV, Txt_Password.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập Nhật Mật Khẩu Không Thành Công","Thông Báo");
                    }
                    if (rec != false)
                        MessageBox.Show("Cập Nhật Mật Khẩu Thành Công", "Thông Báo");                 
                    else
                        MessageBox.Show("Cập Nhật Mật Khẩu Không Thành Công", "Thông Báo");
                    Txt_Password.Clear();
                }
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
                Lb_MK.Text = "";
        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if (Txt_Password.TextLength == 0)
                Lb_MK.Text = "Mật Khẩu";
        }
    }
}
