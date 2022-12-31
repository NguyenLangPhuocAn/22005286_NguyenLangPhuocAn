using PhanMemQuanLyBanHangNoiThat.Controls;
using PhanMemQuanLyBanHangNoiThat.Views;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace PhanMemQuanLyBanHangNoiThat
{
    public partial class Frm_DangNhap : Form
    {
        public String MaNV, QuyenNV;
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        bool InputIsCommand = false;
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Userlogin Users = new Userlogin();
            string CV;
            if (Txt_MaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên", "Thông Báo");
            }
            else
            {
                if (Txt_MaNV.Text.Length < 5)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên Từ 5 Ký Tự Trở Lên", "Thông Báo");
                }
                else
                {
                    if (Txt_Password.Text.Length == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập PassWord", "Thông Báo");
                    }
                    else
                    {
                        bool Kq = Users.getlogin(Txt_MaNV.Text, Txt_Password.Text);
                        MaNV = Txt_MaNV.Text;
                        if (Kq != false)
                        {
                            CV = Users.layquyen(Txt_MaNV.Text);
                            switch (Convert.ToInt64(CV))
                            {
                                case 1:
                                    {
                                        QuyenNV = "NhanVien";
                                        this.Hide();
                                        break;
                                    };
                                case 2:
                                    {
                                        QuyenNV = "QuanLy";
                                        this.Hide();
                                        break;
                                    };
                                case 3:
                                    {
                                        QuyenNV = "NVKHO";
                                        this.Hide();
                                        break;
                                    };
                                default: MessageBox.Show("Bạn Không Có Quyền Truy Cập"); break;
                            };
                            if (QuyenNV != null)
                            {
                                Form frmql = new Frm_QL(QuyenNV, MaNV);
                                frmql.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã Nhân Viên hoặc mật khẩu không đúng !");
                        }
                    }
                }
            }
        }
        private void Txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
            }
        }
        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
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

        private void Btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String MatKhau = "Hiện Mật Khẩu";
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
            Lb_NV.Text = "";
            if (Txt_Password.TextLength == 0)
                Lb_MK.Text = "Mật Khẩu";
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            Lb_MK.Text = "";
            if (Txt_MaNV.TextLength == 0)
                Lb_NV.Text = "Mã Nhân Viên";
        }

        private void P_NV_Click(object sender, EventArgs e)
        {
            if (MatKhau == "Hiện Mật Khẩu")
            {
                Txt_Password.PasswordChar = (char)0;
                MatKhau = "Ẩn Mật Khẩu";
            }
            else
            {
                Txt_Password.PasswordChar = '*';
                Txt_Password.UseSystemPasswordChar = false;
                MatKhau = "Hiện Mật Khẩu";
            }
        }

        private void Lb_QuenMK_Click(object sender, EventArgs e)
        {
            Form frm = new FrmQuenMK();
            frm.Show();
        }
    }
}
