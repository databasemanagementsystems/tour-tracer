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
    }
}
