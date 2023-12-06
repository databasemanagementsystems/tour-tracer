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
    public partial class frm_AdminEditCustomerPage : Form
    {
        public frm_AdminEditCustomerPage()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            panel3.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }
        private void Frm_AdminEditCustomert_Load(object sender, EventArgs e)
        {
            AddControls(new frm_AdminAddNewCustomer());
        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void frm_AdminEditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
