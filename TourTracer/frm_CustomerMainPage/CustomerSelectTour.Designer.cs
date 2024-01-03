namespace TourTracer
{
    partial class CustomerSelectTour
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
            this.tblToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet14 = new TourTracer.TourTracerDataSet14();
            this.kayıtOl = new System.Windows.Forms.Button();
            this.secilenDeger = new System.Windows.Forms.TextBox();
            this.tbl_ToursTableAdapter = new TourTracer.TourTracerDataSet14TableAdapters.tbl_ToursTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tourTracerDataSet15 = new TourTracer.TourTracerDataSet15();
            this.vwCustomizedToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_CustomizedToursTableAdapter = new TourTracer.TourTracerDataSet15TableAdapters.vw_CustomizedToursTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tourTracerDataSet16 = new TourTracer.TourTracerDataSet16();
            this.vwCustomizedToursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_CustomizedToursTableAdapter1 = new TourTracer.TourTracerDataSet16TableAdapters.vw_CustomizedToursTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTracerDataSet17 = new TourTracer.TourTracerDataSet17();
            this.vwCustomizedToursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_CustomizedToursTableAdapter2 = new TourTracer.TourTracerDataSet17TableAdapters.vw_CustomizedToursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomizedToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomizedToursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomizedToursBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblToursBindingSource
            // 
            this.tblToursBindingSource.DataMember = "tbl_Tours";
            this.tblToursBindingSource.DataSource = this.tourTracerDataSet14;
            // 
            // tourTracerDataSet14
            // 
            this.tourTracerDataSet14.DataSetName = "TourTracerDataSet14";
            this.tourTracerDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayıtOl
            // 
            this.kayıtOl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtOl.Location = new System.Drawing.Point(289, 545);
            this.kayıtOl.Name = "kayıtOl";
            this.kayıtOl.Size = new System.Drawing.Size(266, 40);
            this.kayıtOl.TabIndex = 1;
            this.kayıtOl.Text = "Tura Kayıt Ol";
            this.kayıtOl.UseVisualStyleBackColor = true;
            this.kayıtOl.Click += new System.EventHandler(this.kayıtOl_Click);
            // 
            // secilenDeger
            // 
            this.secilenDeger.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilenDeger.Location = new System.Drawing.Point(299, 478);
            this.secilenDeger.Name = "secilenDeger";
            this.secilenDeger.Size = new System.Drawing.Size(266, 33);
            this.secilenDeger.TabIndex = 2;
            // 
            // tbl_ToursTableAdapter
            // 
            this.tbl_ToursTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen Tur ID:";
            // 
            // tourTracerDataSet15
            // 
            this.tourTracerDataSet15.DataSetName = "TourTracerDataSet15";
            this.tourTracerDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCustomizedToursBindingSource
            // 
            this.vwCustomizedToursBindingSource.DataMember = "vw_CustomizedTours";
            this.vwCustomizedToursBindingSource.DataSource = this.tourTracerDataSet15;
            // 
            // vw_CustomizedToursTableAdapter
            // 
            this.vw_CustomizedToursTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.departureCityDataGridViewTextBoxColumn,
            this.destinationCityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwCustomizedToursBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(49, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 377);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tourTracerDataSet16
            // 
            this.tourTracerDataSet16.DataSetName = "TourTracerDataSet16";
            this.tourTracerDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCustomizedToursBindingSource1
            // 
            this.vwCustomizedToursBindingSource1.DataMember = "vw_CustomizedTours";
            this.vwCustomizedToursBindingSource1.DataSource = this.tourTracerDataSet16;
            // 
            // vw_CustomizedToursTableAdapter1
            // 
            this.vw_CustomizedToursTableAdapter1.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureCityDataGridViewTextBoxColumn
            // 
            this.departureCityDataGridViewTextBoxColumn.DataPropertyName = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.HeaderText = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureCityDataGridViewTextBoxColumn.Name = "departureCityDataGridViewTextBoxColumn";
            this.departureCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationCityDataGridViewTextBoxColumn
            // 
            this.destinationCityDataGridViewTextBoxColumn.DataPropertyName = "DestinationCity";
            this.destinationCityDataGridViewTextBoxColumn.HeaderText = "DestinationCity";
            this.destinationCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationCityDataGridViewTextBoxColumn.Name = "destinationCityDataGridViewTextBoxColumn";
            this.destinationCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // tourTracerDataSet17
            // 
            this.tourTracerDataSet17.DataSetName = "TourTracerDataSet17";
            this.tourTracerDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCustomizedToursBindingSource2
            // 
            this.vwCustomizedToursBindingSource2.DataMember = "vw_CustomizedTours";
            this.vwCustomizedToursBindingSource2.DataSource = this.tourTracerDataSet17;
            // 
            // vw_CustomizedToursTableAdapter2
            // 
            this.vw_CustomizedToursTableAdapter2.ClearBeforeFill = true;
            // 
            // CustomerSelectTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1244, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secilenDeger);
            this.Controls.Add(this.kayıtOl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerSelectTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerSelectTour";
            this.Load += new System.EventHandler(this.CustomerSelectTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomizedToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomizedToursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomizedToursBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayıtOl;
        private System.Windows.Forms.TextBox secilenDeger;
        private TourTracerDataSet14 tourTracerDataSet14;
        private System.Windows.Forms.BindingSource tblToursBindingSource;
        private TourTracerDataSet14TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter;
        private System.Windows.Forms.Label label1;
        private TourTracerDataSet15 tourTracerDataSet15;
        private System.Windows.Forms.BindingSource vwCustomizedToursBindingSource;
        private TourTracerDataSet15TableAdapters.vw_CustomizedToursTableAdapter vw_CustomizedToursTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TourTracerDataSet16 tourTracerDataSet16;
        private System.Windows.Forms.BindingSource vwCustomizedToursBindingSource1;
        private TourTracerDataSet16TableAdapters.vw_CustomizedToursTableAdapter vw_CustomizedToursTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCityDataGridViewTextBoxColumn;
        private TourTracerDataSet17 tourTracerDataSet17;
        private System.Windows.Forms.BindingSource vwCustomizedToursBindingSource2;
        private TourTracerDataSet17TableAdapters.vw_CustomizedToursTableAdapter vw_CustomizedToursTableAdapter2;
    }
}