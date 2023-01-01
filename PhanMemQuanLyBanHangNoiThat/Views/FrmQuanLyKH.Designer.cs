
namespace PhanMemQuanLyBanHangNoiThat.Views
{
    partial class FrmQuanLyKH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKH));
            this.LB_QLKH = new System.Windows.Forms.Label();
            this.DGV_KH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Tim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_SDT = new System.Windows.Forms.TextBox();
            this.Txt_DiaChi = new System.Windows.Forms.TextBox();
            this.Txt_Ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_MaKh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_KH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_QLKH
            // 
            this.LB_QLKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_QLKH.AutoSize = true;
            this.LB_QLKH.BackColor = System.Drawing.Color.Transparent;
            this.LB_QLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.LB_QLKH.ForeColor = System.Drawing.Color.Wheat;
            this.LB_QLKH.Location = new System.Drawing.Point(277, 9);
            this.LB_QLKH.Name = "LB_QLKH";
            this.LB_QLKH.Size = new System.Drawing.Size(342, 39);
            this.LB_QLKH.TabIndex = 0;
            this.LB_QLKH.Text = "Quản Lý Khách Hàng";
            // 
            // DGV_KH
            // 
            this.DGV_KH.AllowUserToAddRows = false;
            this.DGV_KH.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_KH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_KH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_KH.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_KH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_KH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChi,
            this.SDT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_KH.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_KH.Location = new System.Drawing.Point(12, 232);
            this.DGV_KH.MultiSelect = false;
            this.DGV_KH.Name = "DGV_KH";
            this.DGV_KH.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_KH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_KH.Size = new System.Drawing.Size(890, 253);
            this.DGV_KH.TabIndex = 7;
            this.DGV_KH.SelectionChanged += new System.EventHandler(this.DGV_KH_SelectionChanged);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Them.FlatAppearance.BorderSize = 0;
            this.Btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Them.ForeColor = System.Drawing.Color.White;
            this.Btn_Them.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.add;
            this.Btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Them.Location = new System.Drawing.Point(13, 491);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(101, 34);
            this.Btn_Them.TabIndex = 8;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Xoa.FlatAppearance.BorderSize = 0;
            this.Btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.Btn_Xoa.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.delete;
            this.Btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Xoa.Location = new System.Drawing.Point(120, 491);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(101, 34);
            this.Btn_Xoa.TabIndex = 9;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Sua.FlatAppearance.BorderSize = 0;
            this.Btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sua.ForeColor = System.Drawing.Color.White;
            this.Btn_Sua.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.modify;
            this.Btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sua.Location = new System.Drawing.Point(227, 491);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(101, 34);
            this.Btn_Sua.TabIndex = 10;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Tim
            // 
            this.Btn_Tim.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Tim.FlatAppearance.BorderSize = 0;
            this.Btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Tim.ForeColor = System.Drawing.Color.White;
            this.Btn_Tim.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.find;
            this.Btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Tim.Location = new System.Drawing.Point(334, 491);
            this.Btn_Tim.Name = "Btn_Tim";
            this.Btn_Tim.Size = new System.Drawing.Size(101, 34);
            this.Btn_Tim.TabIndex = 14;
            this.Btn_Tim.Text = "Tìm Kiếm";
            this.Btn_Tim.UseVisualStyleBackColor = false;
            this.Btn_Tim.Click += new System.EventHandler(this.Btn_Tim_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(277, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản Lý Khách Hàng";
            // 
            // Txt_SDT
            // 
            this.Txt_SDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_SDT.Location = new System.Drawing.Point(103, 138);
            this.Txt_SDT.MaxLength = 10;
            this.Txt_SDT.Name = "Txt_SDT";
            this.Txt_SDT.ShortcutsEnabled = false;
            this.Txt_SDT.Size = new System.Drawing.Size(541, 20);
            this.Txt_SDT.TabIndex = 6;
            this.Txt_SDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SDT_KeyDown);
            this.Txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SDT_KeyPress);
            // 
            // Txt_DiaChi
            // 
            this.Txt_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_DiaChi.Location = new System.Drawing.Point(103, 102);
            this.Txt_DiaChi.MaxLength = 50;
            this.Txt_DiaChi.Name = "Txt_DiaChi";
            this.Txt_DiaChi.ShortcutsEnabled = false;
            this.Txt_DiaChi.Size = new System.Drawing.Size(541, 20);
            this.Txt_DiaChi.TabIndex = 5;
            this.Txt_DiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_DiaChi_KeyDown);
            this.Txt_DiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DiaChi_KeyPress);
            // 
            // Txt_Ten
            // 
            this.Txt_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Ten.Location = new System.Drawing.Point(103, 67);
            this.Txt_Ten.MaxLength = 36;
            this.Txt_Ten.Name = "Txt_Ten";
            this.Txt_Ten.ShortcutsEnabled = false;
            this.Txt_Ten.Size = new System.Drawing.Size(541, 20);
            this.Txt_Ten.TabIndex = 4;
            this.Txt_Ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Ten_KeyDown);
            this.Txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ten_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "SDT:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ:";
            // 
            // Txt_MaKh
            // 
            this.Txt_MaKh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MaKh.Location = new System.Drawing.Point(103, 27);
            this.Txt_MaKh.MaxLength = 10;
            this.Txt_MaKh.Name = "Txt_MaKh";
            this.Txt_MaKh.ShortcutsEnabled = false;
            this.Txt_MaKh.Size = new System.Drawing.Size(541, 20);
            this.Txt_MaKh.TabIndex = 13;
            this.Txt_MaKh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MaKh_KeyDown);
            this.Txt_MaKh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MaKh_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã KH:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_MaKh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Ten);
            this.panel1.Controls.Add(this.Txt_DiaChi);
            this.panel1.Controls.Add(this.Txt_SDT);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 175);
            this.panel1.TabIndex = 15;
            // 
            // FrmQuanLyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Tim);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.DGV_KH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_QLKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "a";
            this.Load += new System.EventHandler(this.FrmQuanLyKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_KH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_QLKH;
        private System.Windows.Forms.DataGridView DGV_KH;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Tim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_SDT;
        private System.Windows.Forms.TextBox Txt_DiaChi;
        private System.Windows.Forms.TextBox Txt_Ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_MaKh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}