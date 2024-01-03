using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace TourTracer
{

    public partial class frm_CustomerSelectTourPage : Form
    {
        User user;
        int selectedTourID;
        public frm_CustomerSelectTourPage(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int indexRow;

        private void frm_CustomerSelectTourPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tourTracerDataSet7.tbl_Tours' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ToursTableAdapter4.Fill(this.tourTracerDataSet7.tbl_Tours);
            // TODO: Bu kod satırı 'tourTracerDataSet6.tbl_Tours' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ToursTableAdapter3.Fill(this.tourTracerDataSet6.tbl_Tours);
            // TODO: Bu kod satırı 'tourTracerDataSet5.tbl_Tours' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        }


        private void button1_Click(object sender, EventArgs e)
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

                        // Turun zaten rezerve edilip edilmediğini kontrol etmek için gerekirse IsTourAlreadyBooked fonksiyonunu kullanabilirsiniz.

                        // Örnek sorgu:
                        // if (!IsTourAlreadyBooked(TourID, userID, connection))
                        // {
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
                        // }
                        // else
                        // {
                        //     MessageBox.Show("Bu tur zaten rezerve edilmiş!");
                        // }
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
            textBox1.Text = row.Cells[0].Value.ToString();
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


