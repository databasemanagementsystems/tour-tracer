using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class CustomerSelectTour : Form
    {
        User user;
        int selectedTourID;
        public CustomerSelectTour(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int indexRow;
        private void CustomerSelectTour_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourTracerDataSet17.vw_CustomizedTours' table. You can move, or remove it, as needed.
            this.vw_CustomizedToursTableAdapter2.Fill(this.tourTracerDataSet17.vw_CustomizedTours);
            // TODO: This line of code loads data into the 'tourTracerDataSet14.tbl_Tours' table. You can move, or remove it, as needed.
            this.tbl_ToursTableAdapter.Fill(this.tourTracerDataSet14.tbl_Tours);

        }

        private void kayıtOl_Click(object sender, EventArgs e)
        {
            // Seçilen satırın indeksini al
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int TourID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ıDDataGridViewTextBoxColumn"].Value);

                // Kullanıcıya ait bilgileri al
                int userID = user.ID; // Kullanıcı ID'sini al

                // Şimdi tbl_bookings tablosuna yeni bir kayıt ekleyelim
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True"))
                    {
                        connection.Open();

                        
                        string query = "INSERT INTO tbl_Bookings (TourID, CustomerID) VALUES (@TourID, @CustomerID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TourID", TourID);
                            command.Parameters.AddWithValue("@CustomerID", userID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Rezervasyon başarıyla yapıldı!");
                            }
                            else
                            {
                                MessageBox.Show("Rezervasyon yapılamadı. Bir hata oluştu.");
                            }
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir tur seçin.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            secilenDeger.Text = row.Cells[0].Value.ToString();
        }
    }
}
