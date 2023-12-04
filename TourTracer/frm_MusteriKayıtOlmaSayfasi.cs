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
    public partial class frm_MusteriKayıtOlmaSayfasi : Form
    {
        public frm_MusteriKayıtOlmaSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_MusteriIsim.Text = "";
            txt_MusteriSoyisim.Text = "";
            txt_MusteriMail.Text = "";
            txt_MusteriSifre.Text = "";
            txt_MusteriSifreTekrar.Text = "";
            dateTime_DogumTarihi.Text = "";
        }

        private void dateTime_DogumTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_MusteriTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_MusteriIsim.PasswordChar = '\0';
                txt_MusteriSifre.PasswordChar = '\0';
                txt_MusteriSifreTekrar.PasswordChar = '\0';

            }
            else
            {

                txt_MusteriSifre.PasswordChar = '•';
                txt_MusteriSifreTekrar.PasswordChar = '•';

            }
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BAŞARILI BİR ŞEKİLDE KAYIT EDİLDİNİZ", "Devam Edebilirsiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }

        private void frm_MusteriKayıtOlmaSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
