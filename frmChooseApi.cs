using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmChooseApi : Form
    {
        public frmChooseApi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if(ddlapi.Text=="")
            {
                MessageBox.Show("Please choose Api");
                return;
            }

            TaxService sr = new TaxService(ddlapi.Text);


            
            frmhome frm = new frmhome();
            frm.ShowDialog();
           
        }

        private void frmChooseApi_Load(object sender, EventArgs e)
        {

        }
    }
}
