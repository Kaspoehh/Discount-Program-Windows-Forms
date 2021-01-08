using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

///README
/// <summary>
/// Step1: Install Newtonsoft json package 
/// Step2: Get you're api key at: https://www.exchangerate-api.com/
/// Example code C#: https://www.exchangerate-api.com/docs/c-sharp-currency-api
/// </summary>
///README

namespace WindowsForms
{
    public partial class Form1 : Form
    {
            
        private readonly string standardFrom = "EUR";
        private readonly string standardTo = "USD";
               
		private readonly string apiKey = "4c6472e788470054d03d83ac";

		//List with all the valuta types
		readonly List<string> valutas = new List<string>();        
        
        API_Obj apiObj = new API_Obj();

        private bool fromValutaChanged;
        private bool updatedValutas;

        //Init
        public Form1()
        {

            InitializeComponent();

            UpdateValutaValues(standardFrom);

            if(updatedValutas)
                GetValutas();

            //Add valuta list to both boxes of valuta's that are vissible
            for (int i = 0; i < valutas.Count; i++)
            {
                FromValutaBox.Items.Add(valutas[i]);
                ToValutaBox.Items.Add(valutas[i]);
            }
        }

        /// <summary>
        /// Get all the valuta types and store them in a list
        /// </summary>        
        private void GetValutas()
        {
			foreach (var prop in apiObj.conversion_rates.GetType().GetProperties())
			{
				valutas.Add(prop.Name);
			}
		}

        /// <summary>
        /// Synchornize valuta values with api request
        /// </summary>
        /// <param name="from"></param>
        private void UpdateValutaValues(string from)
        {
            updatedValutas = false;
            Error.Enabled = false;
            string URLString = "https://v6.exchangerate-api.com/v6/" + apiKey + "/latest/" + from;

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(URLString);
                apiObj = JsonConvert.DeserializeObject<API_Obj>(json);
            }
            ///if not succesfull
            if(apiObj.result == "error")
			{
                Console.WriteLine("Error updating Valuta's " + this.Name);
                Error.Text = "Error updating Valuta's ";
                Error.Visible = true;
                return;
			}
            
            fromValutaChanged = false;
            updatedValutas = true;

            Console.WriteLine("Updated valuta's");
        } 

        /// <summary>
        /// When button clicked calculate 
        /// </summary>c
        private void button1_Click_1(object sender, EventArgs e)
		{
                if (fromValutaChanged)
                {
                    string selected = FromValutaBox.SelectedItem.ToString();
                    UpdateValutaValues(selected);
                }
                if (updatedValutas)
                {
                    double temp;
                    string toValuta;
                    string fromValuta;
                    float amount;

                    if (ToValutaBox.SelectedItem != null)
                    {
                        toValuta = ToValutaBox.SelectedItem.ToString();
                    }
                    else
                    {
                        toValuta = standardTo;
                    }

                    if (FromValutaBox.SelectedItem != null)
                    {
                        fromValuta = FromValutaBox.SelectedItem.ToString();
                    }
                    else
                    {
                        fromValuta = standardFrom;
                    }

                    temp = (double)typeof(ConversionRate).GetProperty(toValuta).GetValue(apiObj.conversion_rates);                  

                    if(float.TryParse(Amount.Text, out amount))
					{
                       Total.Text = amount + " " + fromValuta + " = " + (temp * amount) + " " + toValuta;
                    }
                    else
					{
                        Total.Text = "1 " + fromValuta + " = " + temp + " " + toValuta;                       
                    }
                }
            }
        

        /// <summary>
        /// if from box changed update valuta's next time when calculate button is pressed
        /// </summary>
		private void FromValutaBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            fromValutaChanged = true;        
		}

		
	}

	/// <summary>
	/// Contains all data about valuta
	/// </summary>
	public class API_Obj
    {
        public string result { get; set; }
        public ConversionRate conversion_rates { get; set; }
    }

    /// <summary>
    /// All currently available valluta's
    /// </summary>
    public class ConversionRate
    {
        public double AED { get; set; }
        public double ARS { get; set; }
        public double AUD { get; set; }
        public double BGN { get; set; }
        public double BRL { get; set; }
        public double BSD { get; set; }
        public double CAD { get; set; }
        public double CHF { get; set; }
        public double CLP { get; set; }
        public double CNY { get; set; }
        public double COP { get; set; }
        public double CZK { get; set; }
        public double DKK { get; set; }
        public double DOP { get; set; }
        public double EGP { get; set; }
        public double EUR { get; set; }
        public double FJD { get; set; }
        public double GBP { get; set; }
        public double GTQ { get; set; }
        public double HKD { get; set; }
        public double HRK { get; set; }
        public double HUF { get; set; }
        public double IDR { get; set; }
        public double ILS { get; set; }
        public double INR { get; set; }
        public double ISK { get; set; }
        public double JPY { get; set; }
        public double KRW { get; set; }
        public double KZT { get; set; }
        public double MXN { get; set; }
        public double MYR { get; set; }
        public double NOK { get; set; }
        public double NZD { get; set; }
        public double PAB { get; set; }
        public double PEN { get; set; }
        public double PHP { get; set; }
        public double PKR { get; set; }
        public double PLN { get; set; }
        public double PYG { get; set; }
        public double RON { get; set; }
        public double RUB { get; set; }
        public double SAR { get; set; }
        public double SEK { get; set; }
        public double SGD { get; set; }
        public double THB { get; set; }
        public double TRY { get; set; }
        public double TWD { get; set; }
        public double UAH { get; set; }
        public double USD { get; set; }
        public double UYU { get; set; }
        public double ZAR { get; set; }
    }

}
