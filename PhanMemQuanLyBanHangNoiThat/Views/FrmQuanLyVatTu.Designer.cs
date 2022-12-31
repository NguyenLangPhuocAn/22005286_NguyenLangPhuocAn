
namespace PhanMemQuanLyBanHangNoiThat.Views
{
    partial class FrmQuanLyVatTu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyVatTu));
            this.Txt_Ten = new System.Windows.Forms.TextBox();
            this.Lb_Ten = new System.Windows.Forms.Label();
            this.Btn_Tim = new System.Windows.Forms.Button();
            this.Txt_VT = new System.Windows.Forms.TextBox();
            this.lb_VT = new System.Windows.Forms.Label();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.DGV_VT = new System.Windows.Forms.DataGridView();
            this.LB_QLVT = new System.Windows.Forms.Label();
            this.Lb_NCC = new System.Windows.Forms.Label();
            this.Cb_MaNCC = new System.Windows.Forms.ComboBox();
            this.Txt_SL = new System.Windows.Forms.TextBox();
            this.Lb_SL = new System.Windows.Forms.Label();
            this.lb_Dongia = new System.Windows.Forms.Label();
            this.Txt_DonGia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaVt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Ten
            // 
            this.Txt_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Ten.Location = new System.Drawing.Point(99, 51);
            this.Txt_Ten.MaxLength = 36;
            this.Txt_Ten.Name = "Txt_Ten";
            this.Txt_Ten.ShortcutsEnabled = false;
            this.Txt_Ten.Size = new System.Drawing.Size(536, 20);
            this.Txt_Ten.TabIndex = 49;
            this.Txt_Ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Ten_KeyDown);
            this.Txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ten_KeyPress);
            // 
            // Lb_Ten
            // 
            this.Lb_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Ten.AutoSize = true;
            this.Lb_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Lb_Ten.ForeColor = System.Drawing.Color.DarkOrange;
            this.Lb_Ten.Location = new System.Drawing.Point(39, 45);
            this.Lb_Ten.Name = "Lb_Ten";
            this.Lb_Ten.Size = new System.Drawing.Size(54, 26);
            this.Lb_Ten.TabIndex = 46;
            this.Lb_Ten.Text = "Tên:";
            // 
            // Btn_Tim
            // 
            this.Btn_Tim.BackColor = System.Drawing.Color.Orange;
            this.Btn_Tim.FlatAppearance.BorderSize = 0;
            this.Btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Tim.ForeColor = System.Drawing.Color.White;
            this.Btn_Tim.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.find;
            this.Btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Tim.Location = new System.Drawing.Point(334, 490);
            this.Btn_Tim.Name = "Btn_Tim";
            this.Btn_Tim.Size = new System.Drawing.Size(101, 34);
            this.Btn_Tim.TabIndex = 59;
            this.Btn_Tim.Text = "Tìm Kiếm";
            this.Btn_Tim.UseVisualStyleBackColor = false;
            this.Btn_Tim.Click += new System.EventHandler(this.Btn_Tim_Click);
            // 
            // Txt_VT
            // 
            this.Txt_VT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_VT.Location = new System.Drawing.Point(99, 12);
            this.Txt_VT.MaxLength = 5;
            this.Txt_VT.Name = "Txt_VT";
            this.Txt_VT.ShortcutsEnabled = false;
            this.Txt_VT.Size = new System.Drawing.Size(536, 20);
            this.Txt_VT.TabIndex = 58;
            this.Txt_VT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_VT_KeyDown);
            this.Txt_VT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_VT_KeyPress);
            // 
            // lb_VT
            // 
            this.lb_VT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_VT.AutoSize = true;
            this.lb_VT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lb_VT.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_VT.Location = new System.Drawing.Point(12, 12);
            this.lb_VT.Name = "lb_VT";
            this.lb_VT.Size = new System.Drawing.Size(81, 26);
            this.lb_VT.TabIndex = 57;
            this.lb_VT.Text = "Mã VT:";
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.Orange;
            this.Btn_Sua.FlatAppearance.BorderSize = 0;
            this.Btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sua.ForeColor = System.Drawing.Color.White;
            this.Btn_Sua.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.modify;
            this.Btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sua.Location = new System.Drawing.Point(227, 490);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(101, 34);
            this.Btn_Sua.TabIndex = 55;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.Orange;
            this.Btn_Xoa.FlatAppearance.BorderSize = 0;
            this.Btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.Btn_Xoa.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.delete;
            this.Btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Xoa.Location = new System.Drawing.Point(120, 490);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(101, 34);
            this.Btn_Xoa.TabIndex = 54;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.Orange;
            this.Btn_Them.FlatAppearance.BorderSize = 0;
            this.Btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Them.ForeColor = System.Drawing.Color.White;
            this.Btn_Them.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.add;
            this.Btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Them.Location = new System.Drawing.Point(13, 490);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(101, 34);
            this.Btn_Them.TabIndex = 53;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // DGV_VT
            // 
            this.DGV_VT.AllowUserToAddRows = false;
            this.DGV_VT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_VT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_VT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_VT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VT.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_VT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_VT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_VT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVt,
            this.TenVT,
            this.MaNCC,
            this.TenNCC,
            this.SL,
            this.DonGia});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_VT.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_VT.Location = new System.Drawing.Point(13, 231);
            this.DGV_VT.MultiSelect = false;
            this.DGV_VT.Name = "DGV_VT";
            this.DGV_VT.ReadOnly = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_VT.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_VT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VT.Size = new System.Drawing.Size(647, 253);
            this.DGV_VT.TabIndex = 52;
            this.DGV_VT.SelectionChanged += new System.EventHandler(this.DGV_VT_SelectionChanged);
            // 
            // LB_QLVT
            // 
            this.LB_QLVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_QLVT.AutoSize = true;
            this.LB_QLVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_QLVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.LB_QLVT.ForeColor = System.Drawing.Color.DarkOrange;
            this.LB_QLVT.Location = new System.Drawing.Point(171, 9);
            this.LB_QLVT.Name = "LB_QLVT";
            this.LB_QLVT.Size = new System.Drawing.Size(254, 39);
            this.LB_QLVT.TabIndex = 45;
            this.LB_QLVT.Text = "Quản Lý Vật Tư";
            // 
            // Lb_NCC
            // 
            this.Lb_NCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_NCC.AutoSize = true;
            this.Lb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Lb_NCC.ForeColor = System.Drawing.Color.DarkOrange;
            this.Lb_NCC.Location = new System.Drawing.Point(12, 76);
            this.Lb_NCC.Name = "Lb_NCC";
            this.Lb_NCC.Size = new System.Drawing.Size(198, 26);
            this.Lb_NCC.TabIndex = 60;
            this.Lb_NCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // Cb_MaNCC
            // 
            this.Cb_MaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_MaNCC.FormattingEnabled = true;
            this.Cb_MaNCC.Location = new System.Drawing.Point(217, 80);
            this.Cb_MaNCC.Name = "Cb_MaNCC";
            this.Cb_MaNCC.Size = new System.Drawing.Size(418, 21);
            this.Cb_MaNCC.TabIndex = 61;
            this.Cb_MaNCC.Text = "Vui Lòng Chọn Mã Nhà Cung Cấp";
            // 
            // Txt_SL
            // 
            this.Txt_SL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txt_SL.Location = new System.Drawing.Point(120, 115);
            this.Txt_SL.MaxLength = 10;
            this.Txt_SL.Name = "Txt_SL";
            this.Txt_SL.ShortcutsEnabled = false;
            this.Txt_SL.Size = new System.Drawing.Size(132, 20);
            this.Txt_SL.TabIndex = 62;
            this.Txt_SL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SL_KeyDown);
            this.Txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SL_KeyPress);
            // 
            // Lb_SL
            // 
            this.Lb_SL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lb_SL.AutoSize = true;
            this.Lb_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Lb_SL.ForeColor = System.Drawing.Color.DarkOrange;
            this.Lb_SL.Location = new System.Drawing.Point(3, 109);
            this.Lb_SL.Name = "Lb_SL";
            this.Lb_SL.Size = new System.Drawing.Size(111, 26);
            this.Lb_SL.TabIndex = 63;
            this.Lb_SL.Text = "Số Lượng:";
            // 
            // lb_Dongia
            // 
            this.lb_Dongia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Dongia.AutoSize = true;
            this.lb_Dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lb_Dongia.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_Dongia.Location = new System.Drawing.Point(258, 109);
            this.lb_Dongia.Name = "lb_Dongia";
            this.lb_Dongia.Size = new System.Drawing.Size(98, 26);
            this.lb_Dongia.TabIndex = 65;
            this.lb_Dongia.Text = "Đơn Giá:";
            // 
            // Txt_DonGia
            // 
            this.Txt_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_DonGia.Location = new System.Drawing.Point(362, 115);
            this.Txt_DonGia.MaxLength = 10;
            this.Txt_DonGia.Name = "Txt_DonGia";
            this.Txt_DonGia.ShortcutsEnabled = false;
            this.Txt_DonGia.Size = new System.Drawing.Size(137, 20);
            this.Txt_DonGia.TabIndex = 64;
            this.Txt_DonGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_DonGia_KeyDown);
            this.Txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DonGia_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lb_VT);
            this.panel1.Controls.Add(this.lb_Dongia);
            this.panel1.Controls.Add(this.Txt_VT);
            this.panel1.Controls.Add(this.Txt_DonGia);
            this.panel1.Controls.Add(this.Lb_Ten);
            this.panel1.Controls.Add(this.Lb_SL);
            this.panel1.Controls.Add(this.Txt_Ten);
            this.panel1.Controls.Add(this.Txt_SL);
            this.panel1.Controls.Add(this.Lb_NCC);
            this.panel1.Controls.Add(this.Cb_MaNCC);
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 174);
            this.panel1.TabIndex = 66;
            // 
            // MaVt
            // 
            this.MaVt.DataPropertyName = "MaVT";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightPink;
            this.MaVt.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaVt.HeaderText = "Mã Vật Tư";
            this.MaVt.Name = "MaVt";
            this.MaVt.ReadOnly = true;
            // 
            // TenVT
            // 
            this.TenVT.DataPropertyName = "TenVT";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightPink;
            this.TenVT.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenVT.HeaderText = "Tên Vật Tư";
            this.TenVT.Name = "TenVT";
            this.TenVT.ReadOnly = true;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightPink;
            this.MaNCC.DefaultCellStyle = dataGridViewCellStyle5;
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LightPink;
            this.TenNCC.DefaultCellStyle = dataGridViewCellStyle6;
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuong";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LightPink;
            this.SL.DefaultCellStyle = dataGridViewCellStyle7;
            this.SL.HeaderText = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "Dongia";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle8;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // FrmQuanLyVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Tim);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.DGV_VT);
            this.Controls.Add(this.LB_QLVT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý Vật Tư";
            this.Load += new System.EventHandler(this.FrmQuanLyVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Ten;
        private System.Windows.Forms.Label Lb_Ten;
        private System.Windows.Forms.Button Btn_Tim;
        private System.Windows.Forms.TextBox Txt_VT;
        private System.Windows.Forms.Label lb_VT;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.DataGridView DGV_VT;
        private System.Windows.Forms.Label LB_QLVT;
        private System.Windows.Forms.Label Lb_NCC;
        private System.Windows.Forms.ComboBox Cb_MaNCC;
        private System.Windows.Forms.TextBox Txt_SL;
        private System.Windows.Forms.Label Lb_SL;
        private System.Windows.Forms.Label lb_Dongia;
        private System.Windows.Forms.TextBox Txt_DonGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}