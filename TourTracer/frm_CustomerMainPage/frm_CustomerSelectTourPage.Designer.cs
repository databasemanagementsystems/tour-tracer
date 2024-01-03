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
            this.tblToursBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet6 = new TourTracer.TourTracerDataSet6();
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
            this.tourTracerDataSet5 = new TourTracer.TourTracerDataSet5();
            this.tblToursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter2 = new TourTracer.TourTracerDataSet5TableAdapters.tbl_ToursTableAdapter();
            this.tbl_ToursTableAdapter3 = new TourTracer.TourTracerDataSet6TableAdapters.tbl_ToursTableAdapter();
            this.tourTracerDataSet7 = new TourTracer.TourTracerDataSet7();
            this.tblToursBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter4 = new TourTracer.TourTracerDataSet7TableAdapters.tbl_ToursTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureCityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationCityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource4)).BeginInit();
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.DepartureCityID,
            this.DestinationCityID});
            this.dataGridView1.DataSource = this.tblToursBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(75, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 372);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tblToursBindingSource3
            // 
            this.tblToursBindingSource3.DataMember = "tbl_Tours";
            this.tblToursBindingSource3.DataSource = this.tourTracerDataSet6;
            // 
            // tourTracerDataSet6
            // 
            this.tourTracerDataSet6.DataSetName = "TourTracerDataSet6";
            this.tourTracerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Location = new System.Drawing.Point(75, 497);
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
            this.textBox1.Location = new System.Drawing.Point(75, 448);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(678, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tourTracerDataSet5
            // 
            this.tourTracerDataSet5.DataSetName = "TourTracerDataSet5";
            this.tourTracerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToursBindingSource2
            // 
            this.tblToursBindingSource2.DataMember = "tbl_Tours";
            this.tblToursBindingSource2.DataSource = this.tourTracerDataSet5;
            // 
            // tbl_ToursTableAdapter2
            // 
            this.tbl_ToursTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_ToursTableAdapter3
            // 
            this.tbl_ToursTableAdapter3.ClearBeforeFill = true;
            // 
            // tourTracerDataSet7
            // 
            this.tourTracerDataSet7.DataSetName = "TourTracerDataSet7";
            this.tourTracerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToursBindingSource4
            // 
            this.tblToursBindingSource4.DataMember = "tbl_Tours";
            this.tblToursBindingSource4.DataSource = this.tourTracerDataSet7;
            // 
            // tbl_ToursTableAdapter4
            // 
            this.tbl_ToursTableAdapter4.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 60;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // DepartureCityID
            // 
            this.DepartureCityID.DataPropertyName = "DepartureCityID";
            this.DepartureCityID.HeaderText = "DepartureCityID";
            this.DepartureCityID.MinimumWidth = 6;
            this.DepartureCityID.Name = "DepartureCityID";
            this.DepartureCityID.Width = 110;
            // 
            // DestinationCityID
            // 
            this.DestinationCityID.DataPropertyName = "DestinationCityID";
            this.DestinationCityID.HeaderText = "DestinationCityID";
            this.DestinationCityID.MinimumWidth = 6;
            this.DestinationCityID.Name = "DestinationCityID";
            this.DestinationCityID.Width = 110;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource4)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private TourTracerDataSet4 tourTracerDataSet4;
        private System.Windows.Forms.BindingSource tblToursBindingSource1;
        private TourTracerDataSet4TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private TourTracerDataSet5 tourTracerDataSet5;
        private System.Windows.Forms.BindingSource tblToursBindingSource2;
        private TourTracerDataSet5TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter2;
        private TourTracerDataSet6 tourTracerDataSet6;
        private System.Windows.Forms.BindingSource tblToursBindingSource3;
        private TourTracerDataSet6TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter3;
        private TourTracerDataSet7 tourTracerDataSet7;
        private System.Windows.Forms.BindingSource tblToursBindingSource4;
        private TourTracerDataSet7TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureCityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationCityID;
    }
}