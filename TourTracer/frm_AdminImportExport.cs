using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace TourTracer
{
    public partial class frm_AdminImportExport : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");
        private SqlDataAdapter dr;

        public frm_AdminImportExport()
        {
            InitializeComponent();
        }

        private void frm_AdminImportExport_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {
                con.Open();

                // Veritabanındaki tablo isimlerini al
                DataTable dt = con.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    cmbox_Export.Items.Add(tableName);
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

                    // Veritabanındaki tabloyu seç
                    dr = new SqlDataAdapter($"SELECT * FROM {selectedTable}", con);

                    // Verileri DataTable'e yükle
                    DataTable dt = new DataTable();
                    dr.Fill(dt);

                    // DataGridView'e veriyi bağla
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

                    // Veritabanındaki tabloyu seç
                    dr = new SqlDataAdapter($"SELECT * FROM {selectedTable}", con);

                    // Verileri DataTable'e yükle
                    DataTable dt = new DataTable();
                    dr.Fill(dt);

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Export Excel Dosyasını Seçin";
                        saveFileDialog.FileName = $"{selectedTable}_Export.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Dosya konumunu ve adını kullanıcı seçsin
                            string excelFilePath = saveFileDialog.FileName;

                            // DataTable'ı Excel dosyasına export et
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                workbook.Worksheets.Add(dt, selectedTable);
                                workbook.SaveAs(excelFilePath);
                            }

                            MessageBox.Show($"Export işlemi başarıyla tamamlandı. Dosya adı: {excelFilePath}","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Export_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView hücre tıklama olayları buraya eklenir
        }
    }
}
