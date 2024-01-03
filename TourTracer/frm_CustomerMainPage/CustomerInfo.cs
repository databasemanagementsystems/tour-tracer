using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class CustomerInfo : Form
    {
        User user;
        public CustomerInfo(User user)
        {
            this.user = user;
            InitializeComponent();
            VerileriGetir();
        }

        private void CustomerInfo_Paint(object sender, PaintEventArgs e)
        {
            // Eğer bir User nesnesi mevcut ise
            if (user != null)
            {
                // User nesnesinin FirstName özelliğini label4'ün Text özelliğine ata
                firstname.Text = user.FirstName;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                firstname.Text = "Kullanıcı bilgileri alınamadı.";
            }

            // Eğer bir User nesnesi mevcut ise
            if (user != null)
            {
                // User nesnesinin LastName özelliğini label5'ün Text özelliğine ata
                lastname.Text = user.LastName;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                lastname.Text = "Kullanıcı bilgileri alınamadı.";
            }

            // Eğer bir User nesnesi mevcut ise
            if (user != null)
            {
                // User nesnesinin Email özelliğini label1'ün Text özelliğine ata
                mail.Text = user.Email;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                mail.Text = "Kullanıcı bilgileri alınamadı.";
            }
            if (user != null)
            {
                // User nesnesinin PhoneNumber özelliğini label2'ün Text özelliğine ata
                telefon.Text = user.PhoneNumber;
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                telefon.Text = "Kullanıcı bilgileri alınamadı.";
            }
            if (user != null)
            {
                // User nesnesinin PhoneNumber özelliğini labe3'ün Text özelliğine ata
                birthdate.Text = user.BirthDate.ToShortDateString();
            }
            else
            {
                // Eğer User nesnesi null ise, bir hata durumu gibi işlem yapabilirsiniz
                birthdate.Text = "Kullanıcı bilgileri alınamadı.";
            }


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

        private void Silme_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızı silmek istediğinizden emin misiniz?", "Hesap Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hesabı silme işlemini gerçekleştir
                if (DeleteUserAccount())
                {
                    // Hesap silme başarılıysa, giriş ekranına yönlendir
                    new frm_BaslangicEkrani().Show();
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
                MessageBox.Show("Lütfen Önce Tur Rezervasyonlarınızı Siliniz " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
}
