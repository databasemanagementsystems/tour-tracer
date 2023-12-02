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
            this.btn_GeriDön = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GeriDön
            // 
            this.btn_GeriDön.Location = new System.Drawing.Point(322, 305);
            this.btn_GeriDön.Name = "btn_GeriDön";
            this.btn_GeriDön.Size = new System.Drawing.Size(144, 23);
            this.btn_GeriDön.TabIndex = 0;
            this.btn_GeriDön.Text = "Geri Dön";
            this.btn_GeriDön.UseVisualStyleBackColor = true;
            this.btn_GeriDön.Click += new System.EventHandler(this.btn_GeriDön_Click);
            // 
            // frm_AdminGirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GeriDön);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_AdminGirisSayfasi";
            this.Text = "frm_AdminGirisSayfasi";
            this.Load += new System.EventHandler(this.frm_AdminGirisSayfasi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GeriDön;
    }
}