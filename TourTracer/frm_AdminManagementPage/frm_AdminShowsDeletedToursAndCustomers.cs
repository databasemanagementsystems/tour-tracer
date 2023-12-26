using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTracer
{
    public partial class frm_AdminShowsDeletedToursAndCustomers : Form
    {
        public frm_AdminShowsDeletedToursAndCustomers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True");

        private void frm_AdminShowsDeletedToursAndCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourTracerDataSet5.tbl_DeletedUsers' table. You can move, or remove it, as needed.
            this.tbl_DeletedUsersTableAdapter1.Fill(this.tourTracerDataSet5.tbl_DeletedUsers);
            // TODO: This line of code loads data into the 'tourTracerDataSet4.tbl_DeletedTours' table. You can move, or remove it, as needed.
            this.tbl_DeletedToursTableAdapter1.Fill(this.tourTracerDataSet4.tbl_DeletedTours);

        }
    }
}
