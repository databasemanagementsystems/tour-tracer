using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;
using ExcelDataReader;
using System.IO;

namespace TourTracer
{
    public partial class frm_AdminImportExport : Form
    {
        private SqlConnection con;

        public frm_AdminImportExport()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");
        }
        //EXPORT İŞLEMİ
        private void frm_AdminImportExport_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {
                con.Open();

                DataTable dt = con.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    cmbox_Export.Items.Add(tableName);
                    cmbox_import.Items.Add(tableName); // Yeni ComboBox için tablo ekleyin
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cmbox_Export_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbox_Export.SelectedItem != null)
                {
                    string selectedTable = cmbox_Export.SelectedItem.ToString();

                    SqlDataAdapter dr = new SqlDataAdapter($"SELECT * FROM {selectedTable}", con);

                    DataTable dt = new DataTable();
                    dr.Fill(dt);

                    dataGridView_Export.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbox_Export.SelectedItem != null)
                {
                    string selectedTable = cmbox_Export.SelectedItem.ToString();

                    SqlDataAdapter dr = new SqlDataAdapter($"SELECT * FROM {selectedTable}", con);

                    DataTable dt = new DataTable();
                    dr.Fill(dt);

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Export Excel Dosyasını Seçin";
                        saveFileDialog.FileName = $"{selectedTable}_Export.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string excelFilePath = saveFileDialog.FileName;

                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(dt, selectedTable);
                                workbook.SaveAs(excelFilePath);
                            }

                            MessageBox.Show($"Export işlemi başarıyla tamamlandı. Dosya adı: {excelFilePath}", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //İMPORT İŞLEMİ(BROWSE-IMPORT BUTONU İŞLEVİ VE DATAGRİDVİEWE TABLO AKTARMA)
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Select File",
                FileName = txt_FileName.Text,
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                RestoreDirectory = true,
                FilterIndex = 1
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_FileName.Text = openFileDialog1.FileName;

                // Masaüstünden seçilen Excel dosyasını DataGridView'e yükle
                LoadExcelDataToDataGridView(txt_FileName.Text);
            }
        }

        private void LoadExcelDataToDataGridView(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet();
                        dataGridView_Import.DataSource = result.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbox_import.SelectedItem != null)
                {
                    string selectedTable = cmbox_import.SelectedItem.ToString();

                    string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                        {
                            bulkCopy.DestinationTableName = selectedTable;
                            bulkCopy.WriteToServer((DataTable)dataGridView_Import.DataSource);
                        }
                    }

                    MessageBox.Show("Import işlemi başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //BACKUP İŞLEMİ
        private void btn_backup_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";
            try
            {
                // C:\BackupAndRestoreTourTracer klasörüne yedekleme dosyasını kaydet
                string backupFolder = @"C:\BackupAndRestoreTourTracer\";
                string backupFileName = "TourTracerBackup.bak";
                string backupPath = Path.Combine(backupFolder, backupFileName);

                // Dosya zaten var mı kontrol et
                int counter = 1;
                while (File.Exists(backupPath))
                {
                    // Dosya adına numara ekleyerek tekrar oluştur
                    backupFileName = $"TourTracerBackup_{counter}.bak";
                    backupPath = Path.Combine(backupFolder, backupFileName);
                    counter++;
                }

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

        private void btn_restore_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";
            try
            {
                // Restore işlemi için dosya seçme penceresi
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "SQL Backup Files (*.bak)|*.bak";
                openFileDialog.Title = "Veritabanı Yedeği Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupPath = openFileDialog.FileName;

                    // Veritabanı ismi
                    string databaseName = "TourTracer";

                    // Veritabanı restore işlemi
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Restore sorgusu
                        string restoreQuery = $"USE master; RESTORE DATABASE [{databaseName}] FROM DISK = '{backupPath}' WITH REPLACE;";

                        using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Veritabanı başarıyla geri yüklendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    }
}

