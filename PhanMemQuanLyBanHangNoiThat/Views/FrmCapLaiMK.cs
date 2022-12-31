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
    public partial class FrmCapLaiMK : Form
    {
        public FrmCapLaiMK()
        {
            InitializeComponent();
        }
        bool InputIsCommand = false;
        String sth = "Hiện Mật Khẩu";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sth == "Hiện Mật Khẩu")
            {
                Txt_Password.PasswordChar = (char)0;
                sth = "Ẩn Mật Khẩu";
            }
            else
            {
                Txt_Password.PasswordChar = '*';
                Txt_Password.UseSystemPasswordChar = false;
                sth = "Hiện Mật Khẩu";
            }
        }
        private void Txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Txt_MaNV_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_MaNV_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.PaleTurquoise;
            Txt_MaNV.BackColor = Color.PaleTurquoise;
            panel3.BackColor = this.BackColor;
            Txt_Password.BackColor = this.BackColor;
        }

        private void Txt_Password_Click(object sender, EventArgs e)
        {
            panel2.BackColor = this.BackColor;
            Txt_MaNV.BackColor = this.BackColor;
            panel3.BackColor = Color.PaleTurquoise;
            Txt_Password.BackColor = Color.PaleTurquoise;
        }

        private void Txt_MaNV_Enter(object sender, EventArgs e)
        {
            Lb_MaNV.Text = "";
            if (Txt_Password.TextLength == 0)
                Lb_MK.Text = "Mật Khẩu";
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            Lb_MK.Text = "";
            if (Txt_MaNV.TextLength == 0)
                Lb_MaNV.Text = "Mã Nhân Viên";
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            Userlogin Users = new Userlogin();
            if (Txt_MaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên");
            }
            else
            {
                if (Txt_MaNV.Text.Length < 5)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên Từ 5 Ký Tự Trở Lên");
                }
                else
                {
                    if (Txt_Password.Text.Length == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập PassWord");
                    }
                    else
                    {
                        bool Kq = Users.LayMaNVTrongHeThong(Txt_MaNV.Text);
                        if (Kq != false)
                        {
                            try
                            {
                                Kq = Users.UpdatenMK(Txt_MaNV.Text, Txt_Password.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Đổi Mật Khẩu Không Thành Công", "Thông Báo");
                            }
                            if (Kq != false)
                            {
                                MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thông Báo");
                                Txt_MaNV.Clear();
                                Txt_Password.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Đổi Mật Khẩu Không Thành Công", "Thông Báo");
                            }
                        }
                        else
                            MessageBox.Show("Nhân Viên Không Tồn Tại", "Thông Báo");
                    }
                }

            }
        }
    }
}
