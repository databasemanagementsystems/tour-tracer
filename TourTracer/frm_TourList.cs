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
    public partial class frm_TourList : Form
    {
        public frm_TourList()
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

        private void frm_TourList_Load(object sender, EventArgs e)
        {

        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_CustomerMainPage().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frm_AdminAnaEkranSayfasi().Show();
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
            AddControls(new frm_CreateNewTour());
        }

        private void CenterPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_ExpiredTours());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_EditSelectedTours());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FORM SAYFASINA YÖNLENDİRME İŞLEMİ
            AddControls(new frm_DeletedTours());
        }
    }
}
