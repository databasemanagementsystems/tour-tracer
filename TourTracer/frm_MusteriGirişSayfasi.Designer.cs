namespace TourTracer
{
    partial class frm_MusteriGirişSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MusteriGirişSayfasi));
            this.btn_GeriDön = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MusteriMail = new System.Windows.Forms.TextBox();
            this.txt_MusteriSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.checkbox_SifreyiGoster = new System.Windows.Forms.CheckBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GeriDön
            // 
            this.btn_GeriDön.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_GeriDön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeriDön.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GeriDön.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_GeriDön.Location = new System.Drawing.Point(451, 576);
            this.btn_GeriDön.Name = "btn_GeriDön";
            this.btn_GeriDön.Size = new System.Drawing.Size(155, 36);
            this.btn_GeriDön.TabIndex = 0;
            this.btn_GeriDön.Text = "GERİ DÖN";
            this.btn_GeriDön.UseVisualStyleBackColor = false;
            this.btn_GeriDön.Click += new System.EventHandler(this.btn_GeriDön_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(381, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "KAYIT OLMAK İÇİN TIKLAYINIZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(355, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÜŞTERİ GİRİŞ EKRANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(248, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "MÜŞTERİ MAİL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(248, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "MÜŞTERİ ŞİFRE";
            // 
            // txt_MusteriMail
            // 
            this.txt_MusteriMail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_MusteriMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriMail.ForeColor = System.Drawing.Color.Red;
            this.txt_MusteriMail.Location = new System.Drawing.Point(404, 209);
            this.txt_MusteriMail.Name = "txt_MusteriMail";
            this.txt_MusteriMail.Size = new System.Drawing.Size(261, 29);
            this.txt_MusteriMail.TabIndex = 5;
            this.txt_MusteriMail.TextChanged += new System.EventHandler(this.txt_MusteriMail_TextChanged);
            // 
            // txt_MusteriSifre
            // 
            this.txt_MusteriSifre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_MusteriSifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriSifre.ForeColor = System.Drawing.Color.Red;
            this.txt_MusteriSifre.Location = new System.Drawing.Point(404, 300);
            this.txt_MusteriSifre.Name = "txt_MusteriSifre";
            this.txt_MusteriSifre.PasswordChar = '•';
            this.txt_MusteriSifre.Size = new System.Drawing.Size(261, 29);
            this.txt_MusteriSifre.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_GirisYap.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisYap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_GirisYap.Location = new System.Drawing.Point(438, 395);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(180, 32);
            this.btn_GirisYap.TabIndex = 8;
            this.btn_GirisYap.Text = "GİRİŞ YAP";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // checkbox_SifreyiGoster
            // 
            this.checkbox_SifreyiGoster.AutoSize = true;
            this.checkbox_SifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_SifreyiGoster.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbox_SifreyiGoster.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.checkbox_SifreyiGoster.Location = new System.Drawing.Point(451, 350);
            this.checkbox_SifreyiGoster.Name = "checkbox_SifreyiGoster";
            this.checkbox_SifreyiGoster.Size = new System.Drawing.Size(167, 28);
            this.checkbox_SifreyiGoster.TabIndex = 9;
            this.checkbox_SifreyiGoster.Text = "ŞİFREYİ GÖSTER";
            this.checkbox_SifreyiGoster.UseVisualStyleBackColor = true;
            this.checkbox_SifreyiGoster.CheckedChanged += new System.EventHandler(this.checkbox_SifreyiGoster_CheckedChanged);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Temizle.Location = new System.Drawing.Point(451, 445);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(148, 32);
            this.btn_Temizle.TabIndex = 10;
            this.btn_Temizle.Text = "TEMİZLE";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(435, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "HESABINIZ YOK MU";
            // 
            // frm_MusteriGirişSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1061, 670);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.checkbox_SifreyiGoster);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_MusteriSifre);
            this.Controls.Add(this.txt_MusteriMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GeriDön);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_MusteriGirişSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MusteriGiriş";
            this.Load += new System.EventHandler(this.frm_MusteriGiriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GeriDön;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MusteriMail;
        private System.Windows.Forms.TextBox txt_MusteriSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.CheckBox checkbox_SifreyiGoster;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Label label5;
    }
}