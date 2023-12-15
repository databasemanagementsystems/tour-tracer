namespace TourTracer
{
    partial class frm_AdminImportExport
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
            this.dataGridView_Export = new System.Windows.Forms.DataGridView();
            this.cmbox_Export = new System.Windows.Forms.ComboBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Export)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Export
            // 
            this.dataGridView_Export.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Export.Location = new System.Drawing.Point(78, 98);
            this.dataGridView_Export.Name = "dataGridView_Export";
            this.dataGridView_Export.RowHeadersWidth = 51;
            this.dataGridView_Export.RowTemplate.Height = 24;
            this.dataGridView_Export.Size = new System.Drawing.Size(470, 334);
            this.dataGridView_Export.TabIndex = 1;
            this.dataGridView_Export.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Export_CellContentClick);
            // 
            // cmbox_Export
            // 
            this.cmbox_Export.FormattingEnabled = true;
            this.cmbox_Export.Items.AddRange(new object[] {
            "tbl_Cities",
            "tbl_deneme",
            "tbl_User"});
            this.cmbox_Export.Location = new System.Drawing.Point(357, 447);
            this.cmbox_Export.Name = "cmbox_Export";
            this.cmbox_Export.Size = new System.Drawing.Size(182, 24);
            this.cmbox_Export.TabIndex = 3;
            this.cmbox_Export.SelectedIndexChanged += new System.EventHandler(this.cmbox_Export_SelectedIndexChanged);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(419, 477);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(105, 38);
            this.btn_Export.TabIndex = 4;
            this.btn_Export.Text = "EXPORT";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "EXPORT Etmek İstediğiniz Tabloyu Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(229, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "EXPORT İŞLEMİ";
            // 
            // frm_AdminImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.cmbox_Export);
            this.Controls.Add(this.dataGridView_Export);
            this.Name = "frm_AdminImportExport";
            this.Text = "frm_AdminImportExport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Export)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Export;
        private System.Windows.Forms.ComboBox cmbox_Export;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}