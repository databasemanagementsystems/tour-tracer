namespace TourTracer
{
    partial class frm_AdminEditUsers
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
            this.button3 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Yeni = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.guncelletablosu = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tourTracerDataSet8 = new TourTracer.TourTracerDataSet8();
            this.tourTracerDataSet7 = new TourTracer.TourTracerDataSet7();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UsersTableAdapter = new TourTracer.TourTracerDataSet7TableAdapters.tbl_UsersTableAdapter();
            this.tbl_UsersTableAdapter1 = new TourTracer.TourTracerDataSet8TableAdapters.tbl_UsersTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.DELETEUSER = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guncelletablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(683, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICIYI DÜZENLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-138, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1717, 118);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(257, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 85);
            this.button3.TabIndex = 31;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(276, 274);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(330, 22);
            this.date.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(58, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kullanıcı Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(58, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kullanıcı Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(58, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kullanıcı Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(58, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kullanıcı e-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(58, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kullanıcı Soyadı";
            // 
            // Yeni
            // 
            this.Yeni.AutoSize = true;
            this.Yeni.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yeni.ForeColor = System.Drawing.Color.Indigo;
            this.Yeni.Location = new System.Drawing.Point(58, 163);
            this.Yeni.Name = "Yeni";
            this.Yeni.Size = new System.Drawing.Size(124, 24);
            this.Yeni.TabIndex = 22;
            this.Yeni.Text = "Kullanıcı İsim";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.SkyBlue;
            this.password.Location = new System.Drawing.Point(276, 303);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(328, 22);
            this.password.TabIndex = 21;
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.telefon.ForeColor = System.Drawing.Color.Red;
            this.telefon.Location = new System.Drawing.Point(278, 247);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(328, 22);
            this.telefon.TabIndex = 20;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.LightSkyBlue;
            this.email.ForeColor = System.Drawing.Color.Red;
            this.email.Location = new System.Drawing.Point(278, 218);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(328, 22);
            this.email.TabIndex = 19;
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lastname.ForeColor = System.Drawing.Color.Red;
            this.lastname.Location = new System.Drawing.Point(278, 190);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(328, 22);
            this.lastname.TabIndex = 18;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.LightSkyBlue;
            this.name.ForeColor = System.Drawing.Color.Red;
            this.name.Location = new System.Drawing.Point(278, 164);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(328, 22);
            this.name.TabIndex = 17;
            // 
            // guncelletablosu
            // 
            this.guncelletablosu.AllowUserToOrderColumns = true;
            this.guncelletablosu.AutoGenerateColumns = false;
            this.guncelletablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guncelletablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.guncelletablosu.DataSource = this.tblUsersBindingSource1;
            this.guncelletablosu.Location = new System.Drawing.Point(628, 134);
            this.guncelletablosu.Name = "guncelletablosu";
            this.guncelletablosu.RowHeadersWidth = 51;
            this.guncelletablosu.RowTemplate.Height = 24;
            this.guncelletablosu.Size = new System.Drawing.Size(642, 344);
            this.guncelletablosu.TabIndex = 33;
            this.guncelletablosu.SelectionChanged += new System.EventHandler(this.guncelletablosu_SelectionChanged);
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
            // tblUsersBindingSource1
            // 
            this.tblUsersBindingSource1.DataMember = "tbl_Users";
            this.tblUsersBindingSource1.DataSource = this.tourTracerDataSet8;
            // 
            // tourTracerDataSet8
            // 
            this.tourTracerDataSet8.DataSetName = "TourTracerDataSet8";
            this.tourTracerDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourTracerDataSet7
            // 
            this.tourTracerDataSet7.DataSetName = "TourTracerDataSet7";
            this.tourTracerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.tourTracerDataSet7;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_UsersTableAdapter1
            // 
            this.tbl_UsersTableAdapter1.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(58, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Role";
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.SkyBlue;
            this.role.Location = new System.Drawing.Point(276, 336);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(328, 22);
            this.role.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(58, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID";
            // 
            // userID
            // 
            this.userID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.userID.ForeColor = System.Drawing.Color.Red;
            this.userID.Location = new System.Drawing.Point(278, 136);
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Size = new System.Drawing.Size(330, 22);
            this.userID.TabIndex = 38;
            // 
            // DELETEUSER
            // 
            this.DELETEUSER.BackColor = System.Drawing.Color.Red;
            this.DELETEUSER.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DELETEUSER.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DELETEUSER.Location = new System.Drawing.Point(434, 383);
            this.DELETEUSER.Name = "DELETEUSER";
            this.DELETEUSER.Size = new System.Drawing.Size(140, 70);
            this.DELETEUSER.TabIndex = 40;
            this.DELETEUSER.Text = "SİL";
            this.DELETEUSER.UseVisualStyleBackColor = false;
            this.DELETEUSER.Click += new System.EventHandler(this.DELETEUSER_Click);
            // 
            // frm_AdminEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1535, 631);
            this.Controls.Add(this.DELETEUSER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.role);
            this.Controls.Add(this.guncelletablosu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Yeni);
            this.Controls.Add(this.password);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminEditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AdminEditCustomerTours";
            this.Load += new System.EventHandler(this.frm_AdminEditUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guncelletablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Yeni;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView guncelletablosu;
        private TourTracerDataSet7 tourTracerDataSet7;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private TourTracerDataSet7TableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private TourTracerDataSet8 tourTracerDataSet8;
        private System.Windows.Forms.BindingSource tblUsersBindingSource1;
        private TourTracerDataSet8TableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Button DELETEUSER;
    }
}