﻿//namespace TourTracer
//{
//    partial class frm_AdminImportExport
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.dataGridView_Export = new System.Windows.Forms.DataGridView();
//            this.cmbox_Export = new System.Windows.Forms.ComboBox();
//            this.btn_Export = new System.Windows.Forms.Button();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.dataGridView_Import = new System.Windows.Forms.DataGridView();
//            this.label3 = new System.Windows.Forms.Label();
//            this.btn_Browse = new System.Windows.Forms.Button();
//            this.btn_Import = new System.Windows.Forms.Button();
//            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
//            this.txt_FileName = new System.Windows.Forms.TextBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.cmbox_import = new System.Windows.Forms.ComboBox();
//            this.label5 = new System.Windows.Forms.Label();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Export)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Import)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dataGridView_Export
//            // 
//            this.dataGridView_Export.BackgroundColor = System.Drawing.SystemColors.Info;
//            this.dataGridView_Export.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView_Export.Location = new System.Drawing.Point(78, 98);
//            this.dataGridView_Export.Name = "dataGridView_Export";
//            this.dataGridView_Export.RowHeadersWidth = 51;
//            this.dataGridView_Export.RowTemplate.Height = 24;
//            this.dataGridView_Export.Size = new System.Drawing.Size(470, 334);
//            this.dataGridView_Export.TabIndex = 1;
//            // 
//            // cmbox_Export
//            // 
//            this.cmbox_Export.FormattingEnabled = true;
//            this.cmbox_Export.Items.AddRange(new object[] {
//            "tbl_Cities",
//            "tbl_deneme",
//            "tbl_User"});
//            this.cmbox_Export.Location = new System.Drawing.Point(317, 443);
//            this.cmbox_Export.Name = "cmbox_Export";
//            this.cmbox_Export.Size = new System.Drawing.Size(182, 24);
//            this.cmbox_Export.TabIndex = 3;
//            this.cmbox_Export.SelectedIndexChanged += new System.EventHandler(this.cmbox_Export_SelectedIndexChanged);
//            // 
//            // btn_Export
//            // 
//            this.btn_Export.BackColor = System.Drawing.SystemColors.Info;
//            this.btn_Export.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.btn_Export.ForeColor = System.Drawing.SystemColors.Highlight;
//            this.btn_Export.Location = new System.Drawing.Point(317, 484);
//            this.btn_Export.Name = "btn_Export";
//            this.btn_Export.Size = new System.Drawing.Size(105, 38);
//            this.btn_Export.TabIndex = 4;
//            this.btn_Export.Text = "EXPORT";
//            this.btn_Export.UseVisualStyleBackColor = false;
//            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.label1.Location = new System.Drawing.Point(74, 442);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(237, 48);
//            this.label1.TabIndex = 5;
//            this.label1.Text = "EXPORT Etmek İstediğiniz \r\nTabloyu Seçiniz";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.BackColor = System.Drawing.SystemColors.Info;
//            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
//            this.label2.Location = new System.Drawing.Point(229, 59);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(168, 27);
//            this.label2.TabIndex = 6;
//            this.label2.Text = "EXPORT İŞLEMİ";
//            // 
//            // dataGridView_Import
//            // 
//            this.dataGridView_Import.BackgroundColor = System.Drawing.SystemColors.Info;
//            this.dataGridView_Import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView_Import.Location = new System.Drawing.Point(649, 96);
//            this.dataGridView_Import.Name = "dataGridView_Import";
//            this.dataGridView_Import.RowHeadersWidth = 51;
//            this.dataGridView_Import.RowTemplate.Height = 24;
//            this.dataGridView_Import.Size = new System.Drawing.Size(540, 335);
//            this.dataGridView_Import.TabIndex = 7;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.label3.Location = new System.Drawing.Point(645, 440);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(238, 48);
//            this.label3.TabIndex = 9;
//            this.label3.Text = "İMPORT Etmek İstediğiniz \r\nDosyayı Seçin\r\n";
//            // 
//            // btn_Browse
//            // 
//            this.btn_Browse.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.btn_Browse.Location = new System.Drawing.Point(1140, 437);
//            this.btn_Browse.Name = "btn_Browse";
//            this.btn_Browse.Size = new System.Drawing.Size(39, 32);
//            this.btn_Browse.TabIndex = 10;
//            this.btn_Browse.Text = "...";
//            this.btn_Browse.UseVisualStyleBackColor = true;
//            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
//            // 
//            // btn_Import
//            // 
//            this.btn_Import.BackColor = System.Drawing.SystemColors.Info;
//            this.btn_Import.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.btn_Import.ForeColor = System.Drawing.SystemColors.MenuHighlight;
//            this.btn_Import.Location = new System.Drawing.Point(933, 548);
//            this.btn_Import.Name = "btn_Import";
//            this.btn_Import.Size = new System.Drawing.Size(170, 40);
//            this.btn_Import.TabIndex = 11;
//            this.btn_Import.Text = "İMPORT";
//            this.btn_Import.UseVisualStyleBackColor = false;
//            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
//            // 
//            // openFileDialog1
//            // 
//            this.openFileDialog1.FileName = "openFileDialog1";
//            // 
//            // txt_FileName
//            // 
//            this.txt_FileName.Location = new System.Drawing.Point(889, 442);
//            this.txt_FileName.Name = "txt_FileName";
//            this.txt_FileName.Size = new System.Drawing.Size(245, 22);
//            this.txt_FileName.TabIndex = 13;
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.BackColor = System.Drawing.SystemColors.Info;
//            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
//            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
//            this.label4.Location = new System.Drawing.Point(834, 59);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(171, 27);
//            this.label4.TabIndex = 14;
//            this.label4.Text = "İMPORT İŞLEMİ";
//            // 
//            // cmbox_import
//            // 
//            this.cmbox_import.FormattingEnabled = true;
//            this.cmbox_import.Items.AddRange(new object[] {
//            "tbl_deneme",
//            "tbl_User",
//            "tbl_Cities",
//            "tbl_Tours"});
//            this.cmbox_import.Location = new System.Drawing.Point(889, 514);
//            this.cmbox_import.Name = "cmbox_import";
//            this.cmbox_import.Size = new System.Drawing.Size(245, 24);
//            this.cmbox_import.TabIndex = 15;
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label5.Location = new System.Drawing.Point(645, 512);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(203, 48);
//            this.label5.TabIndex = 16;
//            this.label5.Text = "Hangi Tabloya İmport \r\nEtmek istersiniz";
//            // 
//            // frm_AdminImportExport
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
//            this.ClientSize = new System.Drawing.Size(1254, 667);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.cmbox_import);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.txt_FileName);
//            this.Controls.Add(this.btn_Import);
//            this.Controls.Add(this.btn_Browse);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.dataGridView_Import);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.btn_Export);
//            this.Controls.Add(this.cmbox_Export);
//            this.Controls.Add(this.dataGridView_Export);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Name = "frm_AdminImportExport";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "frm_AdminImportExport";
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Export)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Import)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//        private System.Windows.Forms.DataGridView dataGridView_Export;
//        private System.Windows.Forms.ComboBox cmbox_Export;
//        private System.Windows.Forms.Button btn_Export;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.DataGridView dataGridView_Import;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Button btn_Browse;
//        private System.Windows.Forms.Button btn_Import;
//        private System.Windows.Forms.OpenFileDialog openFileDialog1;
//        private System.Windows.Forms.TextBox txt_FileName;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.ComboBox cmbox_import;
//        private System.Windows.Forms.Label label5;
//    }
//}