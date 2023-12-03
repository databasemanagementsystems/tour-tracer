using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_AdminGirisSayfasi : Form
    {
        public frm_AdminGirisSayfasi()
        {
            InitializeComponent();
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void frm_AdminGirisSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_AdminIsim.Text = "";
            txt_AdminSifre.Text = "";
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Başarılı","HOŞGELDİNİZ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            new frm_AdminAnaEkranSayfasi().Show();
            this.Hide();
        }

        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_AdminIsim.PasswordChar = '\0';
                txt_AdminSifre.PasswordChar = '\0';

            }
            else
            {

                txt_AdminSifre.PasswordChar = '•';

            }
        }
    }
}
