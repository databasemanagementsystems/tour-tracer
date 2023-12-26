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

        private void btn_AdminGiris_Click(object sender, EventArgs e)
        {
            new frm_AdminGirisSayfasi().Show();
            this.Hide();
        }

        private void btn_MusteriGiris_Click(object sender, EventArgs e)
        {
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frm_PersonalLoginPage().Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            new frm_AdminImportExport().Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new frm_AdminDashboardPage().Show();
        }
    }
}
