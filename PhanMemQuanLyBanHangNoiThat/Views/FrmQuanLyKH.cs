using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmQuanLyKH : Form
    {
        public FrmQuanLyKH()
        {
            InitializeComponent();
        }
        KhachHang khachHang = new KhachHang();
        bool InputIsCommand = false;
        private void load()
        {
            DataTable KH;
            KH = khachHang.SelectKhachHang();
            DGV_KH.DataSource = KH;
            Btn_Tim.Text = "Tìm Kiếm";
        }
        private void FrmQuanLyKH_Load(object sender, EventArgs e)
        {
            load();
        }
        private void clear_text()
        {
            Txt_MaKh.Text = "";
            Txt_SDT.Text = "";
            Txt_DiaChi.Text = "";
            Txt_Ten.Text = "";
        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            if (Btn_Them.Text == "Thêm")
            {
                Btn_Sua.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Xoa.Enabled = false;
                clear_text();
                Txt_MaKh.ReadOnly = true;
                Btn_Them.Text = "Xác Nhận";
            }

            else if (Btn_Them.Text == "Xác Nhận")
            {
                if (Txt_Ten.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Tên", "Thông Báo");
                }
                else
                {
                    if (Txt_Ten.Text.Length < 3)
                        MessageBox.Show("Vui Lòng Nhập Tên hơn 3 ký tự", "Thông Báo");
                    else
                    {
                        if (Txt_SDT.Text.Length == 0)
                            MessageBox.Show("Vui Lòng Nhập Số Điện Thoại", "Thông Báo");
                        else
                        {
                            if (Txt_SDT.Text.Length < 10)
                                MessageBox.Show("Vui Lòng Nhập Đủ 10 Số Điện Thoại", "Thông Báo");
                            else
                            {
                                if (Txt_DiaChi.Text.Length == 0)
                                    MessageBox.Show("Vui Lòng Nhập Địa Chỉ", "Thông Báo");
                                else
                                {
                                    bool rec = false;
                                    try
                                    {
                                        rec = khachHang.InsertKhachHang(Txt_Ten.Text, Txt_DiaChi.Text, Txt_SDT.Text);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Không Thêm Được", "Thông Báo");
                                        clear_text();
                                    }
                                    if (rec != false)
                                    {
                                        MessageBox.Show("Bạn Đã Thêm 1 Khách Hàng Mới", "Thông Báo");
                                        load();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Không Thành Công", "Thông Báo");
                                        clear_text();
                                    }
                                    Btn_Sua.Enabled = true;
                                    Btn_Tim.Enabled = true;
                                    Btn_Xoa.Enabled = true;
                                    Txt_MaKh.ReadOnly = false;
                                    Btn_Them.Text = "Thêm";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Txt_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Chữ", "Thông Báo");
            }
        }

        private void Txt_MaKh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Chữ", "Thông Báo");
            }
        }

        private void Txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
               e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
            }
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (Btn_Xoa.Text == "Xóa")
            {
                Btn_Sua.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Them.Enabled = false;
                Txt_DiaChi.ReadOnly = true;
                Txt_SDT.ReadOnly = true;
                Txt_Ten.ReadOnly = true;
                Btn_Xoa.Text = "Xác Nhận";
            }

            else if (Btn_Xoa.Text == "Xác Nhận")
            {
                if (Txt_MaKh.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng");
                }
                bool rec = false;
                try
                {
                    rec = khachHang.DeleteKhachHang(Txt_MaKh.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa Không Thành Công", "Thông Báo");
                }
                if (rec != false)
                {
                    MessageBox.Show("Bạn Đã Xóa 1 Khách Hàng", "Thông Báo");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công", "Thông Báo");
                }
                Btn_Sua.Enabled = true;
                Btn_Tim.Enabled = true;
                Btn_Them.Enabled = true;
                Txt_DiaChi.ReadOnly = false;
                Txt_SDT.ReadOnly = false;
                Txt_Ten.ReadOnly = false;
                Btn_Xoa.Text = "Xóa";
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (Btn_Sua.Text == "Sửa")
            {
                Btn_Xoa.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Them.Enabled = false;
                Txt_MaKh.ReadOnly = true;
                Btn_Sua.Text = "Xác Nhận";
            }
            else if (Btn_Sua.Text == "Xác Nhận")
            {
                if (Txt_Ten.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Tên", "Thông Báo");
                }
                else
                {
                    if (Txt_Ten.Text.Length < 3)
                        MessageBox.Show("Vui Lòng Nhập Tên hơn 3 ký tự", "Thông Báo");
                    else
                    {
                        if (Txt_SDT.Text.Length == 0)
                            MessageBox.Show("Vui Lòng Nhập Số Điện Thoại", "Thông Báo");
                        else
                        {
                            if (Txt_SDT.Text.Length < 10)
                                MessageBox.Show("Vui Lòng Nhập Đủ 10 Số Điện Thoại", "Thông Báo");
                            else
                            {
                                if (Txt_DiaChi.Text.Length == 0)
                                    MessageBox.Show("Vui Lòng Nhập Địa Chỉ", "Thông Báo");
                                else
                                {
                                    bool rec = false;
                                    try
                                    {
                                        rec = khachHang.UpdateKhachHang(Txt_MaKh.Text, Txt_Ten.Text, Txt_DiaChi.Text, Txt_SDT.Text);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                                    }
                                    if (rec != false)
                                    {
                                        MessageBox.Show("Bạn Đã Sửa Khách Hàng Thành Công ", "Thông Báo");
                                        load();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                                    }
                                    Btn_Xoa.Enabled = true;
                                    Btn_Tim.Enabled = true;
                                    Btn_Them.Enabled = true;
                                    Txt_MaKh.ReadOnly = false;
                                    Btn_Sua.Text = "Sửa";
                                }
                            }
                        }
                    }
                }
            }
        }
        private void DGV_KH_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_KH.SelectedRows)
            {
                Txt_MaKh.Text = row.Cells[0].Value.ToString();
                Txt_Ten.Text = row.Cells[1].Value.ToString();
                Txt_DiaChi.Text = row.Cells[2].Value.ToString();
                Txt_SDT.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Btn_Tim_Click(object sender, EventArgs e)
        {
            DataTable db = (DataTable)DGV_KH.DataSource;
            db.DefaultView.RowFilter = String.Format("CONVERT(MaKH,System.String) LIKE '%{0}%' And TenKH LIKE '%{1}%' And DiaChi LIKE '%{2}%' And SDT LIKE '%{3}%' ", Txt_MaKh.Text, Txt_Ten.Text, Txt_DiaChi.Text, Txt_SDT.Text);
            if (DGV_KH.Rows.Count == 0)
            {
                MessageBox.Show("Không Có Khách Hàng Này", "Thông Báo");
                load();
            }
        }
        private void Txt_MaKh_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_Ten_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_DiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
        }
    }
}
