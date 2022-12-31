
namespace PhanMemQuanLyBanHangNoiThat.Views
{
    partial class FrmQuanLyNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNV));
            this.Txt_MaNV = new System.Windows.Forms.TextBox();
            this.Txt_Ten = new System.Windows.Forms.TextBox();
            this.LB_QLKH = new System.Windows.Forms.Label();
            this.DTP_NS = new System.Windows.Forms.DateTimePicker();
            this.CB_CV = new System.Windows.Forms.ComboBox();
            this.DGV_NV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Tim = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_CapMK = new System.Windows.Forms.Button();
            this.DGV_CapMK = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CapMK)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_MaNV
            // 
            this.Txt_MaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_MaNV.Location = new System.Drawing.Point(129, 23);
            this.Txt_MaNV.MaxLength = 16;
            this.Txt_MaNV.Name = "Txt_MaNV";
            this.Txt_MaNV.ShortcutsEnabled = false;
            this.Txt_MaNV.Size = new System.Drawing.Size(857, 20);
            this.Txt_MaNV.TabIndex = 28;
            this.Txt_MaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MaNV_KeyDown);
            this.Txt_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MaNV_KeyPress);
            // 
            // Txt_Ten
            // 
            this.Txt_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Ten.Location = new System.Drawing.Point(129, 59);
            this.Txt_Ten.MaxLength = 36;
            this.Txt_Ten.Name = "Txt_Ten";
            this.Txt_Ten.ShortcutsEnabled = false;
            this.Txt_Ten.Size = new System.Drawing.Size(857, 20);
            this.Txt_Ten.TabIndex = 19;
            this.Txt_Ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Ten_KeyDown);
            this.Txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ten_KeyPress);
            // 
            // LB_QLKH
            // 
            this.LB_QLKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LB_QLKH.AutoSize = true;
            this.LB_QLKH.BackColor = System.Drawing.Color.Transparent;
            this.LB_QLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_QLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.LB_QLKH.ForeColor = System.Drawing.Color.Orange;
            this.LB_QLKH.Location = new System.Drawing.Point(321, 9);
            this.LB_QLKH.Name = "LB_QLKH";
            this.LB_QLKH.Size = new System.Drawing.Size(314, 39);
            this.LB_QLKH.TabIndex = 15;
            this.LB_QLKH.Text = "Quản Lý Nhân Viên";
            // 
            // DTP_NS
            // 
            this.DTP_NS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_NS.Location = new System.Drawing.Point(129, 91);
            this.DTP_NS.Name = "DTP_NS";
            this.DTP_NS.Size = new System.Drawing.Size(857, 20);
            this.DTP_NS.TabIndex = 30;
            // 
            // CB_CV
            // 
            this.CB_CV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_CV.FormattingEnabled = true;
            this.CB_CV.Location = new System.Drawing.Point(129, 125);
            this.CB_CV.Name = "CB_CV";
            this.CB_CV.Size = new System.Drawing.Size(857, 21);
            this.CB_CV.TabIndex = 31;
            this.CB_CV.Text = "Vui Lòng Chọn Tên Chức Vụ";
            // 
            // DGV_NV
            // 
            this.DGV_NV.AllowUserToAddRows = false;
            this.DGV_NV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_NV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_NV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_NV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_NV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NS,
            this.MaCV,
            this.TenCV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_NV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_NV.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGV_NV.Location = new System.Drawing.Point(12, 240);
            this.DGV_NV.MultiSelect = false;
            this.DGV_NV.Name = "DGV_NV";
            this.DGV_NV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_NV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_NV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_NV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_NV.ShowEditingIcon = false;
            this.DGV_NV.Size = new System.Drawing.Size(805, 214);
            this.DGV_NV.TabIndex = 22;
            this.DGV_NV.SelectionChanged += new System.EventHandler(this.DGV_NV_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Txt_MaNV);
            this.panel1.Controls.Add(this.CB_CV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DTP_NS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Ten);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 160);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(38, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên CV:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(38, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã NV:";
            // 
            // Btn_Tim
            // 
            this.Btn_Tim.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Tim.ForeColor = System.Drawing.Color.Honeydew;
            this.Btn_Tim.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.find;
            this.Btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Tim.Location = new System.Drawing.Point(333, 460);
            this.Btn_Tim.Name = "Btn_Tim";
            this.Btn_Tim.Size = new System.Drawing.Size(101, 34);
            this.Btn_Tim.TabIndex = 29;
            this.Btn_Tim.Text = "Tìm Kiếm";
            this.Btn_Tim.UseVisualStyleBackColor = false;
            this.Btn_Tim.Click += new System.EventHandler(this.Btn_Tim_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sua.ForeColor = System.Drawing.Color.Honeydew;
            this.Btn_Sua.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.modify;
            this.Btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sua.Location = new System.Drawing.Point(226, 460);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(101, 34);
            this.Btn_Sua.TabIndex = 25;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Xoa.ForeColor = System.Drawing.Color.Honeydew;
            this.Btn_Xoa.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.delete;
            this.Btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Xoa.Location = new System.Drawing.Point(119, 460);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(101, 34);
            this.Btn_Xoa.TabIndex = 24;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Them.ForeColor = System.Drawing.Color.Honeydew;
            this.Btn_Them.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.add;
            this.Btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Them.Location = new System.Drawing.Point(12, 460);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(101, 34);
            this.Btn_Them.TabIndex = 23;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Btn_CapMK
            // 
            this.Btn_CapMK.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_CapMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CapMK.ForeColor = System.Drawing.Color.Honeydew;
            this.Btn_CapMK.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources.key;
            this.Btn_CapMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CapMK.Location = new System.Drawing.Point(440, 460);
            this.Btn_CapMK.Name = "Btn_CapMK";
            this.Btn_CapMK.Size = new System.Drawing.Size(180, 34);
            this.Btn_CapMK.TabIndex = 33;
            this.Btn_CapMK.Text = "Cấp Mật Khẩu";
            this.Btn_CapMK.UseVisualStyleBackColor = false;
            this.Btn_CapMK.Click += new System.EventHandler(this.Btn_CapMK_Click);
            // 
            // DGV_CapMK
            // 
            this.DGV_CapMK.AllowUserToAddRows = false;
            this.DGV_CapMK.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_CapMK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_CapMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CapMK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CapMK.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_CapMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_CapMK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CapMK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.GhiChu});
            this.DGV_CapMK.GridColor = System.Drawing.SystemColors.ControlText;
            this.DGV_CapMK.Location = new System.Drawing.Point(830, 240);
            this.DGV_CapMK.MultiSelect = false;
            this.DGV_CapMK.Name = "DGV_CapMK";
            this.DGV_CapMK.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CapMK.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LightPink;
            this.DGV_CapMK.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_CapMK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CapMK.ShowEditingIcon = false;
            this.DGV_CapMK.Size = new System.Drawing.Size(171, 214);
            this.DGV_CapMK.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NgaySinh";
            this.NS.HeaderText = "Ngày Sinh";
            this.NS.Name = "NS";
            this.NS.ReadOnly = true;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // FrmQuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 506);
            this.Controls.Add(this.DGV_CapMK);
            this.Controls.Add(this.Btn_CapMK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Tim);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.DGV_NV);
            this.Controls.Add(this.LB_QLKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FrmQuanLyNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CapMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Tim;
        private System.Windows.Forms.TextBox Txt_MaNV;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.TextBox Txt_Ten;
        private System.Windows.Forms.Label LB_QLKH;
        private System.Windows.Forms.DateTimePicker DTP_NS;
        private System.Windows.Forms.ComboBox CB_CV;
        private System.Windows.Forms.DataGridView DGV_NV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_CapMK;
        private System.Windows.Forms.DataGridView DGV_CapMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
    }
}