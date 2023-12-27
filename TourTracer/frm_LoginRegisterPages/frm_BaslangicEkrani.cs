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
    public partial class frm_BaslangicEkrani : Form
    {
        public frm_BaslangicEkrani()
        {
            InitializeComponent();
        }
        //Admin Giriş Butonuna Tıklanıldığında
        private void btn_AdminGiris_Click(object sender, EventArgs e)
        {
            //Admin Giriş sayfasına yönlendir
            new frm_AdminGirisSayfasi().Show();
            this.Hide();
        }
        //Müşteri Giriş Butonuna Tıklanıldığında
        private void btn_MusteriGiris_Click(object sender, EventArgs e)
        {
            //Müşteri Giriş sayfasına yönlendir
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }
        //Çıkış yap butonuna basıldığında
        private void button1_Click(object sender, EventArgs e)
        {
            //İlgili Formu kapat
            this.Close();
            
        }

      
        //Personel Giriş butonuna basıldığında
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Personel sayfasına yönlendir
            new frm_PersonalLoginPage().Show();
            this.Hide();
        }


       
    }
}
