﻿using System;
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
    public partial class frm_BaslangicEkrani : Form
    {
        public frm_BaslangicEkrani()
        {
            InitializeComponent();
        }

        private void btn_AdminGiris_Click(object sender, EventArgs e)
        {
            new frm_AdminGirisSayfasi().Show();
            this.Hide();
        }

        private void frm_Giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_MusteriGiris_Click(object sender, EventArgs e)
        {
            new frm_MusteriGirişSayfasi().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frm_PersonalLoginPage().Show();
            this.Hide();
        }

 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //new frm_AdminImportExport().Show();
        }

    }
}
