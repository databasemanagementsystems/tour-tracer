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

        private void frm_AdminShowsDeletedToursAndCustomers_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'tourTracerDataSet11.tbl_DeletedTours' table. You can move, or remove it, as needed.
            this.tbl_DeletedToursTableAdapter2.Fill(this.tourTracerDataSet11.tbl_DeletedTours);
            // TODO: This line of code loads data into the 'tourTracerDataSet10.tbl_DeletedUsers' table. You can move, or remove it, as needed.
            this.tbl_DeletedUsersTableAdapter2.Fill(this.tourTracerDataSet10.tbl_DeletedUsers);


        }
    }
}
