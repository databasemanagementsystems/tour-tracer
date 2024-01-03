using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_MusteriGirişSayfasi : Form
    {
        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturma
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");
        User user;

        public frm_MusteriGirişSayfasi()
        {
            InitializeComponent();
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
                user = GetUserByEmailAndPassword(txt_CustomerMail.Text, txt_CustomerPassword.Text);
                new frm_CustomerMainPage(user).Show();
                this.Hide();
            }
            else
            {
                // Giriş başarısızsa hata mesajı göster
                MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private User GetUserByEmailAndPassword(string email, string password)
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
                        if (reader.Read())
                        {
                            // Eğer kullanıcı varsa, User nesnesini doldur
                            User user = new User
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Password = reader["Password"].ToString(),
                                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                Role = reader["Role"].ToString()
                            };

                            return user;
                        }
                        else
                        {
                            // Kullanıcı bulunamazsa null döndür
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_CustomerMainPage(user).Show();
            this.Hide();
        }
    }
    }
