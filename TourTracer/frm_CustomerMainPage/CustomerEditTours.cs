using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class CustomerEditTours : Form
    {
        User user;
        public CustomerEditTours(User user )
        {
            this.user = user;
            InitializeComponent();
        }
        public void DisplayTours(int customerId)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True"; // Veritabanı bağlantı dizesi
            string query = @"
        SELECT t.ID, t.Start_Time, t.End_Time, c.CityName AS DepartureCity, c2.CityName AS DestinationCity
        FROM tbl_Tours t
        JOIN tbl_Bookings b ON t.ID = b.TourID
        JOIN tbl_Cities c ON t.DepartureCityID = c.PlateNumber
        JOIN tbl_Cities c2 ON t.DestinationCityID = c2.PlateNumber
        WHERE b.CustomerID = @CustomerId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                try
                {
                    conn.Open();
                    adapter.Fill(ds, "Tours");

                    dataGridView1.DataSource = ds.Tables["Tours"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
      

        private void CustomerEditTours_Load(object sender, EventArgs e)
        {
            DisplayTours(user.ID);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // DataGridView'deki seçili satırın bilgilerini TextBox'lara aktar
                secilenID.Text = Convert.ToString(dataTable.Rows[selectedRowIndex]["ID"]);
               
                // Diğer TextBox'ları da aynı şekilde ekleyebilirsiniz.
            }
        }
        private string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";
        private void silmeButonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTourID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Bookings tablosundan ilgili kaydı silen SQL sorgusu
                        string deleteQuery = "DELETE FROM tbl_Bookings WHERE TourID = @TourID and CustomerID = @CustomerID";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@TourID", selectedTourID);
                            cmd.Parameters.AddWithValue("@CustomerID", user.ID);
                          
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Rezervasyon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tur listesini güncelle
                            DisplayTours(user.ID);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rezervasyon silme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir tur seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
