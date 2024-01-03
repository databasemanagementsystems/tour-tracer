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
    public partial class frm_AdminGirisSayfasi : Form
    {
        // Veritabanı bağlantısı
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");

        public frm_AdminGirisSayfasi()
        {
            InitializeComponent();
        }
       

        // Temizle butonu tıklandığında
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            // Giriş bilgilerini temizle
            txt_AdminMail.Text = "";
            txt_AdminPassword.Text = "";
        }

        // Giriş Yap butonu tıklandığında
        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini kontrol et
            if (CheckLogin(txt_AdminMail.Text, txt_AdminPassword.Text))
            {
                // Giriş başarılıysa yönetici ana sayfasını göster
                new frm_AdminDashboardPage().Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Giriş başarısızsa hata mesajı göster
                MessageBox.Show("Tekrar Deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Şifreyi Göster checkbox'u değiştiğinde
        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SifreyiGoster.Checked)
            {
                // Şifreyi göster
                txt_AdminMail.PasswordChar = '\0';
                txt_AdminPassword.PasswordChar = '\0';
            }
            else
            {
                // Şifreyi gizle
                txt_AdminPassword.PasswordChar = '•';
            }
        }

        // Kullanıcı girişini kontrol eden fonksiyon
        private bool CheckLogin(string email, string password)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Users WHERE Email=@Email AND Password=@Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Kullanıcı varsa, rolü kontrol et
                            reader.Read();
                            string role = reader["Role"].ToString();

                            // Kullanıcının rolü "Admin" ise giriş yapabilir
                            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                return true;
                            }
                            else
                            {
                                // Diğer roller için hata mesajı göster
                                MessageBox.Show("Giriş izni yok. Sadece Admin giriş yapabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            // Kullanıcı yoksa false döndür
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajı göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                conn.Close();
            }
        }
        //Geri Dön Butonuna Basıldığında
        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            //Başlangıç ekranına yönlendirme
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_AdminDashboardPage().Show();
            this.Hide();
        }
    }
}
