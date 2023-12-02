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
    public partial class frm_MusteriGirişSayfasi : Form
    {
        public frm_MusteriGirişSayfasi()
        {
            InitializeComponent();
        }

        private void frm_MusteriGiriş_Load(object sender, EventArgs e)
        {

        }

        private void btn_GeriDön_Click(object sender, EventArgs e)
        {
            new frm_BaslangicEkranş().Show();
            this.Hide();
        }
    }
}
