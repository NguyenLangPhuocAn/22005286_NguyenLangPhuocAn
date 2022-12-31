
namespace PhanMemQuanLyBanHangNoiThat
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            this.Txt_MaNV = new System.Windows.Forms.TextBox();
            this.LB_DANGNHAP = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_NameLogin = new System.Windows.Forms.Label();
            this.P_Main = new System.Windows.Forms.PictureBox();
            this.Btn_X = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lb_NV = new System.Windows.Forms.Label();
            this.P_NV = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_MK = new System.Windows.Forms.Label();
            this.P_MK = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lb_QuenMK = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Main)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_NV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_MK)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_MaNV
            // 
            this.Txt_MaNV.BackColor = System.Drawing.Color.Azure;
            this.Txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_MaNV.Font = new System.Drawing.Font("Verdana", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Txt_MaNV.Location = new System.Drawing.Point(63, 10);
            this.Txt_MaNV.MaxLength = 16;
            this.Txt_MaNV.Name = "Txt_MaNV";
            this.Txt_MaNV.ShortcutsEnabled = false;
            this.Txt_MaNV.Size = new System.Drawing.Size(450, 35);
            this.Txt_MaNV.TabIndex = 0;
            this.Txt_MaNV.Click += new System.EventHandler(this.Txt_MaNV_Click);
            this.Txt_MaNV.Enter += new System.EventHandler(this.Txt_MaNV_Enter);
            this.Txt_MaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MaNV_KeyDown);
            this.Txt_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MaNV_KeyPress);
            // 
            // LB_DANGNHAP
            // 
            this.LB_DANGNHAP.AutoSize = true;
            this.LB_DANGNHAP.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.LB_DANGNHAP.ForeColor = System.Drawing.Color.DimGray;
            this.LB_DANGNHAP.Location = new System.Drawing.Point(587, 75);
            this.LB_DANGNHAP.Name = "LB_DANGNHAP";
            this.LB_DANGNHAP.Size = new System.Drawing.Size(166, 32);
            this.LB_DANGNHAP.TabIndex = 1;
            this.LB_DANGNHAP.Text = "Đăng Nhập";
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.Azure;
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Font = new System.Drawing.Font("Verdana", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Txt_Password.Location = new System.Drawing.Point(63, 9);
            this.Txt_Password.MaxLength = 32;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.ShortcutsEnabled = false;
            this.Txt_Password.Size = new System.Drawing.Size(450, 35);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.Click += new System.EventHandler(this.Txt_Password_Click);
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Verdana", 6.25F);
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(618, 238);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(92, 36);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "Đăng Nhập";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Lb_NameLogin);
            this.panel1.Controls.Add(this.P_Main);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 436);
            this.panel1.TabIndex = 8;
            // 
            // Lb_NameLogin
            // 
            this.Lb_NameLogin.AutoSize = true;
            this.Lb_NameLogin.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lb_NameLogin.ForeColor = System.Drawing.Color.LightCyan;
            this.Lb_NameLogin.Location = new System.Drawing.Point(25, 258);
            this.Lb_NameLogin.Name = "Lb_NameLogin";
            this.Lb_NameLogin.Size = new System.Drawing.Size(341, 28);
            this.Lb_NameLogin.TabIndex = 10;
            this.Lb_NameLogin.Text = "Quản Lý Nhân Sự Và Vật Tư";
            // 
            // P_Main
            // 
            this.P_Main.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.P_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.P_Main.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources._5087579;
            this.P_Main.Location = new System.Drawing.Point(8, 10);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(387, 245);
            this.P_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Main.TabIndex = 0;
            this.P_Main.TabStop = false;
            // 
            // Btn_X
            // 
            this.Btn_X.FlatAppearance.BorderSize = 0;
            this.Btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_X.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Btn_X.ForeColor = System.Drawing.Color.Red;
            this.Btn_X.Location = new System.Drawing.Point(861, 9);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(75, 36);
            this.Btn_X.TabIndex = 9;
            this.Btn_X.Text = "X";
            this.Btn_X.UseVisualStyleBackColor = true;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.Lb_NV);
            this.panel2.Controls.Add(this.P_NV);
            this.panel2.Controls.Add(this.Txt_MaNV);
            this.panel2.Location = new System.Drawing.Point(419, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 48);
            this.panel2.TabIndex = 10;
            // 
            // Lb_NV
            // 
            this.Lb_NV.AutoSize = true;
            this.Lb_NV.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lb_NV.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Lb_NV.Location = new System.Drawing.Point(61, 10);
            this.Lb_NV.Name = "Lb_NV";
            this.Lb_NV.Size = new System.Drawing.Size(65, 10);
            this.Lb_NV.TabIndex = 2;
            this.Lb_NV.Text = "Mã Nhân Viên:";
            // 
            // P_NV
            // 
            this.P_NV.Image = ((System.Drawing.Image)(resources.GetObject("P_NV.Image")));
            this.P_NV.Location = new System.Drawing.Point(0, 0);
            this.P_NV.Name = "P_NV";
            this.P_NV.Size = new System.Drawing.Size(57, 48);
            this.P_NV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_NV.TabIndex = 1;
            this.P_NV.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.Lb_MK);
            this.panel3.Controls.Add(this.P_MK);
            this.panel3.Controls.Add(this.Txt_Password);
            this.panel3.Location = new System.Drawing.Point(419, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 48);
            this.panel3.TabIndex = 11;
            // 
            // Lb_MK
            // 
            this.Lb_MK.AutoSize = true;
            this.Lb_MK.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lb_MK.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Lb_MK.Location = new System.Drawing.Point(61, 9);
            this.Lb_MK.Name = "Lb_MK";
            this.Lb_MK.Size = new System.Drawing.Size(48, 10);
            this.Lb_MK.TabIndex = 3;
            this.Lb_MK.Text = "Mật Khẩu:";
            // 
            // P_MK
            // 
            this.P_MK.Image = ((System.Drawing.Image)(resources.GetObject("P_MK.Image")));
            this.P_MK.Location = new System.Drawing.Point(1, 0);
            this.P_MK.Name = "P_MK";
            this.P_MK.Size = new System.Drawing.Size(56, 48);
            this.P_MK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_MK.TabIndex = 2;
            this.P_MK.TabStop = false;
            this.P_MK.Click += new System.EventHandler(this.P_NV_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(400, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 436);
            this.panel4.TabIndex = 12;
            // 
            // Lb_QuenMK
            // 
            this.Lb_QuenMK.AutoSize = true;
            this.Lb_QuenMK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lb_QuenMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lb_QuenMK.Location = new System.Drawing.Point(423, 406);
            this.Lb_QuenMK.Name = "Lb_QuenMK";
            this.Lb_QuenMK.Size = new System.Drawing.Size(109, 16);
            this.Lb_QuenMK.TabIndex = 13;
            this.Lb_QuenMK.Text = "Quên Mật Khẩu";
            this.Lb_QuenMK.Click += new System.EventHandler(this.Lb_QuenMK_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cyan;
            this.panel5.Location = new System.Drawing.Point(420, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(516, 5);
            this.panel5.TabIndex = 14;
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(944, 431);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Lb_QuenMK);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_X);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.LB_DANGNHAP);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Main)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_NV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_MK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_MaNV;
        private System.Windows.Forms.Label LB_DANGNHAP;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_X;
        private System.Windows.Forms.Label Lb_NameLogin;
        private System.Windows.Forms.PictureBox P_Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox P_NV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox P_MK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lb_QuenMK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lb_NV;
        private System.Windows.Forms.Label Lb_MK;
    }
}

