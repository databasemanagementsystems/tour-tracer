using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_AdminEditTours : Form
    {
        // Veritabanı bağlantı dizesi
        private string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";

        public frm_AdminEditTours()
        {
            InitializeComponent();
        }

        private void frm_EditSelectedTours_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL sorgusunu tanımla
                    string query = "SELECT * FROM tbl_Tours";

                    // Veri adaptörü ve veri tablosunu oluştur
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        // Veri tablosunu doldur
                        adapter.Fill(dataTable);

                        // DataGridView'e veri tablosunu bağla
                        tourdatagrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu tanımla
                    string query = "UPDATE tbl_Tours SET Start_Time = @Start_Time, End_Time = @End_Time, StaffID = @StaffID, " +
                                   "Price = @Price, DepartureCityID = @DepartureCityID, DestinationCityID = @DestinationCityID " +
                                   "WHERE ID = @ID";

                    // Parametreleri tanımla
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@ID", tourID.Text);
                        cmd.Parameters.AddWithValue("@Start_Time", startdate.Value);
                        cmd.Parameters.AddWithValue("@End_Time", finishdate.Value);
                        cmd.Parameters.AddWithValue("@StaffID", staffID.Text);
                        cmd.Parameters.AddWithValue("@Price", money.Text);
                        cmd.Parameters.AddWithValue("@DepartureCityID", departCity.Text);
                        cmd.Parameters.AddWithValue("@DestinationCityID", arrivalCity.Text);

                        

                        // Güncelleme işlemini gerçekleştir
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Tur bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tourdatagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (tourdatagrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = tourdatagrid.SelectedRows[0].Index;
                DataTable dataTable = (DataTable)tourdatagrid.DataSource;

                // DataGridView'deki seçili satırın bilgilerini TextBox'lara aktar
                tourID.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["ID"]);
                startdate.Value = Convert.ToDateTime(dataTable.Rows[selectedRowIndex]["Start_Time"]);
                finishdate.Value = Convert.ToDateTime(dataTable.Rows[selectedRowIndex]["End_Time"]);
                staffID.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["StaffID"]);
                money.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["Price"]);
                departCity.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["DepartureCityID"]);
                arrivalCity.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["DestinationCityID"]);
                // Diğer TextBox'ları da aynı şekilde ekleyebilirsiniz.
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (tourdatagrid.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = tourdatagrid.SelectedRows[0].Index;
                    DataTable dataTable = (DataTable)tourdatagrid.DataSource;

                    // Seçili turun ID'sini al
                    int tourIDToDelete = Convert.ToInt32(dataTable.Rows[selectedRowIndex]["ID"]);

                    // Bağlantı oluştur
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL sorgusunu tanımla
                        string deleteQuery = "DELETE FROM tbl_Tours WHERE ID = @ID";

                        // Parametreyi tanımla
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", tourIDToDelete);

                            // Silme işlemini gerçekleştir
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Tur başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir tur seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ÖNCE VAR OLAN REZERVASYONLARI İPTAL EDİN " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void turekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı oluştur
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusunu tanımla
                    string insertQuery = "INSERT INTO tbl_Tours (Start_Time, End_Time, StaffID, Price, DepartureCityID, DestinationCityID) " +
                                         "VALUES (@Start_Time, @End_Time, @StaffID, @Price, @DepartureCityID, @DestinationCityID)";

                    // Parametreleri tanımla
                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Start_Time", startdate.Value);
                        cmd.Parameters.AddWithValue("@End_Time", finishdate.Value);
                        cmd.Parameters.AddWithValue("@StaffID", staffID.Text);
                        cmd.Parameters.AddWithValue("@Price", money.Text);
                        cmd.Parameters.AddWithValue("@DepartureCityID", departCity.Text);
                        cmd.Parameters.AddWithValue("@DestinationCityID", arrivalCity.Text);

                        // Yeni turu ekle
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Yeni tur başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tur ekleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

