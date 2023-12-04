namespace TourTracer
{
    partial class frm_CustomerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CustomerMainPage));
            this.btn_GeriDön = new System.Windows.Forms.Button();
            this.btn_ListUsers = new System.Windows.Forms.Button();
            this.btn_ViewTours = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GeriDön
            // 
            this.btn_GeriDön.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_GeriDön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeriDön.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GeriDön.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_GeriDön.Location = new System.Drawing.Point(413, 549);
            this.btn_GeriDön.Name = "btn_GeriDön";
            this.btn_GeriDön.Size = new System.Drawing.Size(155, 36);
            this.btn_GeriDön.TabIndex = 1;
            this.btn_GeriDön.Text = "GERİ DÖN";
            this.btn_GeriDön.UseVisualStyleBackColor = false;
            this.btn_GeriDön.Click += new System.EventHandler(this.btn_GeriDön_Click);
            // 
            // btn_ListUsers
            // 
            this.btn_ListUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ListUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ListUsers.ForeColor = System.Drawing.Color.Red;
            this.btn_ListUsers.Location = new System.Drawing.Point(350, 228);
            this.btn_ListUsers.Name = "btn_ListUsers";
            this.btn_ListUsers.Size = new System.Drawing.Size(275, 33);
            this.btn_ListUsers.TabIndex = 5;
            this.btn_ListUsers.Text = "PROFİLİ GÖRÜNTÜLE";
            this.btn_ListUsers.UseVisualStyleBackColor = false;
            this.btn_ListUsers.Click += new System.EventHandler(this.btn_ListUsers_Click);
            // 
            // btn_ViewTours
            // 
            this.btn_ViewTours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ViewTours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewTours.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ViewTours.ForeColor = System.Drawing.Color.Red;
            this.btn_ViewTours.Location = new System.Drawing.Point(350, 296);
            this.btn_ViewTours.Name = "btn_ViewTours";
            this.btn_ViewTours.Size = new System.Drawing.Size(275, 33);
            this.btn_ViewTours.TabIndex = 4;
            this.btn_ViewTours.Text = "TURLARI GÖRÜNTÜLE";
            this.btn_ViewTours.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ListUsers);
            this.Controls.Add(this.btn_ViewTours);
            this.Controls.Add(this.btn_GeriDön);
            this.Name = "frm_CustomerMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CustomerMainPage";
            this.Load += new System.EventHandler(this.frm_CustomerMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GeriDön;
        private System.Windows.Forms.Button btn_ListUsers;
        private System.Windows.Forms.Button btn_ViewTours;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}