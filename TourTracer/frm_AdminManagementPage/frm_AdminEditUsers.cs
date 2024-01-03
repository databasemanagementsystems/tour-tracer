using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TourTracer
{
    public partial class frm_AdminEditUsers : Form
    {
        // Bağlantı dizesi
        private string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";

        public frm_AdminEditUsers()
        {
            InitializeComponent();
        }
        private void frm_AdminEditUsers_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL sorgusunu tanımla
                    string query = "SELECT * FROM tbl_Users";

                    // Veri adaptörü ve veri tablosunu oluştur
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        // Veri tablosunu doldur
                        adapter.Fill(dataTable);

                        // DataGridView'e veri tablosunu bağla
                        guncelletablosu.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Güncelle butonu
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu tanımla
                    string query = "UPDATE tbl_Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                                   "PhoneNumber = @PhoneNumber, Role = @Role, BirthDate = @BirthDate, Password = @Password " +
                                   "WHERE ID = @ID";

                    // Parametreleri tanımla
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", userID.Text);
                        cmd.Parameters.AddWithValue("@FirstName", name.Text);
                        cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", telefon.Text);
                        cmd.Parameters.AddWithValue("@Role", role.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", date.Value);
                        cmd.Parameters.AddWithValue("@Password", password.Text);

                        // Güncelleme işlemini gerçekleştir
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guncelletablosu_SelectionChanged(object sender, EventArgs e)
        {
            if (guncelletablosu.SelectedRows.Count > 0)
            {
                // DataGridView'deki seçili satırın indeksini al
                int selectedRowIndex = guncelletablosu.SelectedRows[0].Index;

                // DataGridView'deki verilerin bulunduğu DataTable'ı al
                DataTable dataTable = (DataTable)guncelletablosu.DataSource;

                // DataTable'daki seçili satırın verilerini TextBox'lara aktar
                userID.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["ID"]);
                name.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["FirstName"]);
                lastname.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["LastName"]);
                email.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["Email"]);
                telefon.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["PhoneNumber"]);
                role.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["Role"]);
                date.Value = Convert.ToDateTime(dataTable.Rows[selectedRowIndex]["BirthDate"]);
                password.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["Password"]);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Veri tabanından verileri çek
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_Users";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView'e veri tablosunu bağla
                        guncelletablosu.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            guncelletablosu.DataSource =  tblUsersBindingSource1;  
        }
    }
}
