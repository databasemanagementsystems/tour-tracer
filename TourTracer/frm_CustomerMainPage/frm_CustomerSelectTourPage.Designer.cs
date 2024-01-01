namespace TourTracer
{
    partial class frm_CustomerSelectTourPage
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet3 = new TourTracer.TourTracerDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.tourTracerDataSet1 = new TourTracer.TourTracerDataSet1();
            this.tourTracerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter = new TourTracer.TourTracerDataSet3TableAdapters.tbl_ToursTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tourTracerDataSet4 = new TourTracer.TourTracerDataSet4();
            this.tblToursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter1 = new TourTracer.TourTracerDataSet4TableAdapters.tbl_ToursTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(34, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.Size = new System.Drawing.Size(768, 581);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.cityIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblToursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(678, 372);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "CityID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "CityID";
            this.cityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            this.cityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblToursBindingSource
            // 
            this.tblToursBindingSource.DataMember = "tbl_Tours";
            this.tblToursBindingSource.DataSource = this.tourTracerDataSet3;
            // 
            // tourTracerDataSet3
            // 
            this.tourTracerDataSet3.DataSetName = "TourTracerDataSet3";
            this.tourTracerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(327, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AKTİF TURLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tourTracerDataSet1
            // 
            this.tourTracerDataSet1.DataSetName = "TourTracerDataSet1";
            this.tourTracerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourTracerDataSet1BindingSource
            // 
            this.tourTracerDataSet1BindingSource.DataSource = this.tourTracerDataSet1;
            this.tourTracerDataSet1BindingSource.Position = 0;
            // 
            // tbl_ToursTableAdapter
            // 
            this.tbl_ToursTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(678, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "TURA KAYIT OL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tourTracerDataSet4
            // 
            this.tourTracerDataSet4.DataSetName = "TourTracerDataSet4";
            this.tourTracerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToursBindingSource1
            // 
            this.tblToursBindingSource1.DataMember = "tbl_Tours";
            this.tblToursBindingSource1.DataSource = this.tourTracerDataSet4;
            // 
            // tbl_ToursTableAdapter1
            // 
            this.tbl_ToursTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(678, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_CustomerSelectTourPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 617);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CustomerSelectTourPage";
            this.Text = "frm_CustomerSelectTourPage";
            this.Load += new System.EventHandler(this.frm_CustomerSelectTourPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tourTracerDataSet1BindingSource;
        private TourTracerDataSet1 tourTracerDataSet1;
        private TourTracerDataSet3 tourTracerDataSet3;
        private System.Windows.Forms.BindingSource tblToursBindingSource;
        private TourTracerDataSet3TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private TourTracerDataSet4 tourTracerDataSet4;
        private System.Windows.Forms.BindingSource tblToursBindingSource1;
        private TourTracerDataSet4TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
    }
}