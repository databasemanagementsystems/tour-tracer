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
    public partial class frm_PersonalControlPage : Form
    {
        public frm_PersonalControlPage()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
       

        private void button2_Click(object sender, EventArgs e)
        {
           
            AddControls(new frm_AdminEditTours());
        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_PersonalLoginPage().Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkrani().Show();
            this.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new frm_AdminEditUsers());
           
            
        }

        private void frm_PersonalControlPage_Load(object sender, EventArgs e)
        {
            AddControls(new frm_AdminEditUsers());
        }
    }
}
