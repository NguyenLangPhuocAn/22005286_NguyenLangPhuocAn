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
    public partial class Frm_QL : Form
    {
        private String QuyenNV,MaNV;
        public Frm_QL(string quyen,string manv)
        {
            InitializeComponent();
            QuyenNV = quyen;
            MaNV = manv;
            FormLoad();
        }
        private new Form ActiveForm;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lb_ThoiGian.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        void FormLoad()
        {
            if (QuyenNV == "QuanLy")
            {
                Btn_HD.Visible = false;
                Btn_KH.Visible = false;
                Btn_VT.Visible = false;
                Btn_NhaCC.Visible = false;
            }
            else
            {
                if (QuyenNV == "NhanVien")
                {
                    Btn_VT.Visible = false;
                    Btn_TK.Visible = false;
                    Btn_NV.Visible = false;
                    Btn_CapMK.Visible = false;
                    Btn_NhaCC.Visible = false;
                }
                else
                {
                    if (QuyenNV == "NVKHO")
                    {
                        Btn_HD.Visible = false;
                        Btn_TK.Visible = false;
                        Btn_NV.Visible = false;
                        Btn_CapMK.Visible = false;
                        Btn_KH.Visible = false;
                    }
                }
            }
            timer1.Start();
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {

          
        }
        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Panel_Form.Controls.Add(childForm);
            this.Panel_Form.Tag = childForm;
            childForm.BackColor = this.Panel_Form.BackColor;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_NV_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FrmQuanLyNV());
        }

        private void Btn_HD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyHD());
        }

        private void Btn_KH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyKH());
        }

        private void Btn_NhaCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyNhaCungCap());
        }

        private void Btn_VT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyVatTu());
        }

        private void Btn_TK_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new FrmBaoCaoTK());
            }
            catch (Exception ex)
            {
            }
        }

        private void Btn_Size_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                 if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void Btn_Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form());
        }

        private void Btn_CapMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCapLaiMK());
        }

        private void Btn_DatMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDatLaiMK(MaNV));
        }
    }
}
