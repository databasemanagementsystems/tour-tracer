using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace TourTracer
{
    public partial class frm_CustomerProfilePage : Form
    {

        User user;
        public frm_CustomerProfilePage(User user)
        {
            this.user = user;
            InitializeComponent();
            VerileriGetir();

        }
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Eğer bir User nesnesi mevcut ise
            if (user != null)
            {
                // User nesnesinin FirstName özelliğini label4'ün Text özelliğine ata
                label4.Text = user.FirstName;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                label4.Text = "Kullanıcı bilgileri alınamadı.";
            }

            // Eğer bir User nesnesi mevcut ise
            if (user != null)
            {
                // User nesnesinin LastName özelliğini label5'ün Text özelliğine ata
                label5.Text = user.LastName;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                label5.Text = "Kullanıcı bilgileri alınamadı.";
            }

            // Eğer bir User nesnesi mevcut ise
            if (user != null)
            {
                // User nesnesinin Email özelliğini label1'ün Text özelliğine ata
                label1.Text = user.Email;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                label1.Text = "Kullanıcı bilgileri alınamadı.";
            }
            if (user != null)
            {
                // User nesnesinin PhoneNumber özelliğini label2'ün Text özelliğine ata
                label2.Text = user.PhoneNumber;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                label2.Text = "Kullanıcı bilgileri alınamadı.";
            }
            if (user != null)
            {
                // User nesnesinin PhoneNumber özelliğini labe3'ün Text özelliğine ata
                label3.Text = user.BirthDate.ToShortDateString();
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                label3.Text = "Kullanıcı bilgileri alınamadı.";
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void VerileriGetir()
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";


                string query = "SELECT FirstName FROM tbl_Users WHERE ID = @ID"; // UserID'yi belirtmek önemli

                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ID", 4); // 1 yerine gerçek bir kullanıcı kimliği ekleyin

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                // Yeni bir DataTable oluşturun ve veriyi buraya yükleyin
                                var dataTable = new DataTable();
                                dataTable.Load(reader);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void frm_CustomerProfilePage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tourTracerDataSet2.tbl_Users' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UsersTableAdapter.Fill(this.tourTracerDataSet2.tbl_Users);
            // TODO: Bu kod satırı 'tourTracerDataSet.tbl_User' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.tbl_UserTableAdapter.Fill(this.tourTracerDataSet.tbl_User);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Kullanıcıya onay al
            DialogResult result = MessageBox.Show("Hesabınızı silmek istediğinizden emin misiniz?", "Hesap Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hesabı silme işlemini gerçekleştir
                if (DeleteUserAccount())
                {
                    // Hesap silme başarılıysa, giriş ekranına yönlendir
                    frm_MusteriGirişSayfasi loginForm = new frm_MusteriGirişSayfasi();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hesap silme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool DeleteUserAccount()
        {
            try
            {
                //bağlantı
                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");
                conn.Open();

                // Hesabı silme işlemini gerçekleştir (örneğin, veritabanından kullanıcıyı kaldırma)

                // Örnek SQL sorgusu:
                string query = "DELETE FROM tbl_Users WHERE ID = @UserID";

                // SqlCommand ve parametreleri kullanarak sorguyu çalıştır

                // Örneğin:
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", user.ID); // loggedInUserID, silinecek kullanıcının ID'si
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                // Hesap başarıyla silindi ise true döndür
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesap silme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
