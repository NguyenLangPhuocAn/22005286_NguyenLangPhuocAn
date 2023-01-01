using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmQuenMK : Form
    {
        public FrmQuenMK()
        {
            InitializeComponent();
        }
        bool InputIsCommand = false;
        private void Txt_MaNV_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.PaleTurquoise;
            Txt_MaNV.BackColor = Color.PaleTurquoise;
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            Users Users = new Users();
            if (Txt_MaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên");
            }
            else
            {
                if (Txt_MaNV.Text.Length < 5)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên Từ 4 Ký Tự Trở Lên");
                }
                else
                {
                    bool rec = false;
                    Txt_MaNV.Text = "10000";
                    rec = Users.CheckNVQuenMK(Txt_MaNV.Text, DP_NgaySinh.Value);
                    if (rec != false)
                    {
                        bool rs = false;
                        try
                        {
                            rs = Users.LayMaNVTrongHeThong(Txt_MaNV.Text);
                            if (rs != false)
                            {
                                bool sth = false;
                                try
                                {
                                    char[] words = "abcdefghjklmnopqrstuwxyzABCDEFGHJKLMNOPRQWIEUROTXZCVB".ToCharArray();
                                    Random ran = new Random();
                                    string Pass = "";
                                    for (int i = 0; i <= 5; i++)
                                    {
                                        Pass = Pass + words[ran.Next(0, words.Length)].ToString();
                                    }
                                    MessageBox.Show("Vui Lòng Viết Lại Pass: " + Pass, "Thông Báo");
                                    try
                                    {
                                        sth = Users.UpdatePassWordChoNhanVienQuen(Txt_MaNV.Text, Pass);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Nhân Viên Không Đổi Mật Khẩu Được Liên Hệ Quản Lý", "Thông Báo");
                                    }
                                    if (sth != false)
                                    {
                                        MessageBox.Show("Nhân Viên Đổi Pass Thành Công", "Thông Báo");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nhân Viên Không Có Trong Hệ Thống", "Thông Báo");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Nhân Viên Không Được Phân Quyền", "Thông Báo");
                                }
                            }
                            else
                                MessageBox.Show("Nhân Viên Không Được Phân Quyền", "Thông Báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nhân Viên Không Có Trong Hệ Thống", "Thông Báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai Mã Nhân Viên Hoặc Ngày Sinh", "Thông Báo");
                    }
                }
            }
        }
        private void Txt_MaNV_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Số", "Thông Báo");
            }
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_MaNV_Enter(object sender, EventArgs e)
        {
            Lb_NV.Text = "";
        }

        private void Txt_MaNV_Leave(object sender, EventArgs e)
        {
            if (Txt_MaNV.Text.Length == 0)
                Lb_NV.Text = "Mã Nhân Viên";
        }
    }
}
