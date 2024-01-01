namespace TourTracer
{
    partial class frm_AdminShowsDeletedToursAndCustomers
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
            this.label3 = new System.Windows.Forms.Label();
            this.tblDeletedUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet2 = new TourTracer.TourTracerDataSet2();
            this.tourTracerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet = new TourTracer.TourTracerDataSet();
            this.tblDeletedToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet3 = new TourTracer.TourTracerDataSet3();
            this.tbl_DeletedUsersTableAdapter = new TourTracer.TourTracerDataSet2TableAdapters.tbl_DeletedUsersTableAdapter();
            this.tbl_DeletedToursTableAdapter = new TourTracer.TourTracerDataSet3TableAdapters.tbl_DeletedToursTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTracerDataSet4 = new TourTracer.TourTracerDataSet4();
            this.tblDeletedToursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DeletedToursTableAdapter1 = new TourTracer.TourTracerDataSet4TableAdapters.tbl_DeletedToursTableAdapter();
            this.tourTracerDataSet5 = new TourTracer.TourTracerDataSet5();
            this.tblDeletedUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DeletedUsersTableAdapter1 = new TourTracer.TourTracerDataSet5TableAdapters.tbl_DeletedUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedToursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedToursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedUsersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinen Kullanıcılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Silinen Turlar";
            // 
            // tblDeletedUsersBindingSource
            // 
            this.tblDeletedUsersBindingSource.DataMember = "tbl_DeletedUsers";
            this.tblDeletedUsersBindingSource.DataSource = this.tourTracerDataSet2;
            // 
            // tourTracerDataSet2
            // 
            this.tourTracerDataSet2.DataSetName = "TourTracerDataSet2";
            this.tourTracerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblDeletedToursBindingSource
            // 
            this.tblDeletedToursBindingSource.DataMember = "tbl_DeletedTours";
            this.tblDeletedToursBindingSource.DataSource = this.tourTracerDataSet3;
            // 
            // tourTracerDataSet3
            // 
            this.tourTracerDataSet3.DataSetName = "TourTracerDataSet3";
            this.tourTracerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DeletedUsersTableAdapter
            // 
            this.tbl_DeletedUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DeletedToursTableAdapter
            // 
            this.tbl_DeletedToursTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDeletedUsersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.cityIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDeletedToursBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(31, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1086, 174);
            this.dataGridView2.TabIndex = 4;
            // 
            // ıDDataGridViewTextBoxColumn1
            // 
            this.ıDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn1.Name = "ıDDataGridViewTextBoxColumn1";
            this.ıDDataGridViewTextBoxColumn1.Width = 125;
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
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "CityID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "CityID";
            this.cityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            this.cityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tourTracerDataSet4
            // 
            this.tourTracerDataSet4.DataSetName = "TourTracerDataSet4";
            this.tourTracerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDeletedToursBindingSource1
            // 
            this.tblDeletedToursBindingSource1.DataMember = "tbl_DeletedTours";
            this.tblDeletedToursBindingSource1.DataSource = this.tourTracerDataSet4;
            // 
            // tbl_DeletedToursTableAdapter1
            // 
            this.tbl_DeletedToursTableAdapter1.ClearBeforeFill = true;
            // 
            // tourTracerDataSet5
            // 
            this.tourTracerDataSet5.DataSetName = "TourTracerDataSet5";
            this.tourTracerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDeletedUsersBindingSource1
            // 
            this.tblDeletedUsersBindingSource1.DataMember = "tbl_DeletedUsers";
            this.tblDeletedUsersBindingSource1.DataSource = this.tourTracerDataSet5;
            // 
            // tbl_DeletedUsersTableAdapter1
            // 
            this.tbl_DeletedUsersTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_AdminShowsDeletedToursAndCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 532);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminShowsDeletedToursAndCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DeletedTours";
            this.Load += new System.EventHandler(this.frm_AdminShowsDeletedToursAndCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedToursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedToursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedUsersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tourTracerDataSetBindingSource;
        private TourTracerDataSet tourTracerDataSet;
        private TourTracerDataSet2 tourTracerDataSet2;
        private System.Windows.Forms.BindingSource tblDeletedUsersBindingSource;
        private TourTracerDataSet2TableAdapters.tbl_DeletedUsersTableAdapter tbl_DeletedUsersTableAdapter;
        private TourTracerDataSet3 tourTracerDataSet3;
        private System.Windows.Forms.BindingSource tblDeletedToursBindingSource;
        private TourTracerDataSet3TableAdapters.tbl_DeletedToursTableAdapter tbl_DeletedToursTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private TourTracerDataSet4 tourTracerDataSet4;
        private System.Windows.Forms.BindingSource tblDeletedToursBindingSource1;
        private TourTracerDataSet4TableAdapters.tbl_DeletedToursTableAdapter tbl_DeletedToursTableAdapter1;
        private TourTracerDataSet5 tourTracerDataSet5;
        private System.Windows.Forms.BindingSource tblDeletedUsersBindingSource1;
        private TourTracerDataSet5TableAdapters.tbl_DeletedUsersTableAdapter tbl_DeletedUsersTableAdapter1;
    }
}