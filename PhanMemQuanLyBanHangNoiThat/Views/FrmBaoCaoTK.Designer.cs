
namespace PhanMemQuanLyBanHangNoiThat.Views
{
    partial class FrmBaoCaoTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoTK));
            this.Lb_TKHoaDonTrongNgay = new System.Windows.Forms.Label();
            this.Lb_SoHDTrongNgay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_TKHoaDonTrongNgay
            // 
            this.Lb_TKHoaDonTrongNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_TKHoaDonTrongNgay.AutoSize = true;
            this.Lb_TKHoaDonTrongNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_TKHoaDonTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Lb_TKHoaDonTrongNgay.ForeColor = System.Drawing.Color.Orange;
            this.Lb_TKHoaDonTrongNgay.Location = new System.Drawing.Point(74, 336);
            this.Lb_TKHoaDonTrongNgay.Name = "Lb_TKHoaDonTrongNgay";
            this.Lb_TKHoaDonTrongNgay.Size = new System.Drawing.Size(0, 39);
            this.Lb_TKHoaDonTrongNgay.TabIndex = 0;
            // 
            // Lb_SoHDTrongNgay
            // 
            this.Lb_SoHDTrongNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_SoHDTrongNgay.AutoSize = true;
            this.Lb_SoHDTrongNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_SoHDTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Lb_SoHDTrongNgay.ForeColor = System.Drawing.Color.Orange;
            this.Lb_SoHDTrongNgay.Location = new System.Drawing.Point(74, 9);
            this.Lb_SoHDTrongNgay.Name = "Lb_SoHDTrongNgay";
            this.Lb_SoHDTrongNgay.Size = new System.Drawing.Size(0, 39);
            this.Lb_SoHDTrongNgay.TabIndex = 1;
            // 
            // FrmBaoCaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lb_SoHDTrongNgay);
            this.Controls.Add(this.Lb_TKHoaDonTrongNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBaoCaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.FrmBaoCaoTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_TKHoaDonTrongNgay;
        private System.Windows.Forms.Label Lb_SoHDTrongNgay;
    }
}