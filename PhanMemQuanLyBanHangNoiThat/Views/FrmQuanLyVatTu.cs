using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmQuanLyVatTu : Form
    {
        public FrmQuanLyVatTu()
        {
            InitializeComponent();
        }
        VatTu VTu = new VatTu();
        bool InputIsCommand = false;
        private void load()
        {
            DataTable VT, NCC;
            VT = VTu.SelectVT();
            DGV_VT.DataSource = VT;
            NCC = VTu.SelectNhaCC();
            Cb_MaNCC.DataSource = NCC;
            Cb_MaNCC.DisplayMember = "MaNCC";
            Cb_MaNCC.ValueMember = "MaNCC";
            Btn_Tim.Text = "Tìm Kiếm";
        }
        private void FrmQuanLyVatTu_Load(object sender, EventArgs e)
        {
            load();
        }
        private void clear_text()
        {
            Cb_MaNCC.Text = "Vui Lòng Chọn Mã Nhà Cung Cấp";
            Txt_Ten.Text = "";
            Txt_SL.Text = "";
            Txt_VT.Text = "";
            Txt_DonGia.Text = "";
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
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
                if (Txt_VT.Text.Length == 0)
                    MessageBox.Show("Vui Lòng Nhập Mã Vật Tư", "Thông Báo");
                else
                {
                    if (Txt_VT.Text.Length < 3)
                        MessageBox.Show("Vui Lòng Nhập Mã Vật Tư Trên 3 Ký Tự", "Thông Báo");
                    else
                    {
                        if (Txt_Ten.Text.Length == 0)
                        {
                            MessageBox.Show("Vui Lòng Nhập Tên Vật Tư", "Thông Báo");
                        }
                        else
                        {
                            if (Txt_Ten.Text.Length < 4)
                                MessageBox.Show("Vui Lòng Nhập Tên Vật Tư Trên 3 Ký Tự", "Thông Báo");
                            else
                            {
                                if (Txt_SL.Text.Length == 0)
                                    MessageBox.Show("Vui Lòng Nhập Số Lượng Vật Tư", "Thông Báo");
                                else
                                {
                                    if (Convert.ToInt32(Txt_SL.Text) > 100)
                                        MessageBox.Show("Vui Lòng Nhập Số Lượng Vật Tư Nhỏ Hơn 100", "Thông Báo");
                                    else
                                    {
                                        if (Txt_DonGia.Text.Length == 0)
                                            MessageBox.Show("Vui Lòng Nhập Đơn Giá", "Thông Báo");
                                        else
                                        {
                                            if (Convert.ToInt32(Txt_DonGia.Text) < 10000 && Convert.ToInt32(Txt_DonGia.Text) > 1000000)
                                                MessageBox.Show("Vui Lòng Nhập Đơn Giá Hơn 10000 Và Nhỏ Hơn 1000000 ", "Thông Báo");
                                            else
                                            {
                                                if (Cb_MaNCC.Text == "Vui Lòng Mã Nhà Cung Cấp")
                                                    MessageBox.Show("Vui Lòng Chọn Nhà Cung Cấp", "Thông Báo");
                                                else
                                                {
                                                    bool rec = false;
                                                    try
                                                    {
                                                        rec = VTu.InsertVatTu(Txt_VT.Text, Txt_Ten.Text, Cb_MaNCC.SelectedValue.ToString(), Convert.ToInt16(Txt_SL.Text), Convert.ToInt16(Txt_DonGia.Text));
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Không Thêm Được", "Thông Báo");
                                                    }
                                                    if (rec != false)
                                                    {
                                                        MessageBox.Show("Bạn Đã Thêm 1 Vật Tư Mới", "Thông Báo");
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
            }
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (Btn_Xoa.Text == "Xóa")
            {
                Btn_Sua.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Them.Enabled = false;
                Txt_Ten.ReadOnly = true;
                Txt_SL.ReadOnly = true;
                Txt_DonGia.ReadOnly = true;
                Txt_VT.Enabled = false;
                Cb_MaNCC.Enabled = false;
                Btn_Xoa.Text = "Xác Nhận";
            }

            else
            {
                bool rec = false;
                if (Txt_VT.Text.Length == 0)
                    MessageBox.Show("Vui Lòng Chọn Mã Vật Tư", "Thông Báo");
                else
                {
                    try
                    {
                        rec = VTu.DeleteVatTu(Txt_VT.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không Xóa Được", "Thông Báo");
                    }
                    if (rec != false)
                    {
                        MessageBox.Show("Bạn Đã Xóa 1 Vật Tư", "Thông Báo");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Thông Báo");
                    }
                    Btn_Sua.Enabled = true;
                    Btn_Tim.Enabled = true;
                    Btn_Them.Enabled = true;
                    Txt_VT.Enabled = true;
                    Txt_Ten.ReadOnly = false;
                    Txt_SL.ReadOnly = false;
                    Txt_DonGia.ReadOnly = false;
                    Cb_MaNCC.Enabled = true;
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
                Txt_VT.ReadOnly = true;
                Btn_Sua.Text = "Xác Nhận";
            }

            else if (Btn_Sua.Text == "Xác Nhận")
            {
                bool rec = false;
                if (Txt_VT.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Chọn Mã Vật Tư", "Thông Báo");
                }
                else
                {
                    if (Txt_Ten.Text.Length == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập Tên Vật Tư", "Thông Báo");
                    }
                    else
                    {
                        if (Txt_Ten.Text.Length < 4)
                            MessageBox.Show("Vui Lòng Nhập Tên Vật Tư Trên 3 Ký Tự", "Thông Báo");
                        else
                        {
                            if (Txt_SL.Text.Length == 0)
                                MessageBox.Show("Vui Lòng Nhập Số Lượng Vật Tư", "Thông Báo");
                            else
                            {
                                if (Convert.ToInt32(Txt_SL.Text) > 100)
                                    MessageBox.Show("Vui Lòng Nhập Số Lượng Vật Tư Nhỏ Hơn 10", "Thông Báo");
                                else
                                {
                                    if (Txt_DonGia.Text.Length == 0)
                                        MessageBox.Show("Vui Lòng Nhập Đơn Giá", "Thông Báo");
                                    else
                                    {
                                        if (Convert.ToInt32(Txt_DonGia.Text) < 10000 && Convert.ToInt32(Txt_DonGia.Text) > 1000000)
                                            MessageBox.Show("Vui Lòng Nhập Đơn Giá Hơn 10000 Và Nhỏ Hơn 1000000 ", "Thông Báo");
                                        else
                                        {
                                            if (Cb_MaNCC.Text == "Vui Lòng Mã Nhà Cung Cấp")
                                                MessageBox.Show("Vui Lòng Chọn Nhà Cung Cấp", "Thông Báo");
                                            else
                                            {
                                                try
                                                {
                                                    rec = VTu.UpdateVatTu(Txt_VT.Text, Txt_Ten.Text, Cb_MaNCC.SelectedValue.ToString(), Convert.ToInt16(Txt_SL.Text), Convert.ToInt16(Txt_DonGia.Text));
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Không Sửa Được", "Thông Báo");
                                                }
                                                if (rec != false)
                                                {
                                                    MessageBox.Show("Bạn Đã Sửa Vật Tư Thành Công ", "Thông Báo");
                                                    load();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                                                }
                                                Btn_Xoa.Enabled = true;
                                                Btn_Tim.Enabled = true;
                                                Btn_Them.Enabled = true;
                                                Txt_VT.ReadOnly = false;
                                                Btn_Sua.Text = "Sửa";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Btn_Tim_Click(object sender, EventArgs e)
        {
            if (Btn_Tim.Text == "Tìm Kiếm")
            {
                DataTable db = (DataTable)DGV_VT.DataSource;
                db.DefaultView.RowFilter = String.Format("MaVT LIKE '%{0}%' And TenVT Like '%{1}%'And MaNCC Like '%{2}%' And CONVERT(SoLuong,System.String) LIKE '%{3}%' And CONVERT(Dongia,System.String) LIKE '%{4}%'  ", Txt_VT.Text, Txt_Ten.Text, Cb_MaNCC.SelectedValue, Txt_SL.Text, Txt_DonGia.Text);
                Btn_Tim.Text = "Xác Nhận";
                if (DGV_VT.Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Vật Tư Này", "Thông Báo");
                    load();
                    Btn_Tim.Text = "Tìm Kiếm";
                }
            }
            else
            {
                Btn_Tim.Text = "Tìm Kiếm";
                load();
            }
        }

        private void Txt_VT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
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

        private void Txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
            }
        }

        private void Txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
            }
        }

        private void DGV_VT_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_VT.SelectedRows)
            {
                Txt_VT.Text = row.Cells["MaVT"].Value.ToString();
                Txt_Ten.Text = row.Cells["TenVT"].Value.ToString();
                Cb_MaNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();
                Txt_SL.Text = row.Cells[5].Value.ToString();
                Txt_DonGia.Text = row.Cells["Dongia"].Value.ToString();
            }
        }

        private void Txt_VT_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_Ten_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_SL_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_DonGia_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }
    }
}
