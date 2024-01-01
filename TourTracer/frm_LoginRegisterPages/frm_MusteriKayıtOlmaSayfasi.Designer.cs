namespace TourTracer
{
    partial class frm_MusteriKayıtOlmaSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MusteriKayıtOlmaSayfasi));
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_CustomerPassword = new System.Windows.Forms.TextBox();
            this.txt_CustomerMail = new System.Windows.Forms.TextBox();
            this.txt_CustomerLastName = new System.Windows.Forms.TextBox();
            this.txt_CustomerPasswordAgain = new System.Windows.Forms.TextBox();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.date_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.checkbox_SifreyiGoster = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_CustomerPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_GeriDon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GeriDon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_GeriDon.Location = new System.Drawing.Point(467, 604);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(161, 32);
            this.btn_GeriDon.TabIndex = 0;
            this.btn_GeriDon.Text = "GERİ DÖN";
            this.btn_GeriDon.UseVisualStyleBackColor = false;
            this.btn_GeriDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(358, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÜŞTERİ HESAP OLUŞTURMA";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_CustomerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerName.ForeColor = System.Drawing.Color.Red;
            this.txt_CustomerName.Location = new System.Drawing.Point(467, 190);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(245, 29);
            this.txt_CustomerName.TabIndex = 9;
            // 
            // txt_CustomerPassword
            // 
            this.txt_CustomerPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_CustomerPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerPassword.ForeColor = System.Drawing.Color.Red;
            this.txt_CustomerPassword.Location = new System.Drawing.Point(467, 382);
            this.txt_CustomerPassword.Name = "txt_CustomerPassword";
            this.txt_CustomerPassword.PasswordChar = '•';
            this.txt_CustomerPassword.Size = new System.Drawing.Size(245, 29);
            this.txt_CustomerPassword.TabIndex = 10;
            // 
            // txt_CustomerMail
            // 
            this.txt_CustomerMail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_CustomerMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerMail.ForeColor = System.Drawing.Color.Red;
            this.txt_CustomerMail.Location = new System.Drawing.Point(467, 301);
            this.txt_CustomerMail.Name = "txt_CustomerMail";
            this.txt_CustomerMail.Size = new System.Drawing.Size(245, 29);
            this.txt_CustomerMail.TabIndex = 12;
            this.txt_CustomerMail.TextChanged += new System.EventHandler(this.txt_MusteriTel_TextChanged);
            // 
            // txt_CustomerLastName
            // 
            this.txt_CustomerLastName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_CustomerLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerLastName.ForeColor = System.Drawing.Color.Red;
            this.txt_CustomerLastName.Location = new System.Drawing.Point(467, 231);
            this.txt_CustomerLastName.Name = "txt_CustomerLastName";
            this.txt_CustomerLastName.Size = new System.Drawing.Size(245, 29);
            this.txt_CustomerLastName.TabIndex = 13;
            // 
            // txt_CustomerPasswordAgain
            // 
            this.txt_CustomerPasswordAgain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_CustomerPasswordAgain.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerPasswordAgain.ForeColor = System.Drawing.Color.Red;
            this.txt_CustomerPasswordAgain.Location = new System.Drawing.Point(467, 421);
            this.txt_CustomerPasswordAgain.Name = "txt_CustomerPasswordAgain";
            this.txt_CustomerPasswordAgain.PasswordChar = '•';
            this.txt_CustomerPasswordAgain.Size = new System.Drawing.Size(245, 29);
            this.txt_CustomerPasswordAgain.TabIndex = 14;
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_KayitOl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitOl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_KayitOl.Location = new System.Drawing.Point(467, 500);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(161, 35);
            this.btn_KayitOl.TabIndex = 15;
            this.btn_KayitOl.Text = "KAYIT OL";
            this.btn_KayitOl.UseVisualStyleBackColor = false;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // date_Birthdate
            // 
            this.date_Birthdate.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_Birthdate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.date_Birthdate.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.date_Birthdate.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.date_Birthdate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.date_Birthdate.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.date_Birthdate.Location = new System.Drawing.Point(467, 344);
            this.date_Birthdate.Name = "date_Birthdate";
            this.date_Birthdate.Size = new System.Drawing.Size(245, 22);
            this.date_Birthdate.TabIndex = 18;
            // 
            // checkbox_SifreyiGoster
            // 
            this.checkbox_SifreyiGoster.AutoSize = true;
            this.checkbox_SifreyiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_SifreyiGoster.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbox_SifreyiGoster.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.checkbox_SifreyiGoster.Location = new System.Drawing.Point(545, 456);
            this.checkbox_SifreyiGoster.Name = "checkbox_SifreyiGoster";
            this.checkbox_SifreyiGoster.Size = new System.Drawing.Size(167, 28);
            this.checkbox_SifreyiGoster.TabIndex = 19;
            this.checkbox_SifreyiGoster.Text = "ŞİFREYİ GÖSTER";
            this.checkbox_SifreyiGoster.UseVisualStyleBackColor = true;
            this.checkbox_SifreyiGoster.CheckedChanged += new System.EventHandler(this.checkbox_SifreyiGoster_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(486, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txt_CustomerPhone
            // 
            this.txt_CustomerPhone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_CustomerPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerPhone.ForeColor = System.Drawing.Color.Red;
            this.txt_CustomerPhone.Location = new System.Drawing.Point(467, 266);
            this.txt_CustomerPhone.Name = "txt_CustomerPhone";
            this.txt_CustomerPhone.Size = new System.Drawing.Size(245, 29);
            this.txt_CustomerPhone.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 670);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(861, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 670);
            this.panel2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(356, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 27);
            this.label9.TabIndex = 26;
            this.label9.Text = "İSİM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(353, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 27);
            this.label10.TabIndex = 27;
            this.label10.Text = "SOYİSİM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(356, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 27);
            this.label11.TabIndex = 28;
            this.label11.Text = "TELEFON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(356, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 27);
            this.label12.TabIndex = 29;
            this.label12.Text = "MAİL ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(287, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 27);
            this.label13.TabIndex = 30;
            this.label13.Text = "DOĞUM TARİHİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(361, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "ŞİFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(307, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "ŞİFRE TEKRAR";
            // 
            // frm_MusteriKayıtOlmaSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1061, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_CustomerPhone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbox_SifreyiGoster);
            this.Controls.Add(this.date_Birthdate);
            this.Controls.Add(this.btn_KayitOl);
            this.Controls.Add(this.txt_CustomerPasswordAgain);
            this.Controls.Add(this.txt_CustomerLastName);
            this.Controls.Add(this.txt_CustomerMail);
            this.Controls.Add(this.txt_CustomerPassword);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GeriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MusteriKayıtOlmaSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MusteriKayıtOlma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_CustomerPassword;
        private System.Windows.Forms.TextBox txt_CustomerMail;
        private System.Windows.Forms.TextBox txt_CustomerLastName;
        private System.Windows.Forms.TextBox txt_CustomerPasswordAgain;
        private System.Windows.Forms.Button btn_KayitOl;
        private System.Windows.Forms.DateTimePicker date_Birthdate;
        private System.Windows.Forms.CheckBox checkbox_SifreyiGoster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_CustomerPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}