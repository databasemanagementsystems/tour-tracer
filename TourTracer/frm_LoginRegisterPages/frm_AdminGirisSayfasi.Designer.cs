namespace TourTracer
{
    partial class frm_AdminGirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdminGirisSayfasi));
            this.txt_AdminPassword = new System.Windows.Forms.TextBox();
            this.txt_AdminMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbox_SifreyiGoster = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AdminPassword
            // 
            this.txt_AdminPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_AdminPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AdminPassword.ForeColor = System.Drawing.Color.Red;
            this.txt_AdminPassword.Location = new System.Drawing.Point(453, 300);
            this.txt_AdminPassword.Name = "txt_AdminPassword";
            this.txt_AdminPassword.PasswordChar = '•';
            this.txt_AdminPassword.Size = new System.Drawing.Size(270, 29);
            this.txt_AdminPassword.TabIndex = 10;
            // 
            // txt_AdminMail
            // 
            this.txt_AdminMail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_AdminMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AdminMail.ForeColor = System.Drawing.Color.Red;
            this.txt_AdminMail.Location = new System.Drawing.Point(453, 236);
            this.txt_AdminMail.Name = "txt_AdminMail";
            this.txt_AdminMail.Size = new System.Drawing.Size(270, 29);
            this.txt_AdminMail.TabIndex = 9;
            this.txt_AdminMail.TextChanged += new System.EventHandler(this.txt_AdminIsim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(297, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "ADMİN ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(296, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADMİN MAİL";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Temizle.Location = new System.Drawing.Point(453, 494);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(163, 38);
            this.btn_Temizle.TabIndex = 12;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_GirisYap.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisYap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_GirisYap.Location = new System.Drawing.Point(425, 440);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(216, 38);
            this.btn_GirisYap.TabIndex = 11;
            this.btn_GirisYap.Text = "GİRİŞ YAP";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(453, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox_SifreyiGoster
            // 
            this.checkbox_SifreyiGoster.AutoSize = true;
            this.checkbox_SifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_SifreyiGoster.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbox_SifreyiGoster.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.checkbox_SifreyiGoster.Location = new System.Drawing.Point(547, 335);
            this.checkbox_SifreyiGoster.Name = "checkbox_SifreyiGoster";
            this.checkbox_SifreyiGoster.Size = new System.Drawing.Size(167, 28);
            this.checkbox_SifreyiGoster.TabIndex = 16;
            this.checkbox_SifreyiGoster.Text = "ŞİFREYİ GÖSTER";
            this.checkbox_SifreyiGoster.UseVisualStyleBackColor = true;
            this.checkbox_SifreyiGoster.CheckedChanged += new System.EventHandler(this.checkbox_SifreyiGoster_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(861, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 670);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 670);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(409, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "ADMİN GİRİŞ EKRANI";
            // 
            // frm_AdminGirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1061, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkbox_SifreyiGoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.txt_AdminPassword);
            this.Controls.Add(this.txt_AdminMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminGirisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AdminGirisSayfasi";
            this.Load += new System.EventHandler(this.frm_AdminGirisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_AdminPassword;
        private System.Windows.Forms.TextBox txt_AdminMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbox_SifreyiGoster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}