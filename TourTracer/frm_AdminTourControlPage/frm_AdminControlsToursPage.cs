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
    public partial class frm_AdminControlsToursPage : Form
    {
        public frm_AdminControlsToursPage()
        {
            InitializeComponent();
        }
        //ADMİN SAYFASININ İÇİNDE YENİ BİR FORM AÇMAK İÇİN KULLANDIĞIMIZ KOD
        public void AddControls(Form f) { 
        CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
                }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_AdminControlsToursPaget_Load(object sender, EventArgs e)
        {
            AddControls(new frm_AdminCreateNewTours());
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_CustomerMainPage().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frm_AdminOptions().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_AdminCreateNewTours());
        }

        private void CenterPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_AdminShowsExpiredTours());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_AdminEditTours());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_AdminShowsDeletedTours());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminEditCustomersTours());
        }
    }
}
