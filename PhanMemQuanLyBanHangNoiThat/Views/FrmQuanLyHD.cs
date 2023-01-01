using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmQuanLyHD : Form
    {
        public FrmQuanLyHD()
        {
            InitializeComponent();
        }
        HoaDon Hoadon = new HoaDon();
        bool InputIsCommand = false;
        private void load()
        {
            DataTable HD, VT;
            HD = Hoadon.SelectHoaDon();
            DGV_HD.DataSource = HD;
            VT = Hoadon.SelectVatTu();
            Cb_VT.DataSource = VT;
            Cb_VT.DisplayMember = "TenVT";
            Cb_VT.ValueMember = "MaVT";
            Btn_Tim.Text = "Tìm Kiếm";
            Disable();
        }
        private void FrmQuanLyHD_Load(object sender, EventArgs e)
        {
            load();
        }
        private void clear_text()
        {
            Txt_MaHD.Text = "";
            Txt_MaKH.Text = "";
            Txt_SL.Text = "";
            Txt_TongTien.Text = "";
            Cb_VT.Text = "Vui Lòng Chọn Vật Tư";
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            int MaHD = 0;
            if (Btn_Them.Text == "Thêm")
            {
                Btn_Sua.Enabled = false;
                DGV_HD.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Xoa.Enabled = false;
                clear_text();
                Txt_MaHD.ReadOnly = true;
                Btn_Them.Text = "Xác Nhận Tạo Hóa Đơn";
            }

            else if (Btn_Them.Text == "Xác Nhận Tạo Hóa Đơn")
            {
                if (Txt_MaKH.Text.Length == 0)
                {
                    MessageBox.Show("Chưa Nhập Mã Khách Hàng", "Thông Báo");
                }
                else
                {
                    Txt_MaKH.Enabled = false;
                    bool rec = false;
                    try
                    {
                        rec = Hoadon.InsertHoaDon(DateTime.Now, Convert.ToInt32(Txt_MaKH.Text), 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không Thêm Được", "Thông Báo");
                    }
                    if (rec != false)
                    {
                        MessageBox.Show("Bạn Đã Thêm 1 Hóa Đơn Mới", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công", "Thông Báo");
                    }
                    MaHD = Hoadon.MaxHD();
                    Txt_MaHD.Text = MaHD.ToString();
                    Enable();
                    Btn_Them.Text = "Xác Nhận Hóa Đơn";
                }
            }
            else
            {
                if (DGV_CTHD.Rows.Count <= 0)
                {
                    MessageBox.Show("Vui Lòng Thêm Sản Phẩm", "Thông Báo");
                }
                else
                {
                    bool rec = false;
                    try
                    {
                        rec = Hoadon.UpdateHoaDonTien(Convert.ToInt32(Txt_MaHD.Text), Convert.ToInt32(Txt_TongTien.Text));
                    }
                    catch (Exception ex)
                    { }
                    if (rec != false)
                    {
                        MessageBox.Show("Bạn Đã in 1 Hóa Đơn Mới", "Thông Báo");
                        DGV_HD.Enabled = true;
                        ResetText();
                        Txt_MaHD.ReadOnly = false;
                        Btn_Sua.Enabled = true;
                        Btn_Tim.Enabled = true;
                        Btn_Xoa.Enabled = true;
                        Txt_MaKH.Enabled = true;
                        Btn_Them.Text = "Thêm";
                        load();
                    }
                    else
                    {
                        MessageBox.Show("in Không Thành Công", "Thông Báo");
                        DGV_HD.Enabled = true;
                        ResetText();
                        Txt_MaHD.ReadOnly = false;
                        Txt_MaKH.Enabled = true;
                        Btn_Sua.Enabled = true;
                        Btn_Tim.Enabled = true;
                        Btn_Xoa.Enabled = true;
                        Btn_Them.Text = "Thêm";
                        load();
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
                Txt_MaKH.ReadOnly = true;
                Txt_SL.ReadOnly = true;
                Txt_TongTien.ReadOnly = true;
                Cb_VT.Enabled = false;
                Txt_MaHD.ReadOnly = true;
                Btn_Xoa.Text = "Xác Nhận";
            }

            else if (Btn_Xoa.Text == "Xác Nhận")
            {
                bool rec = false;
                if (Txt_MaHD.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Hóa Đơn");
                }
                else
                {
                    try
                    {
                        rec = Hoadon.DeleteCTHoaDon(Convert.ToInt32(Txt_MaHD.Text));
                        rec = Hoadon.DeleteHoaDon(Convert.ToInt32(Txt_MaHD.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không Xóa Được", "Thông Báo");
                        load();
                    }
                    if (rec != false)
                    {
                        MessageBox.Show("Bạn Đã Xóa 1 Hóa Đơn", "Thông Báo");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Thông Báo");
                        load();
                    }
                    Btn_Sua.Enabled = true;
                    Btn_Tim.Enabled = true;
                    Btn_Them.Enabled = true;
                    Txt_MaKH.ReadOnly = false;
                    Txt_SL.ReadOnly = false;
                    Txt_MaHD.ReadOnly = false;
                    Txt_TongTien.ReadOnly = false;
                    Cb_VT.Enabled = true;
                    Btn_Xoa.Text = "Xóa";
                }
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (Btn_Sua.Text == "Sửa")
            {
                DGV_HD.Enabled = false;
                Btn_Xoa.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Them.Enabled = false;
                Txt_MaHD.ReadOnly = true;
                Enable();
                Btn_Sua.Text = "Xác Nhận";
            }
            else if (Btn_Sua.Text == "Xác Nhận")
            {
                bool rec = false;
                if (Txt_MaKH.Text.Length == 0)
                {
                    MessageBox.Show("Chưa Nhập Mã Khách Hàng", "Thông Báo");
                }
                else
                {
                    if (DGV_CTHD.Rows.Count == 0)
                    {
                        MessageBox.Show("Vui Lòng Thêm Sản Phẩm", "Thông Báo");
                    }
                    else
                    {
                        try
                        {
                            rec = Hoadon.UpdateHoaDon(Convert.ToInt32(Txt_MaHD.Text), Convert.ToInt32(Txt_MaKH.Text), Convert.ToInt32(Txt_TongTien.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sửa Không Được", "Thông Báo");
                        }
                        if (rec != false)
                        {
                            MessageBox.Show("Bạn Đã Sửa Hóa Đơn Thành Công", "Thông Báo");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                        }
                        Disable();
                        DGV_HD.Enabled = true;
                        Btn_Xoa.Enabled = true;
                        Btn_Tim.Enabled = true;
                        Btn_Them.Enabled = true;
                        Txt_MaHD.ReadOnly = false;
                        Btn_Sua.Text = "Sửa";
                    }
                }
            }
        }

        private void Btn_Tim_Click(object sender, EventArgs e)
        {
            if (Btn_Tim.Text == "Tìm Kiếm")
            {
                DataTable db = (DataTable)DGV_HD.DataSource;
                db.DefaultView.RowFilter = String.Format("CONVERT(MaHD,System.String) LIKE '%{0}%' And CONVERT(MaKH,System.String) LIKE '%{1}%'", Txt_MaHD.Text, Txt_MaKH.Text);
                if (DGV_HD.Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Hóa Đơn Này", "Thông Báo");
                    load();
                }
                Btn_Tim.Text = "Xác Nhận";
            }
            else
            {
                load();
            }
        }
        private void DGV_HD_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_HD.SelectedRows)
            {
                Txt_MaHD.Text = row.Cells["MaHD"].Value.ToString();
                Txt_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                Txt_TongTien.Text = row.Cells["TongTien"].Value.ToString();
            }
        }

        private void Txt_MaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
            }
        }

        private void Txt_VT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void Txt_MaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Nhập Mỗi Số", "Thông Báo");
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

        private void Txt_MaHD_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_MaKH_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_SL_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }
        private void Disable()
        {
            Btn_ThemHang.Enabled = false;
            Btn_XoaHang.Enabled = false;
            Cb_VT.Enabled = false;
            Txt_SL.Enabled = false;
        }
        private void Enable()
        {
            Btn_ThemHang.Enabled = true;
            Btn_XoaHang.Enabled = true;
            Cb_VT.Enabled = true;
            Txt_SL.Enabled = true;
        }
        private void loadcthd()
        {
            DataTable HD;
            try
            {
                HD = Hoadon.SelectCTHoaDon(Txt_MaHD.Text);
                DGV_CTHD.DataSource = HD;
            }
            catch (Exception ex)
            {
            }
        }
        String MACTHD = "";
        private void Txt_MaHD_TextChanged(object sender, EventArgs e)
        {
            loadcthd();
        }
        private void Btn_XoaHang_Click(object sender, EventArgs e)
        {
            bool rec = false;
            try
            {
                rec = Hoadon.DeleteCTHoaDon1(MACTHD);
                Hoadon.UpdateVTXoa(Cb_VT.SelectedValue.ToString(), Convert.ToInt32(Txt_SL.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Xóa Được Hàng Này", "Thông Báo");
            }
            if (rec != false)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Không Xóa Được Hàng Này", "Thông Báo");
            }
            loadcthd();
            try
            {
                Txt_TongTien.Text = Hoadon.SumTongTien(Convert.ToInt32(Txt_MaHD.Text)).ToString();
            }
            catch (Exception ex)
            {
                Txt_TongTien.Text = "0";
            }
        }

        private void Btn_ThemHang_Click(object sender, EventArgs e)
        {
            if (Cb_VT.Text == "Vui Lòng Chọn Vật Tư")
                MessageBox.Show("Chưa Chọn Vật Tư", "Thông Báo");
            else
            {
                if (Txt_SL.Text.Length == 0)
                    MessageBox.Show("Chưa Nhập Số Lượng", "Thông Báo");
                else
                {
                    if (Convert.ToInt32(Hoadon.SLVT(Cb_VT.SelectedValue.ToString())) <= 0)
                        MessageBox.Show("Số Lượng Hàng Đã Hết Cần Nhập Thêm Vui Lòng Lựa Hàng Khác", "Thông Báo");
                    else
                    {
                        if (Convert.ToInt16(Txt_SL.Text) > Hoadon.SLVT(Cb_VT.SelectedValue.ToString()) || Convert.ToInt16(Txt_SL.Text) == 0)
                            MessageBox.Show("Số Lượng Phải Lớn Hơn 0 Và Phải Ít Hơn Hoặc Bằng " + Hoadon.SLVT(Cb_VT.SelectedValue.ToString()), "Thông Báo");
                        else
                        {
                            bool rec = false;
                            try
                            {
                                int Dongia = Hoadon.SelectDongia(Cb_VT.SelectedValue.ToString());
                                rec = Hoadon.InsertCTHoaDon(Txt_MaHD.Text, Convert.ToInt32(Txt_SL.Text), Cb_VT.SelectedValue.ToString(), Dongia);
                                Hoadon.UpdateVTThem(Cb_VT.SelectedValue.ToString(), Convert.ToInt32(Txt_SL.Text));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không Thêm Được Hàng Này", "Thông Báo");
                            }
                            if (rec != false)
                                MessageBox.Show("Thêm Hàng Thành Công", "Thông Báo");
                            else
                                MessageBox.Show("Thêm Hàng Không Thành Công", "Thông Báo");
                            loadcthd();
                            try
                            {
                                Txt_TongTien.Text = Hoadon.SumTongTien(Convert.ToInt32(Txt_MaHD.Text)).ToString();
                            }
                            catch (Exception ex)
                            {
                                Txt_TongTien.Text = "0";
                            }
                        }
                    }
                }
            }
        }
        private void DGV_CTHD_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_CTHD.SelectedRows)
            {
                MACTHD = row.Cells["MaCTHD"].Value.ToString();
                Cb_VT.SelectedValue = row.Cells["MaVT"].Value.ToString();
                Txt_SL.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }
    }
}
