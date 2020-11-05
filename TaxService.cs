using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Collections;
using System.Net.Http.Headers;
using Taxjar;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    


    class TaxService
    {

        public static string ApiName = "";


       
        public TaxService(string Api)
        {


            ApiName=Api;

        }

        // method to connect to taxjar or any api using url and getting response
        public string GetResponseFromApi(String url)
        {

            using (HttpClient client = new HttpClient())
            {

                try
                {

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ConfigurationManager.AppSettings["taxzarkey"]);

                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;

                        return json;
                    }
                    else
                    {
                        return "Error Code:401";

                    }

                }
                catch (Exception ex)
                {

                    return "Error Code:402";

                }

            }



        }

        //MEHOD TO GET TAX RATE OF LOCATION,WHEN USER INPUT ZIPCODE,CITY
        public String GetTaxRateForLocation(ArrayList zipcode)
        {


            try
            {

                string url = "https://api.taxjar.com/v2/rates/?zip=" + zipcode[0].ToString() + "";


                           

                return GetResponseFromApi(url);

            }
            catch (TaxjarException ex)
            {

                return "Error code:403";

            }



        }
        // method to get sales tax for order,according to user inputs
        public String CalculateSalesTaxForOrder(ArrayList OrderInput)
        {

            string amounttocollect = "";
            try
            {
                var client = new TaxjarApi(ConfigurationManager.AppSettings["taxzarkey"]);
                var tax = client.TaxForOrder(new
                {
                    from_country = OrderInput[0].ToString(),
                    from_zip = OrderInput[1].ToString(),
                    from_state = OrderInput[2].ToString(),
                    from_city = OrderInput[3].ToString(),

                    to_country = OrderInput[4].ToString(),
                    to_zip = OrderInput[5].ToString(),
                    to_state = OrderInput[6].ToString(),
                    to_city = OrderInput[7].ToString(),
                    amount = OrderInput[8].ToString(),
                    shipping = OrderInput[9].ToString()

                });

                var json = JsonConvert.SerializeObject(tax);


                JObject parsed = JObject.Parse(json);

               
                foreach (var i in parsed)
                {

                    if (i.Key.ToString() == "amount_to_collect")
                    {

                        amounttocollect = i.Value.ToString();

                    }

                }
            }
            catch(Exception ex)
            {
                amounttocollect = "0";

            }


            return amounttocollect;








        }

    }





}

