using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_BackupAndRestore : Form
    {
        // Veritabanı bağlantı dizesi
        private string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";

        public frm_BackupAndRestore()
        {
            InitializeComponent();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                // C:\31 klasörüne yedekleme dosyasını kaydet
                string backupPath = @"C:\BackupAndRestoreTourTracer\TourTracerBackup.bak";

                // Veritabanı yedeği alma işlemi
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Yedekleme sorgusu
                    string backupQuery = $"BACKUP DATABASE [TourTracer] TO DISK = '{backupPath}'";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Veritabanı yedeği başarıyla alındı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
