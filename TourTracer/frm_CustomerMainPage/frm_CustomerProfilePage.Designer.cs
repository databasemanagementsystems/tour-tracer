namespace TourTracer
{
    partial class frm_CustomerProfilePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CustomerProfilePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet = new TourTracer.TourTracerDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_GeriDön = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_UserTableAdapter = new TourTracer.TourTracerDataSetTableAdapters.tbl_UserTableAdapter();
            this.tblUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet2 = new TourTracer.TourTracerDataSet2();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UsersTableAdapter = new TourTracer.TourTracerDataSet2TableAdapters.tbl_UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 623);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tbl_User";
            this.tblUserBindingSource.DataSource = this.tourTracerDataSetBindingSource;
            // 
            // tourTracerDataSetBindingSource
            // 
            this.tourTracerDataSetBindingSource.DataSource = this.tourTracerDataSet;
            this.tourTracerDataSetBindingSource.Position = 0;
            // 
            // tourTracerDataSet
            // 
            this.tourTracerDataSet.DataSetName = "TourTracerDataSet";
            this.tourTracerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btn_GeriDön);
            this.panel2.Location = new System.Drawing.Point(15, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 107);
            this.panel2.TabIndex = 40;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.BorderSize = 4;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(468, 14);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(3);
            this.button7.Size = new System.Drawing.Size(295, 77);
            this.button7.TabIndex = 21;
            this.button7.Text = "HESABI SİL";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_GeriDön
            // 
            this.btn_GeriDön.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GeriDön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeriDön.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GeriDön.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_GeriDön.Location = new System.Drawing.Point(21, 14);
            this.btn_GeriDön.Name = "btn_GeriDön";
            this.btn_GeriDön.Padding = new System.Windows.Forms.Padding(3);
            this.btn_GeriDön.Size = new System.Drawing.Size(295, 77);
            this.btn_GeriDön.TabIndex = 20;
            this.btn_GeriDön.Text = "BİLGİLERİ GÜNCELLE";
            this.btn_GeriDön.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.CausesValidation = false;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(327, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(8, 35);
            this.label3.TabIndex = 34;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.CausesValidation = false;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(327, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(8, 35);
            this.label2.TabIndex = 33;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(327, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(8, 35);
            this.label1.TabIndex = 29;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.CausesValidation = false;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(327, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(8, 35);
            this.label5.TabIndex = 27;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.CausesValidation = false;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(327, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(8, 35);
            this.label4.TabIndex = 15;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserBindingSource1
            // 
            this.tblUserBindingSource1.DataMember = "tbl_User";
            this.tblUserBindingSource1.DataSource = this.tourTracerDataSetBindingSource;
            // 
            // tblUserBindingSource2
            // 
            this.tblUserBindingSource2.DataMember = "tbl_User";
            this.tblUserBindingSource2.DataSource = this.tourTracerDataSetBindingSource;
            // 
            // tourTracerDataSetBindingSource1
            // 
            this.tourTracerDataSetBindingSource1.DataSource = this.tourTracerDataSet;
            this.tourTracerDataSetBindingSource1.Position = 0;
            // 
            // tourTracerDataSet2
            // 
            this.tourTracerDataSet2.DataSetName = "TourTracerDataSet2";
            this.tourTracerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.tourTracerDataSet2;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // frm_CustomerProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 617);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CustomerProfilePage";
            this.Text = "frm_CustomerProfilePage";
            this.Load += new System.EventHandler(this.frm_CustomerProfilePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_GeriDön;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tourTracerDataSetBindingSource;
        private TourTracerDataSet tourTracerDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private TourTracerDataSetTableAdapters.tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblUserBindingSource2;
        private System.Windows.Forms.BindingSource tblUserBindingSource1;
        private System.Windows.Forms.BindingSource tourTracerDataSetBindingSource1;
        private TourTracerDataSet2 tourTracerDataSet2;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private TourTracerDataSet2TableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
    }
}