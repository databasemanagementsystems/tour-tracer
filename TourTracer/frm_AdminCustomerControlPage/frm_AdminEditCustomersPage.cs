using System.Windows.Forms;
using System;

namespace TourTracer
{
    public partial class frm_AdminEditCustomersPage : Form
    {
        public frm_AdminEditCustomersPage()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            panel1.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Show();
        }

        private void Frm_AdminEditCustomersPage_Load(object sender, EventArgs e)
        {
            // frm_AdminEditCustomersPage formu yüklendiğinde CustomerPanel3'e frm_AdminAddNewCustomer formunu ekleyin.
            frm_AdminAddNewCustomer addNewCustomerForm = new frm_AdminAddNewCustomer();
            addNewCustomerForm.Load += (s, args) => AddControls(addNewCustomerForm);
            addNewCustomerForm.Show();
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_AdminOptions().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Buraya uygun işlemleri ekleyin
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminAddNewCustomer());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminAddNewAdmin());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminEditCustomerInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminShowDeletedCustomers());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Buraya uygun işlemleri ekleyin
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
