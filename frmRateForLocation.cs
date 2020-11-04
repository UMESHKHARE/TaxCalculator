using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRateForLocation : Form
    {

        public static string apiname = "";
        string GetResponseApi = "";
        TaxService service = new TaxService(apiname);
        public frmRateForLocation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            CheckInputs();
            GetResponseApi = service.GetTaxRateForLocation(GetOrderInput());

            if (!GetResponseApi.Contains("Error"))
            {
                ShowResult(GetResponseApi);

            }
            else
            {
                //label13.Text = "Sorry Problem Connecion to api";

            }

            clearinputs();
        }



        public ArrayList GetOrderInput()
        {

            ArrayList getinput = new ArrayList();

            try
            {



                getinput.Add(txtzipcode.Text);
                if(txtcity.Text!="")
                { getinput.Add(txtcity.Text); }
                if(txtcountry.Text!="")
                getinput.Add(txtcountry.Text);
               

            }
            catch (Exception ex)
            {

            }

            return getinput;

        }


        public void ShowResult(string GetResponseApi)
        {


            rtoutput.Text = GetResponseApi;



        }
        //clear the inputs fields
        public void clearinputs()
        {



            txtcountry.Text = "";
            txtcity.Text = "";
            txtcountry.Text = "";

        }

        //check input fields for validation
        public void CheckInputs()
        {

            if (txtzipcode.Text == "")
            {
                //label13.Text = "Please enter to zipcode";

            }
            
        
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            clearinputs();
        }

        private void frmRateForLocation_Load(object sender, EventArgs e)
        {
            txtzipcode.Focus();
        }
    }
}
