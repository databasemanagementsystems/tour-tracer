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
    public partial class frm_AdminDashboardPage : Form
    {
        public frm_AdminDashboardPage()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            adminPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            adminPanel.Controls.Add(f);
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_AdminDashboardPage_Load(object sender, EventArgs e)
        {
            AddControls(new frm_AdminAddNewUser());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminAddNewUser());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminEditUsers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminEditTours());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminShowsDeletedToursAndCustomers());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AddControls(new frm_AdminImportExport());
        }
    }
}
