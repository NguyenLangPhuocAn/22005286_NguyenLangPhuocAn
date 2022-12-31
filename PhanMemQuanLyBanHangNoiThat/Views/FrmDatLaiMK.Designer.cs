
namespace PhanMemQuanLyBanHangNoiThat.Views
{
    partial class FrmDatLaiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatLaiMK));
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Btn_XacNhan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lb_MK = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightYellow;
            this.panel5.Location = new System.Drawing.Point(13, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 5);
            this.panel5.TabIndex = 22;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.Lb1.ForeColor = System.Drawing.Color.Orange;
            this.Lb1.Location = new System.Drawing.Point(132, 5);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(250, 32);
            this.Lb1.TabIndex = 20;
            this.Lb1.Text = "Đặt Lại Mật Khẩu";
            // 
            // Btn_XacNhan
            // 
            this.Btn_XacNhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_XacNhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.Btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_XacNhan.Font = new System.Drawing.Font("Verdana", 6.25F);
            this.Btn_XacNhan.ForeColor = System.Drawing.Color.White;
            this.Btn_XacNhan.Location = new System.Drawing.Point(211, 112);
            this.Btn_XacNhan.Name = "Btn_XacNhan";
            this.Btn_XacNhan.Size = new System.Drawing.Size(107, 36);
            this.Btn_XacNhan.TabIndex = 24;
            this.Btn_XacNhan.Text = "Xác Nhận";
            this.Btn_XacNhan.UseVisualStyleBackColor = false;
            this.Btn_XacNhan.Click += new System.EventHandler(this.Btn_XacNhan_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.Lb_MK);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.Txt_Password);
            this.panel3.Location = new System.Drawing.Point(13, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 48);
            this.panel3.TabIndex = 26;
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
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            this.Txt_Password.Leave += new System.EventHandler(this.Txt_Password_Leave);
            // 
            // FrmDatLaiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(544, 160);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.Btn_XacNhan);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatLaiMK";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button Btn_XacNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lb_MK;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Txt_Password;
    }
}