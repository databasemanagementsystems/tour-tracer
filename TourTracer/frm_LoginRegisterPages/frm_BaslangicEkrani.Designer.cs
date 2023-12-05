namespace TourTracer
{
    partial class frm_BaslangicEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BaslangicEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AdminGiris = new System.Windows.Forms.Button();
            this.btn_MusteriGiris = new System.Windows.Forms.Button();
            this.btn_CikisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(287, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOUR TRACER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_AdminGiris
            // 
            this.btn_AdminGiris.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_AdminGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AdminGiris.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AdminGiris.Location = new System.Drawing.Point(319, 248);
            this.btn_AdminGiris.Name = "btn_AdminGiris";
            this.btn_AdminGiris.Size = new System.Drawing.Size(180, 45);
            this.btn_AdminGiris.TabIndex = 1;
            this.btn_AdminGiris.Text = "ADMİN GİRİŞ";
            this.btn_AdminGiris.UseVisualStyleBackColor = false;
            this.btn_AdminGiris.Click += new System.EventHandler(this.btn_AdminGiris_Click);
            // 
            // btn_MusteriGiris
            // 
            this.btn_MusteriGiris.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_MusteriGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MusteriGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MusteriGiris.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MusteriGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btn_MusteriGiris.Location = new System.Drawing.Point(319, 303);
            this.btn_MusteriGiris.Name = "btn_MusteriGiris";
            this.btn_MusteriGiris.Size = new System.Drawing.Size(180, 45);
            this.btn_MusteriGiris.TabIndex = 2;
            this.btn_MusteriGiris.Text = "MÜŞTERİ GİRİŞ";
            this.btn_MusteriGiris.UseVisualStyleBackColor = false;
            this.btn_MusteriGiris.Click += new System.EventHandler(this.btn_MusteriGiris_Click);
            // 
            // btn_CikisYap
            // 
            this.btn_CikisYap.BackColor = System.Drawing.Color.IndianRed;
            this.btn_CikisYap.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_CikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CikisYap.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CikisYap.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CikisYap.Location = new System.Drawing.Point(346, 368);
            this.btn_CikisYap.Name = "btn_CikisYap";
            this.btn_CikisYap.Size = new System.Drawing.Size(129, 35);
            this.btn_CikisYap.TabIndex = 3;
            this.btn_CikisYap.Text = "ÇIKIŞ YAP";
            this.btn_CikisYap.UseVisualStyleBackColor = false;
            this.btn_CikisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_BaslangicEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CikisYap);
            this.Controls.Add(this.btn_MusteriGiris);
            this.Controls.Add(this.btn_AdminGiris);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BaslangicEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Giris";
            this.Load += new System.EventHandler(this.frm_Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AdminGiris;
        private System.Windows.Forms.Button btn_MusteriGiris;
        private System.Windows.Forms.Button btn_CikisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}