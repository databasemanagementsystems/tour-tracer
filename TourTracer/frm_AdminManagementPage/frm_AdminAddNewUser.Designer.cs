namespace TourTracer
{
    partial class frm_AdminAddNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_NewCustomerName = new System.Windows.Forms.TextBox();
            this.txt_NewCustomerLastName = new System.Windows.Forms.TextBox();
            this.txt_NewCustomerMail = new System.Windows.Forms.TextBox();
            this.txt_NewCustomerPhone = new System.Windows.Forms.TextBox();
            this.txt_NewCustomerPassword = new System.Windows.Forms.TextBox();
            this.Yeni = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(570, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "YENİ KULLANICI EKLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-43, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 87);
            this.panel1.TabIndex = 1;
            // 
            // txt_NewCustomerName
            // 
            this.txt_NewCustomerName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_NewCustomerName.ForeColor = System.Drawing.Color.Red;
            this.txt_NewCustomerName.Location = new System.Drawing.Point(616, 213);
            this.txt_NewCustomerName.Name = "txt_NewCustomerName";
            this.txt_NewCustomerName.Size = new System.Drawing.Size(328, 22);
            this.txt_NewCustomerName.TabIndex = 2;
            this.txt_NewCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_NewCustomerLastName
            // 
            this.txt_NewCustomerLastName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_NewCustomerLastName.ForeColor = System.Drawing.Color.Red;
            this.txt_NewCustomerLastName.Location = new System.Drawing.Point(616, 239);
            this.txt_NewCustomerLastName.Name = "txt_NewCustomerLastName";
            this.txt_NewCustomerLastName.Size = new System.Drawing.Size(328, 22);
            this.txt_NewCustomerLastName.TabIndex = 3;
            // 
            // txt_NewCustomerMail
            // 
            this.txt_NewCustomerMail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_NewCustomerMail.ForeColor = System.Drawing.Color.Red;
            this.txt_NewCustomerMail.Location = new System.Drawing.Point(616, 267);
            this.txt_NewCustomerMail.Name = "txt_NewCustomerMail";
            this.txt_NewCustomerMail.Size = new System.Drawing.Size(328, 22);
            this.txt_NewCustomerMail.TabIndex = 4;
            // 
            // txt_NewCustomerPhone
            // 
            this.txt_NewCustomerPhone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_NewCustomerPhone.ForeColor = System.Drawing.Color.Red;
            this.txt_NewCustomerPhone.Location = new System.Drawing.Point(614, 294);
            this.txt_NewCustomerPhone.Name = "txt_NewCustomerPhone";
            this.txt_NewCustomerPhone.Size = new System.Drawing.Size(328, 22);
            this.txt_NewCustomerPhone.TabIndex = 5;
            // 
            // txt_NewCustomerPassword
            // 
            this.txt_NewCustomerPassword.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_NewCustomerPassword.Location = new System.Drawing.Point(614, 352);
            this.txt_NewCustomerPassword.Name = "txt_NewCustomerPassword";
            this.txt_NewCustomerPassword.Size = new System.Drawing.Size(328, 22);
            this.txt_NewCustomerPassword.TabIndex = 6;
            // 
            // Yeni
            // 
            this.Yeni.AutoSize = true;
            this.Yeni.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yeni.ForeColor = System.Drawing.Color.Indigo;
            this.Yeni.Location = new System.Drawing.Point(363, 212);
            this.Yeni.Name = "Yeni";
            this.Yeni.Size = new System.Drawing.Size(166, 24);
            this.Yeni.TabIndex = 7;
            this.Yeni.Text = "Yeni Kullanıcı İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(363, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yeni Kullanıcı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(366, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yeni Kullanıcı e-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(363, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yeni Kullanıcı Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(363, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yeni Kullanıcı Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(363, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yeni Kullanıcı Şifre";
            // 
            // date_Birthdate
            // 
            this.date_Birthdate.Location = new System.Drawing.Point(614, 323);
            this.date_Birthdate.Name = "date_Birthdate";
            this.date_Birthdate.Size = new System.Drawing.Size(330, 22);
            this.date_Birthdate.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(360, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 85);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kullanıcı Olarak Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(516, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 85);
            this.button2.TabIndex = 15;
            this.button2.Text = "Personel Olarak Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(668, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 85);
            this.button3.TabIndex = 16;
            this.button3.Text = "Admin Olarak Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Bisque;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(842, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 64);
            this.button4.TabIndex = 17;
            this.button4.Text = "GERİ DÖN";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frm_AdminAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 543);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_Birthdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Yeni);
            this.Controls.Add(this.txt_NewCustomerPassword);
            this.Controls.Add(this.txt_NewCustomerPhone);
            this.Controls.Add(this.txt_NewCustomerMail);
            this.Controls.Add(this.txt_NewCustomerLastName);
            this.Controls.Add(this.txt_NewCustomerName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AdminAddNewCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_NewCustomerName;
        private System.Windows.Forms.TextBox txt_NewCustomerLastName;
        private System.Windows.Forms.TextBox txt_NewCustomerMail;
        private System.Windows.Forms.TextBox txt_NewCustomerPhone;
        private System.Windows.Forms.TextBox txt_NewCustomerPassword;
        private System.Windows.Forms.Label Yeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_Birthdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}