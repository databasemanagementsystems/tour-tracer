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
    public partial class frm_MusteriGirişSayfasi : Form
    {
        public frm_MusteriGirişSayfasi()
        {
            InitializeComponent();
        }

        private void frm_MusteriGiriş_Load(object sender, EventArgs e)
        {

        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new frm_MusteriKayıtOlmaSayfasi().Show();
            this.Hide();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            //Girilen Var olan metni silerek boş kutucuk ekrana gösterir.
            txt_MusteriMail.Text = "";
            txt_MusteriSifre.Text = "";
        }

        private void checkbox_SifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_SifreyiGoster.Checked)
            {
                txt_MusteriMail.PasswordChar = '\0';
                txt_MusteriSifre.PasswordChar = '\0';

            }
            else
            {
               
               txt_MusteriSifre.PasswordChar = '•';

            }
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            new frm_MusteriAnaEkranSayfasi().Show();
            this.Hide();
        }
    }
    }

