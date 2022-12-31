using PhanMemQuanLyBanHangNoiThat.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhanMemQuanLyBanHangNoiThat.Views
{
    public partial class FrmQuanLyNV : Form
    {
        NhanVien nv = new NhanVien();
        bool InputIsCommand = false;
        public FrmQuanLyNV()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataTable db, db1, db2;
            db = nv.SelectNhanVien();
            DGV_NV.DataSource = db;
            db2 = nv.LayGhiChu();
            DGV_CapMK.DataSource = db2;
            db1 = nv.SelectMaCV();
            CB_CV.DataSource = db1;
            CB_CV.DisplayMember = "TenCV";
            CB_CV.ValueMember = "MaCV";
            Btn_Tim.Text = "Tìm Kiếm";
        }
        private void FrmQuanLyNV_Load(object sender, EventArgs e)
        {
            load();
            clear_text();
        }
        private void clear_text()
        {
            Txt_Ten.Text = "";
            Txt_MaNV.Text = "";
            DTP_NS.ResetText();
            CB_CV.Text = "Vui Lòng Chọn Tên Chức Vụ";
        }

        private void Txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Không Nhập Chữ", "Thông Báo");
            }
        }

        private void Txt_Ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = InputIsCommand;
            if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Không Nhập Số", "Thông Báo");
            }
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            if (Btn_Them.Text == "Thêm")
            {
                Btn_Sua.Enabled = false;
                Btn_Tim.Enabled = false;
                Btn_Xoa.Enabled = false;
                clear_text();
                DataTable dbmax;
                dbmax = nv.LayMax();
                int MaNV = Convert.ToInt32(dbmax.Rows[0]["MaNV"]) + 1;
                Txt_MaNV.Text = Convert.ToString(MaNV);
                Txt_MaNV.ReadOnly = true;
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
                    if (DTP_NS.Value.Year > DateTime.Today.Year - 18)
                    {
                        MessageBox.Show("Chưa Đủ 18 Tuổi", "Thông Báo");
                    }
                    else
                    {
                        if (CB_CV.Text == "Vui Lòng Chọn Tên Chức Vụ")
                            MessageBox.Show("Vui Lòng Chọn Chức Vụ", "Thông Báo");
                        else
                        {
                            bool rec = false;
                            try
                            {
                                rec = nv.InsertNhanVien(Txt_MaNV.Text, Txt_Ten.Text, DTP_NS.Value, Convert.ToInt32(CB_CV.SelectedValue.ToString()));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không Thêm Được", "Thông Báo");
                            }
                            if (rec != false)
                            {
                                MessageBox.Show("Bạn Đã Thêm 1 Nhân Viên Mới", "Thông Báo");
                                load();
                            }
                            else
                            {
                                MessageBox.Show("Thêm Không Thành Công", "Thông Báo");
                            }
                            Btn_Sua.Enabled = true;
                            Btn_Tim.Enabled = true;
                            Btn_Xoa.Enabled = true;
                            Txt_MaNV.ReadOnly = false;
                            Btn_Them.Text = "Thêm";
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
                DTP_NS.Enabled = false;
                CB_CV.Enabled = false;
                Txt_MaNV.Enabled = false;
                Btn_Xoa.Text = "Xác Nhận";
            }

            else if (Btn_Xoa.Text == "Xác Nhận")
            {
                bool rec = false;
                bool rec1 = false;
                foreach (DataGridViewRow row in DGV_CapMK.Rows)
                {
                    if (Txt_MaNV.Text == row.Cells[0].Value.ToString())
                    {
                        rec1 = true;
                    }
                }
                try
                {
                    if (rec1 == true)
                    {
                       rec1=nv.DeleteUsers(Txt_MaNV.Text);
                    }
                    rec = nv.DeleteNhanVien(Txt_MaNV.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không Xóa Được", "Thông Báo");
                }
                if (rec != false || rec1 != false)
                {
                    MessageBox.Show("Bạn Đã Xóa 1 Nhân Viên", "Thông Báo");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công", "Thông Báo");
                }
                Btn_Sua.Enabled = true;
                Btn_Tim.Enabled = true;
                Btn_Them.Enabled = true;
                Txt_Ten.ReadOnly = false;
                DTP_NS.Enabled = true;
                Txt_MaNV.Enabled = true;
                CB_CV.Enabled = true;
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
                Txt_MaNV.ReadOnly = true;
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
                    if (Txt_Ten.Text.Length <= 4)
                        MessageBox.Show("Vui Lòng Nhập Tên Trên 4 Ký Tự", "Thông Báo");
                    else
                    {
                        if (DTP_NS.Value.Year > DateTime.Today.Year - 18)
                        {
                            MessageBox.Show("Chưa Đủ 18 Tuổi", "Thông Báo");
                        }
                        else
                        {
                            if (CB_CV.Text == "Vui Lòng Chọn Tên Chức Vụ")
                                MessageBox.Show("Vui Lòng Chọn Chức Vụ", "Thông Báo");
                            else
                            {
                                bool rec = false;
                                try
                                {
                                    rec = nv.UpdateNhanVien(Txt_MaNV.Text, Txt_Ten.Text, DTP_NS.Value, Convert.ToInt32(CB_CV.SelectedValue.ToString()));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Không Sửa Được", "Thông Báo");
                                }
                                if (rec != false)
                                {
                                    MessageBox.Show("Bạn Sửa Nhân Viên Thành công ", "Thông Báo");
                                    load();
                                }
                                else
                                {
                                    MessageBox.Show("Sửa Không Thành Công", "Thông Báo");
                                }
                                Btn_Xoa.Enabled = true;
                                Btn_Tim.Enabled = true;
                                Btn_Them.Enabled = true;
                                Txt_MaNV.ReadOnly = false;
                                Btn_Sua.Text = "Sửa";
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
                DataTable db = (DataTable)DGV_NV.DataSource;
                db.DefaultView.RowFilter = String.Format("MaNV LIKE '%{0}%' And TenNV LIKE '%{1}%' And CONVERT(MaCV,System.String) LIKE '%{2}%'", Txt_MaNV.Text, Txt_Ten.Text, CB_CV.SelectedValue);
                if (DGV_NV.Rows.Count == 0)
                {
                    MessageBox.Show("Không Có Nhân Viên Này", "Thông Báo");
                    load();
                }
                Btn_Tim.Text = "Xác Nhận";
            }
            else
                load();
        }

        private void DGV_NV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_NV.SelectedRows)
            {
                Txt_MaNV.Text = row.Cells["MaNV"].Value.ToString();
                Txt_Ten.Text = row.Cells["TenNV"].Value.ToString().Trim();
                DTP_NS.Text = row.Cells[2].Value.ToString();
                CB_CV.SelectedValue = row.Cells["MaCV"].Value.ToString();
            }
        }
        private void Txt_MaNV_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Txt_Ten_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void Btn_CapMK_Click(object sender, EventArgs e)
        {
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
                    DataTable db = (DataTable)DGV_NV.DataSource;
                    db.DefaultView.RowFilter = String.Format("MaNV ='{0}'", Txt_MaNV.Text);
                    if (DGV_NV.Rows.Count == 0)
                    {
                        MessageBox.Show("Không Có Nhân Viên Này", "Thông Báo");
                    }
                    else
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
                            nv.CapMK(Txt_MaNV.Text, Pass);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không Cấp Mật Khẩu Được", "Thông Báo");
                        }
                    }
                    load();
                }
            }
        }
    }
}
