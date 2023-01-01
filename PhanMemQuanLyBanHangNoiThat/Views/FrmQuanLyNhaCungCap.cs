using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmQuanLyNhaCungCap : Form
    {
        public FrmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        bool InputIsCommand = false;
        NhaCC nhaCC = new NhaCC();
        private void load()
        {
            DataTable NCC;
            NCC = nhaCC.SelectNhaCC();
            DGV_NCC.DataSource = NCC;
            Btn_Tim.Text = "Tìm Kiếm";
        }
        private void FrmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            load();
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

        private void Txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
            }
        }
        private void clear_text()
        {
            Txt_MaNCC.Text = "";
            Txt_SDT.Text = "";
            Txt_DiaChi.Text = "";
            Txt_Ten.Text = "";
        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            bool rec = false;
            if (Btn_Them.Text == "Thêm")
            {
                Btn_Sua.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Xoa.Enabled = false;
                clear_text();
                Btn_Them.Text = "Xác Nhận";
            }

            else if (Btn_Them.Text == "Xác Nhận")
            {
                if (Txt_MaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Nhà Cung Cấp", "Thông Báo");
                }
                else
                {
                    if (Txt_MaNCC.Text.Length < 3)
                        MessageBox.Show("Vui Lòng Nhập Mã Nhà Cung Cấp Hơn 3 Ký Tự", "Thông Báo");
                    else
                    {
                        if (Txt_Ten.Text.Length == 0)
                            MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp", "Thông Báo");
                        else
                        {
                            if (Txt_Ten.Text.Length < 3)
                                MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp Hơn 3 Ký Tự", "Thông Báo");
                            else
                            {
                                if (Txt_SDT.Text.Length == 0)
                                    MessageBox.Show("Vui Lòng Nhập Số Điện Thoại", "Thông Báo");
                                else
                                {
                                    if (Txt_SDT.Text.Length < 10)
                                        MessageBox.Show("Vui Lòng Nhập Số Điện Thoại Có 10 Số", "Thông Báo");
                                    else
                                    {
                                        if (Txt_DiaChi.Text.Length == 0)
                                            MessageBox.Show("Vui Lòng Nhập Địa Chỉ", "Thông Báo");
                                        else
                                        {
                                            try
                                            {
                                                rec = nhaCC.InsertNhaCC(Txt_MaNCC.Text, Txt_Ten.Text, Txt_DiaChi.Text, Txt_SDT.Text);
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Thêm Không Thành Công", "Thông Báo");
                                            }
                                            if (rec != false)
                                            {
                                                MessageBox.Show("Bạn Đã Thêm 1 Nhà Cung Cấp Mới", "Thông Báo");
                                                load();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Thêm Không Thành Công", "Thông Báo");
                                            }
                                            Btn_Sua.Enabled = true;
                                            Btn_Tim.Enabled = true;
                                            Btn_Xoa.Enabled = true;
                                            Btn_Them.Text = "Thêm";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Txt_MaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
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
                Txt_MaNCC.ReadOnly = true;
                Txt_Ten.ReadOnly = true;
                Btn_Xoa.Text = "Xác Nhận";
            }
            else if (Btn_Xoa.Text == "Xác Nhận")
            {
                if (Txt_MaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Chọn Nhà Cung Cấp", "Thông Báo");
                }
                else
                {
                    bool rec = false;
                    try
                    {
                        rec = nhaCC.DeleteNhaCC(Txt_MaNCC.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không Thể Xóa Nhà Cung Cấp Này Được", "Thông Báo");
                    }
                    if (rec != false)
                    {
                        MessageBox.Show("Bạn Đã Xóa 1 Nhà Cung Cấp Thành Công", "Thông Báo");
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
                    Txt_MaNCC.ReadOnly = false;
                    Btn_Xoa.Text = "Xóa";
                }
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (Btn_Sua.Text == "Sửa")
            {
                Btn_Xoa.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Them.Enabled = false;
                Txt_MaNCC.ReadOnly = true;
                Btn_Sua.Text = "Xác Nhận";
            }

            else if (Btn_Sua.Text == "Xác Nhận")
            {
                if (Txt_MaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Nhà Cung Cấp", "Thông Báo");
                }
                else
                {
                    if (Txt_Ten.Text.Length == 0)
                        MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp", "Thông Báo");
                    else
                    {
                        if (Txt_Ten.Text.Length < 3)
                            MessageBox.Show("Vui Lòng Nhập Tên Nhà Cung Cấp Hơn 3 Ký Tự", "Thông Báo");
                        else
                        {
                            if (Txt_SDT.Text.Length == 0)
                                MessageBox.Show("Vui Lòng Nhập Số Điện Thoại", "Thông Báo");
                            else
                            {
                                if (Txt_SDT.Text.Length < 10)
                                    MessageBox.Show("Vui Lòng Nhập Số Điện Thoại Có 10 Số", "Thông Báo");
                                else
                                {
                                    if (Txt_DiaChi.Text.Length == 0)
                                        MessageBox.Show("Vui Lòng Nhập Địa Chỉ", "Thông Báo");
                                    else
                                    {
                                        bool rec = false;
                                        try
                                        {
                                            rec = nhaCC.UpdateNhaCC(Txt_MaNCC.Text, Txt_Ten.Text, Txt_DiaChi.Text, Txt_SDT.Text);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                                        }
                                        if (rec != false)
                                        {
                                            MessageBox.Show("Bạn Đã Sửa Nhà Cung Cấp Thành Công", "Thông Báo");
                                            load();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                                        }
                                        Btn_Xoa.Enabled = true;
                                        Btn_Tim.Enabled = true;
                                        Btn_Them.Enabled = true;
                                        Txt_MaNCC.ReadOnly = false;
                                        Btn_Sua.Text = "Sửa";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DGV_NCC_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_NCC.SelectedRows)
            {
                Txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                Txt_Ten.Text = row.Cells["TenNCC"].Value.ToString();
                Txt_DiaChi.Text = row.Cells["Diachi"].Value.ToString();
                Txt_SDT.Text = row.Cells["SDT"].Value.ToString();
            }
        }

        private void Btn_Tim_Click(object sender, EventArgs e)
        {
            if (Btn_Tim.Text == "Tìm Kiếm")
            {
                DataTable db = (DataTable)DGV_NCC.DataSource;
                db.DefaultView.RowFilter = String.Format("MaNCC LIKE '%{0}%' And TenNCC LIKE '%{1}%' And DiaChi LIKE '%{2}%' And SDT LIKE '%{3}%' ", Txt_MaNCC.Text, Txt_Ten.Text, Txt_DiaChi.Text, Txt_SDT.Text);
                Btn_Tim.Text = "Xác Nhận";
                if (DGV_NCC.Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Nhà Cung Cấp Này", "Thông Báo");
                    load();
                    Btn_Tim.Text = "Tìm Kiếm";
                }
            }
            else if (Btn_Tim.Text == "Xác Nhận")
            {
                Btn_Tim.Text = "Tìm Kiếm";
                load();
            }
        }
        private void Txt_MaNCC_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_Ten_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
        }

        private void Txt_DiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }
    }
}
