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
    public partial class FrmBaoCaoTK : Form
    {
        public FrmBaoCaoTK()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoTK_Load(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            try
            {
                Lb_TKHoaDonTrongNgay.Text = "Tổng Số Tiền Hóa Đơn Trong Ngày: "+tk.BaoCaoTongTienHoaDonTrongNgay() + " Vnd";
                Lb_SoHDTrongNgay.Text = "Tổng Số Hóa Đơn Đã in Trong Ngày: "+tk.BaoCaoTongsoHoaDonTrongNgay() + " Hóa Đơn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Không Có Hóa Đơn Nào Trong Ngày Hôm Nay");
                this.Close();
            }
        }
    }
}
