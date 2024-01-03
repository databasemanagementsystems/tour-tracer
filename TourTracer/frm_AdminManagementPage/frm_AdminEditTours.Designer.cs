namespace TourTracer
{
    partial class frm_AdminEditTours
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tourdatagrid = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblToursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet13 = new TourTracer.TourTracerDataSet13();
            this.tblToursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet12 = new TourTracer.TourTracerDataSet12();
            this.tourTracerDataSet9 = new TourTracer.TourTracerDataSet9();
            this.tblToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter = new TourTracer.TourTracerDataSet9TableAdapters.tbl_ToursTableAdapter();
            this.tbl_ToursTableAdapter1 = new TourTracer.TourTracerDataSet12TableAdapters.tbl_ToursTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tourID = new System.Windows.Forms.TextBox();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Yeni = new System.Windows.Forms.Label();
            this.arrivalCity = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.TextBox();
            this.departCity = new System.Windows.Forms.TextBox();
            this.finishdate = new System.Windows.Forms.DateTimePicker();
            this.GÜNCELLE = new System.Windows.Forms.Button();
            this.tbl_ToursTableAdapter2 = new TourTracer.TourTracerDataSet13TableAdapters.tbl_ToursTableAdapter();
            this.DELETE = new System.Windows.Forms.Button();
            this.tourTracerDataSet6 = new TourTracer.TourTracerDataSet6();
            this.tblCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CitiesTableAdapter = new TourTracer.TourTracerDataSet6TableAdapters.tbl_CitiesTableAdapter();
            this.turekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TUR EKLE VE DÜZENLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 89);
            this.panel1.TabIndex = 2;
            // 
            // tourdatagrid
            // 
            this.tourdatagrid.AllowUserToOrderColumns = true;
            this.tourdatagrid.AutoGenerateColumns = false;
            this.tourdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.departureCityIDDataGridViewTextBoxColumn,
            this.destinationCityIDDataGridViewTextBoxColumn});
            this.tourdatagrid.DataSource = this.tblToursBindingSource2;
            this.tourdatagrid.Location = new System.Drawing.Point(613, 115);
            this.tourdatagrid.Name = "tourdatagrid";
            this.tourdatagrid.RowHeadersWidth = 51;
            this.tourdatagrid.RowTemplate.Height = 24;
            this.tourdatagrid.Size = new System.Drawing.Size(473, 302);
            this.tourdatagrid.TabIndex = 8;
            this.tourdatagrid.SelectionChanged += new System.EventHandler(this.tourdatagrid_SelectionChanged);
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
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureCityIDDataGridViewTextBoxColumn
            // 
            this.departureCityIDDataGridViewTextBoxColumn.DataPropertyName = "DepartureCityID";
            this.departureCityIDDataGridViewTextBoxColumn.HeaderText = "DepartureCityID";
            this.departureCityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureCityIDDataGridViewTextBoxColumn.Name = "departureCityIDDataGridViewTextBoxColumn";
            this.departureCityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationCityIDDataGridViewTextBoxColumn
            // 
            this.destinationCityIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationCityID";
            this.destinationCityIDDataGridViewTextBoxColumn.HeaderText = "DestinationCityID";
            this.destinationCityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationCityIDDataGridViewTextBoxColumn.Name = "destinationCityIDDataGridViewTextBoxColumn";
            this.destinationCityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblToursBindingSource2
            // 
            this.tblToursBindingSource2.DataMember = "tbl_Tours";
            this.tblToursBindingSource2.DataSource = this.tourTracerDataSet13;
            // 
            // tourTracerDataSet13
            // 
            this.tourTracerDataSet13.DataSetName = "TourTracerDataSet13";
            this.tourTracerDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToursBindingSource1
            // 
            this.tblToursBindingSource1.DataMember = "tbl_Tours";
            this.tblToursBindingSource1.DataSource = this.tourTracerDataSet12;
            // 
            // tourTracerDataSet12
            // 
            this.tourTracerDataSet12.DataSetName = "TourTracerDataSet12";
            this.tourTracerDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourTracerDataSet9
            // 
            this.tourTracerDataSet9.DataSetName = "TourTracerDataSet9";
            this.tourTracerDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToursBindingSource
            // 
            this.tblToursBindingSource.DataMember = "tbl_Tours";
            this.tblToursBindingSource.DataSource = this.tourTracerDataSet9;
            // 
            // tbl_ToursTableAdapter
            // 
            this.tbl_ToursTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ToursTableAdapter1
            // 
            this.tbl_ToursTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(38, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID";
            // 
            // tourID
            // 
            this.tourID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tourID.ForeColor = System.Drawing.Color.Red;
            this.tourID.Location = new System.Drawing.Point(258, 134);
            this.tourID.Name = "tourID";
            this.tourID.ReadOnly = true;
            this.tourID.Size = new System.Drawing.Size(330, 22);
            this.tourID.TabIndex = 54;
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(258, 160);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(330, 22);
            this.startdate.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(38, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Varış Noktası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(38, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Kalkış Noktası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(38, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(38, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Personel Bilgisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(38, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Bitiş Zamanı";
            // 
            // Yeni
            // 
            this.Yeni.AutoSize = true;
            this.Yeni.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yeni.ForeColor = System.Drawing.Color.Indigo;
            this.Yeni.Location = new System.Drawing.Point(38, 161);
            this.Yeni.Name = "Yeni";
            this.Yeni.Size = new System.Drawing.Size(160, 24);
            this.Yeni.TabIndex = 45;
            this.Yeni.Text = "Başlangıç Zamanı";
            // 
            // arrivalCity
            // 
            this.arrivalCity.BackColor = System.Drawing.Color.SkyBlue;
            this.arrivalCity.Location = new System.Drawing.Point(256, 301);
            this.arrivalCity.Name = "arrivalCity";
            this.arrivalCity.Size = new System.Drawing.Size(328, 22);
            this.arrivalCity.TabIndex = 44;
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.LightSkyBlue;
            this.money.ForeColor = System.Drawing.Color.Red;
            this.money.Location = new System.Drawing.Point(258, 245);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(328, 22);
            this.money.TabIndex = 43;
            // 
            // staffID
            // 
            this.staffID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.staffID.ForeColor = System.Drawing.Color.Red;
            this.staffID.Location = new System.Drawing.Point(258, 216);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(328, 22);
            this.staffID.TabIndex = 42;
            // 
            // departCity
            // 
            this.departCity.BackColor = System.Drawing.Color.LightSkyBlue;
            this.departCity.ForeColor = System.Drawing.Color.Red;
            this.departCity.Location = new System.Drawing.Point(258, 272);
            this.departCity.Name = "departCity";
            this.departCity.Size = new System.Drawing.Size(328, 22);
            this.departCity.TabIndex = 40;
            // 
            // finishdate
            // 
            this.finishdate.Location = new System.Drawing.Point(258, 190);
            this.finishdate.Name = "finishdate";
            this.finishdate.Size = new System.Drawing.Size(330, 22);
            this.finishdate.TabIndex = 56;
            // 
            // GÜNCELLE
            // 
            this.GÜNCELLE.BackColor = System.Drawing.Color.DarkOrange;
            this.GÜNCELLE.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GÜNCELLE.ForeColor = System.Drawing.SystemColors.Info;
            this.GÜNCELLE.Location = new System.Drawing.Point(204, 342);
            this.GÜNCELLE.Name = "GÜNCELLE";
            this.GÜNCELLE.Size = new System.Drawing.Size(170, 49);
            this.GÜNCELLE.TabIndex = 57;
            this.GÜNCELLE.Text = "GÜNCELLE";
            this.GÜNCELLE.UseVisualStyleBackColor = false;
            this.GÜNCELLE.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_ToursTableAdapter2
            // 
            this.tbl_ToursTableAdapter2.ClearBeforeFill = true;
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.OrangeRed;
            this.DELETE.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DELETE.ForeColor = System.Drawing.SystemColors.Info;
            this.DELETE.Location = new System.Drawing.Point(380, 342);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(170, 49);
            this.DELETE.TabIndex = 58;
            this.DELETE.Text = "SİL";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // tourTracerDataSet6
            // 
            this.tourTracerDataSet6.DataSetName = "TourTracerDataSet6";
            this.tourTracerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCitiesBindingSource
            // 
            this.tblCitiesBindingSource.DataMember = "tbl_Cities";
            this.tblCitiesBindingSource.DataSource = this.tourTracerDataSet6;
            // 
            // tbl_CitiesTableAdapter
            // 
            this.tbl_CitiesTableAdapter.ClearBeforeFill = true;
            // 
            // turekle
            // 
            this.turekle.BackColor = System.Drawing.Color.Chartreuse;
            this.turekle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turekle.ForeColor = System.Drawing.SystemColors.Info;
            this.turekle.Location = new System.Drawing.Point(28, 342);
            this.turekle.Name = "turekle";
            this.turekle.Size = new System.Drawing.Size(170, 49);
            this.turekle.TabIndex = 59;
            this.turekle.Text = "TUR EKLE";
            this.turekle.UseVisualStyleBackColor = false;
            this.turekle.Click += new System.EventHandler(this.turekle_Click);
            // 
            // frm_AdminEditTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1520, 548);
            this.Controls.Add(this.turekle);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.GÜNCELLE);
            this.Controls.Add(this.finishdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tourID);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Yeni);
            this.Controls.Add(this.arrivalCity);
            this.Controls.Add(this.money);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.departCity);
            this.Controls.Add(this.tourdatagrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminEditTours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EditSelectedTours";
            this.Load += new System.EventHandler(this.frm_EditSelectedTours_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private TourTracerDataSet6 tourTracerDataSet6;
        private System.Windows.Forms.BindingSource tblCitiesBindingSource;
        private TourTracerDataSet6TableAdapters.tbl_CitiesTableAdapter tbl_CitiesTableAdapter;
        private System.Windows.Forms.DataGridView tourdatagrid;
        private TourTracerDataSet9 tourTracerDataSet9;
        private System.Windows.Forms.BindingSource tblToursBindingSource;
        private TourTracerDataSet9TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter;
        private TourTracerDataSet12 tourTracerDataSet12;
        private System.Windows.Forms.BindingSource tblToursBindingSource1;
        private TourTracerDataSet12TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tourID;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Yeni;
        private System.Windows.Forms.TextBox arrivalCity;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.TextBox departCity;
        private System.Windows.Forms.DateTimePicker finishdate;
        private System.Windows.Forms.Button GÜNCELLE;
        private TourTracerDataSet13 tourTracerDataSet13;
        private System.Windows.Forms.BindingSource tblToursBindingSource2;
        private TourTracerDataSet13TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter2;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button turekle;
    }
}