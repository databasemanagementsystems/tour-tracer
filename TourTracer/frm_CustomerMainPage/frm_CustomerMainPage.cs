using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace TourTracer
{
    public partial class frm_CustomerMainPage : Form
    {
        public frm_CustomerMainPage()
        {
            InitializeComponent();
        }
        
        

        // Form içinde başka form açmak için kullandığımız fonksiyon
        public void AddControls(Form f)
        {
            CustomerPanel1.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CustomerPanel1.Controls.Add(f);
            f.Show();
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }

        private void btn_ListUsers_Click(object sender, EventArgs e)
        {
            // Buraya uygun işlemleri ekleyin
        }

        private void frm_CustomerMainPage_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde "frm_CustomerProfilePage" formunu aç
            AddControls(new frm_CustomerProfilePage());
        }

        private void btn_ViewTours_Click(object sender, EventArgs e)
        {
            // Buraya uygun işlemleri ekleyin
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Buraya uygun işlemleri ekleyin
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddControls(new frm_CustomerSelectTourPage());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddControls(new frm_CustomerEditTourPage());
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            AddControls(new frm_CustomerProfilePage());
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            // Buraya uygun işlemleri ekleyin
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
