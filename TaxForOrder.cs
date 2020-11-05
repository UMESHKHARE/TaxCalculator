using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class TaxForOrder : Form
    {
        public static string apiname = "";
        string GetResponseApi = "";
        TaxService service = new TaxService(apiname);
        public TaxForOrder()
        {
            InitializeComponent();





        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (CheckInputs() != "Ok")
            { return; }
            GetResponseApi = service.CalculateSalesTaxForOrder(GetOrderInput());

            if (!GetResponseApi.Contains("Error"))
            {
                ShowResult(GetResponseApi);

            }
            else
            {
                label13.Text = "Sorry Problem Connecion to api";

            }

            clearinputs();
        }



        public ArrayList GetOrderInput()
        {

            ArrayList getinput = new ArrayList();

            try
            {



                getinput.Add(txtfromcountry.Text);
                getinput.Add(txtfromzip.Text);
                getinput.Add(txtfromstate.Text);
                getinput.Add(txtfromcity.Text);
                

                getinput.Add(txttocountry.Text);
                getinput.Add(txttozip.Text);
                getinput.Add(txttostate.Text);
                getinput.Add(txttocity.Text);
                getinput.Add(txtamount.Text);
                getinput.Add(txtshippingamount.Text);

            }
            catch (Exception ex)
            {

            }

            return getinput;

        }


        public void ShowResult(string GetResponseApi)
        {


            //JObject parsed = JObject.Parse(GetResponseApi);
            label4.Text = "Output";

            label5.Text = "Amount TO Collect: " + GetResponseApi;
           


        }
        //clear the inputs fields
        public void clearinputs()
        {



            txtshippingamount.Text = "";
            txttocountry.Text = "";
            txttostate.Text = "";
            txttozip.Text = "";
            txtamount.Text = "";
            txtfromcity.Text = "";
            txtfromzip.Text = "";
            txtfromstate.Text = "";
            txtfromcountry.Text = "";
           

        }

        //check input fields for validation
      public string CheckInputs()
        {

            if (txttocountry.Text == "")
            {
                label13.Text = "Please enter to Country";
                return label13.Text;
            }
            else if (txttostate.Text == "")
            {
                label13.Text = "Please enter to state";
                return label13.Text;
            }
            else if (txttozip.Text == "")
            {
                label13.Text = "Please enter to zip";
                return label13.Text;

            }
            else if (txtshippingamount.Text == "")
            {
                label13.Text = "Please enter shipping amount";
                return label13.Text;
            }
            else if (txtamount.Text == "")
            {
                label13.Text = "Please enter order amount";
                return label13.Text;
            }
            else 
            {
                try
                {
                    Convert.ToDecimal(txtshippingamount.Text);
                }
                catch (Exception ex)
                {
                    label13.Text = "Please enter shipping amount in decimal";
                    return label13.Text;
                }


                try
                {
                    Convert.ToDecimal(txtamount.Text);
                }
                catch (Exception ex)
                {
                    label13.Text = "Please enter order amount in decimal";
                    return label13.Text;
                }
                return "Ok";
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            label4.Text = "";
            label5.Text = "";
            clearinputs();
        }

        private void TaxForOrder_Load(object sender, EventArgs e)
        {
            txtfromcountry.Focus();
        }
    }
}
