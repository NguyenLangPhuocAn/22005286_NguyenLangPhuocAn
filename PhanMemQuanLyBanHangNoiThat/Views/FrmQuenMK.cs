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
            Userlogin Users = new Userlogin();
            if (Txt_MaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên");
            }
            else
            {
                if (Txt_MaNV.Text.Length < 5)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên Từ 3 Ký Tự Trở Lên");
                }
                else
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
                                sth = Users.QuenMK(Txt_MaNV.Text);
                                if (sth != false)
                                {
                                    DialogResult tb = MessageBox.Show("Đã Gửi Yêu Cầu Tới Quản Lý, Vui Lòng Gặp Quản Lý Để Lấy Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
                                    if (tb == DialogResult.OK)
                                        this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Nhân Viên Không Có Trong Hệ Thống");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Nhân Viên Không Có Trong Hệ Thống");
                            }
                        }
                        else
                            MessageBox.Show("Nhân Viên Không Có Trong Hệ Thống");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhân Viên Không Có Trong Hệ Thống");
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
            }
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
