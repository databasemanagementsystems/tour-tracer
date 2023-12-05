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
    public partial class frm_AdminOptions : Form
    {
        public frm_AdminOptions()
        {
            InitializeComponent();
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_AdminGirisSayfasi().Show();
            this.Hide();
        }

        private void btn_ListUsers_Click(object sender, EventArgs e)
        {
            new frm_AdminEditCustomersPage().Show();
            this.Hide();
        }

        private void btn_ViewTours_Click(object sender, EventArgs e)
        {
            new frm_AdminControlsToursPage().Show();
            this.Hide();
        }

        private void frm_AdminAnaEkranSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
