using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace TourTracer
{
    public partial class frm_AdminAddNewUser : Form
    {
        // Veritabanı bağlantısı için SqlConnection nesnesi
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");

        // Seçilen rol bilgisini tutacak değişken
        string selectedRole = "";

        public frm_AdminAddNewUser()
        {
            InitializeComponent();
        }

        

        private void SaveUser()
        {
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Lütfen bir rol seçin.");
                return;
            }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_users (FirstName, LastName, Email, PhoneNumber, Password, BirthDate, Role) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password, @BirthDate, @Role)", conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txt_NewCustomerName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txt_NewCustomerLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_NewCustomerMail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txt_NewCustomerPhone.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_NewCustomerPassword.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", date_Birthdate.Value);
                    cmd.Parameters.AddWithValue("@Role", selectedRole);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi gerçekleştirilemedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void frm_AdminAddNewUser_Load_1(object sender, EventArgs e)
        {

        }

        private void txt_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
            SaveUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRole = "Staf";
            SaveUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedRole = "Customer";
            SaveUser();
        }
    }
}