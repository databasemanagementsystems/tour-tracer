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
    public partial class frm_AdminEditTours : Form
    {
        public frm_AdminEditTours()
        {
            InitializeComponent();
        }

        private void frm_EditSelectedTours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourTracerDataSet9.tbl_Tours' table. You can move, or remove it, as needed.
            this.tbl_ToursTableAdapter.Fill(this.tourTracerDataSet9.tbl_Tours);
            // TODO: Bu kod satırı 'tourTracerDataSet6.tbl_Cities' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_CitiesTableAdapter.Fill(this.tourTracerDataSet6.tbl_Cities);

        }
    }
}
