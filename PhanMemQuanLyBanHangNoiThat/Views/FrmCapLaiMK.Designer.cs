
namespace PhanMemQuanLyBanHangNoiThat.Views
{
    partial class FrmCapLaiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCapLaiMK));
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Btn_XacNhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txt_MaNV = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.Txt_Password);
            this.panel3.Location = new System.Drawing.Point(6, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 48);
            this.panel3.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 10);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PhanMemQuanLyBanHangNoiThat.Properties.Resources._1814107_lock_padlock_secure_icon;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Location = new System.Drawing.Point(6, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 5);
            this.panel5.TabIndex = 28;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.Lb1.ForeColor = System.Drawing.Color.Orange;
            this.Lb1.Location = new System.Drawing.Point(106, 9);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(266, 32);
            this.Lb1.TabIndex = 27;
            this.Lb1.Text = "Cấp Lại Mật Khẩu:";
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_XacNhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.Btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_XacNhan.Font = new System.Drawing.Font("Verdana", 6.25F);
            this.Btn_XacNhan.ForeColor = System.Drawing.Color.White;
            this.Btn_XacNhan.Location = new System.Drawing.Point(186, 163);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(107, 36);
            this.Btn_XacNhan.TabIndex = 29;
            this.Btn_XacNhan.Text = "Xác Nhận";
            this.Btn_XacNhan.UseVisualStyleBackColor = false;
            this.Btn_XacNhan.Click += new System.EventHandler(this.Btn_XacNhan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Txt_MaNV);
            this.panel2.Location = new System.Drawing.Point(6, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 48);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(61, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 10);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Txt_MaNV
            // 
            this.Txt_MaNV.BackColor = System.Drawing.Color.Azure;
            this.Txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_MaNV.Font = new System.Drawing.Font("Verdana", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Txt_MaNV.Location = new System.Drawing.Point(59, 13);
            this.Txt_MaNV.MaxLength = 16;
            this.Txt_MaNV.Name = "Txt_MaNV";
            this.Txt_MaNV.ShortcutsEnabled = false;
            this.Txt_MaNV.Size = new System.Drawing.Size(441, 35);
            this.Txt_MaNV.TabIndex = 0;
            this.Txt_MaNV.Click += new System.EventHandler(this.Txt_MaNV_Click);
            this.Txt_MaNV.Enter += new System.EventHandler(this.Txt_MaNV_Enter);
            this.Txt_MaNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_MaNV_KeyDown);
            this.Txt_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_MaNV_KeyPress);
            // 
            // FrmCapLaiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 206);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.Btn_XacNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapLaiMK";
            this.Text = "FrmCapLaiMK";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button Btn_XacNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_MaNV;
    }
}