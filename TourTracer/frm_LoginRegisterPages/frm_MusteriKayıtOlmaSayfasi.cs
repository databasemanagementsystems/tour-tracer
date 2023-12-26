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
    public partial class frm_MusteriKayıtOlmaSayfasi : Form
    {
        // Veritabanı bağlantısı için SqlConnection nesnesi
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");

        // SqlCommand ve SqlDataAdapter nesneleri
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        // Formun constructor metodu
        public frm_MusteriKayıtOlmaSayfasi()
        {
            InitializeComponent();
        }

        // "Giriş Sayfasına Dön" butonu tıklandığında
        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni giriş sayfasını aç ve bu sayfayı gizle
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }

        // "Temizle" butonu tıklandığında
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Text kutularını ve DateTimePicker'ı temizle
            txt_CustomerName.Text = "";
            txt_CustomerLastName.Text = "";
            txt_CustomerMail.Text = "";
            txt_CustomerPassword.Text = "";
            txt_CustomerPasswordAgain.Text = "";
            date_Birthdate.Value = DateTime.Now;
        }

        // DateTimePicker'ın değeri değiştiğinde
        private void dateTime_DogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            // (Opsiyonel: Bu olaya dair başka işlemler eklenebilir)
        }

        // Telefon numarası text kutusunda metin değiştiğinde
        private void txt_MusteriTel_TextChanged(object sender, EventArgs e)
        {
            // (Opsiyonel: Bu olaya dair başka işlemler eklenebilir)
        }

        // "Şifreyi Göster" checkbox'u durum değiştirdiğinde
        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            // Checkbox işaretliyse şifre kutularının karakter gösterimi kapatılır
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_CustomerName.PasswordChar = '\0';
                txt_CustomerPassword.PasswordChar = '\0';
                txt_CustomerPasswordAgain.PasswordChar = '\0';
            }
            else // Checkbox işaretli değilse karakter gösterimi aktif hale getirilir
            {
                txt_CustomerPassword.PasswordChar = '•';
                txt_CustomerPasswordAgain.PasswordChar = '•';
            }
        }

        // "Kayıt Ol" butonu tıklandığında
        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            // Herhangi bir kutu boş bırakıldıysa hata mesajı göster ve fonksiyondan çık
            if (string.IsNullOrWhiteSpace(txt_CustomerName.Text) ||
                string.IsNullOrWhiteSpace(txt_CustomerLastName.Text) ||
                string.IsNullOrWhiteSpace(txt_CustomerMail.Text) ||
                string.IsNullOrWhiteSpace(txt_CustomerPhone.Text) ||
                string.IsNullOrWhiteSpace(txt_CustomerPassword.Text) ||
                string.IsNullOrWhiteSpace(txt_CustomerPasswordAgain.Text))
            {
                MessageBox.Show("Lütfen kutucukları boş bırakmayınız!", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Şifreler birbirleriyle eşleşmiyorsa hata mesajı göster ve fonksiyondan çık
            if (txt_CustomerPassword.Text != txt_CustomerPasswordAgain.Text)
            {
                MessageBox.Show("Şifreler birbirleriyle eşleşmiyor!", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CustomerPassword.Text = "";
                txt_CustomerPasswordAgain.Text = "";
                txt_CustomerPassword.Focus();
                return;
            }

            // E-posta geçerli değilse hata mesajı göster ve fonksiyondan çık
            if (!IsValidEmail(txt_CustomerMail.Text))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Veritabanını aç
                conn.Open();

                // Insert sorgusuyla kullanıcıyı kaydet
                string register = "INSERT INTO tbl_Users (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role) " +
                                  "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password, @BirthDate, @Role)";
                using (SqlCommand cmd = new SqlCommand(register, conn))
                {
                    // Parametreleri ekleyerek SQL enjeksiyonlarına karşı koruma sağla
                    cmd.Parameters.AddWithValue("@FirstName", txt_CustomerName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txt_CustomerLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_CustomerMail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txt_CustomerPhone.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_CustomerPassword.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", date_Birthdate.Value);
                    cmd.Parameters.AddWithValue("@Role", "Customer");

                    // Sorguyu çalıştır
                    cmd.ExecuteNonQuery();
                }

                // Başarı mesajını göster
                MessageBox.Show("Hesabınız Başarıyla Oluşturuldu!", "Kayır Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata mesajını göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Veritabanını kapat
                conn.Close();
            }
        }

        // E-posta adresinin geçerli olup olmadığını kontrol eden fonksiyon
        private bool IsValidEmail(string email)
        {
            // E-posta boşsa false döndür
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // E-posta adresinde '@' ve '.' karakterlerini içerip içermediğini kontrol et
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
                return false;

            // İleride daha kapsamlı bir e-posta doğrulama mantığı ekleyebilirsiniz

            // Geçerliyse true döndür
            return true;
        }

        // Form yüklendiğinde
        private void frm_MusteriKayıtOlmaSayfasi_Load(object sender, EventArgs e){
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
