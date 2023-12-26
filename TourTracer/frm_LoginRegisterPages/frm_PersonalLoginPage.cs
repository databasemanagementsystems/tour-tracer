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
    public partial class frm_PersonalLoginPage : Form
    {
        public frm_PersonalLoginPage()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");


        private void frm_PersonalPage_Load(object sender, EventArgs e)
        {

        }

        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_PersoMail.PasswordChar = '\0';
                txt_PersoPassword.PasswordChar = '\0';

            }
            else
            {

                txt_PersoPassword.PasswordChar = '•';

            }
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini kontrol et
            if (CheckLogin(txt_PersoMail.Text, txt_PersoPassword.Text))
            {
                // Giriş başarılıysa müşteri ana sayfasını aç
                new frm_PersonalControlPage().Show();
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
                        if (reader.HasRows)
                        {
                            // Kullanıcı varsa, rolü kontrol et
                            reader.Read();
                            string role = reader["Role"].ToString();

                            // Kullanıcının rolü "Staff" ise giriş yapabilir
                            if (role.Equals("Staff", StringComparison.OrdinalIgnoreCase))
                            {
                                return true;
                            }
                            else
                            {
                                // Diğer roller için hata mesajı göster
                                MessageBox.Show("Giriş izni yok. Sadece Personal giriş yapabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
            private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_PersoMail.Text = "";
            txt_PersoPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }
    }
}
