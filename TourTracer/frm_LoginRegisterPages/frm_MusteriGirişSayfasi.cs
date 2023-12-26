using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_MusteriGirişSayfasi : Form
    {
       SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");

        public frm_MusteriGirişSayfasi()
        {
            InitializeComponent();
        }

        private void frm_MusteriGiriş_Load(object sender, EventArgs e)
        {
            // (Opsiyonel: Form yüklendiğinde yapılacak işlemler)
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            // Başlangıç ekranına geri dön
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Müşteri kayıt sayfasını aç
            new frm_MusteriKayıtOlmaSayfasi().Show();
            this.Hide();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            // Girilen var olan metni silerek boş kutucukları göster
            txt_CustomerMail.Text = "";
            txt_CustomerPassword.Text = "";
        }

        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            // "Şifreyi Göster" checkbox'u işaretliyse şifre kutusunun karakter gösterimini kapat
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_CustomerMail.PasswordChar = '\0';
                txt_CustomerPassword.PasswordChar = '\0';
            }
            else // Checkbox işaretli değilse karakter gösterimini aktif hale getir
            {
                txt_CustomerPassword.PasswordChar = '•';
            }
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            //Kullanıcı giriş bilgilerini kontrol et
            if (CheckLogin(txt_CustomerMail.Text, txt_CustomerPassword.Text))
            {
               // Giriş başarılıysa müşteri ana sayfasını aç
                new frm_CustomerMainPage().Show();
                this.Hide();
            }
            else
            {
                // Giriş başarısızsa hata mesajı göster
                MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_MusteriMail_TextChanged(object sender, EventArgs e)
        {
            // (Opsiyonel: E-posta text kutusunda metin değiştiğinde yapılacak işlemler)
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool CheckLogin(string email, string password)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tbl_User WHERE Email=@Email AND Password=@Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Eğer kullanıcı varsa true döndür, yoksa false
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
