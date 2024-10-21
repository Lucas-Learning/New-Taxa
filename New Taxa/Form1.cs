using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace New_Taxa
{
    public partial class Form1 : Form
    {
        private string distancestr { get; set; }
        private double kilometer { get; set; }
        private double pris { get; set; }
        private double basePrice = 0;
        private string apiKey = "AIzaSyDAo5Cokd4acdyTCMgtY1DXBUTPToyE--I";
        public Form1()
        {
           
            InitializeComponent();
          
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            
            this.Controls.Add(webView21);
            await webView21.EnsureCoreWebView2Async(null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1}","Satellite", name_Location.Text);
            webView21.Source = new Uri(url);
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            pris = basePrice; 
            string location = name_Location.Text;
            string destination = destination_Location.Text;

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please enter both origin and destination.");
                return;
            }

            try
            {
                string url = $"https://maps.googleapis.com/maps/api/directions/json?origin={location}&destination={destination}&mode=driving&key={apiKey}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    var distance = json["routes"][0]["legs"][0]["distance"]["text"];
                    distancestr = distance.ToString();
                    label8.Text = distancestr;
                    distancestr = distancestr.Replace(",", ".");
                    double distanceValue = 0;
                    if (distancestr.EndsWith(" km"))
                    {
                        distanceValue = double.Parse(distancestr.Replace(" km", ""), CultureInfo.InvariantCulture);
                    }
                    else if (distancestr.EndsWith(" m"))
                    {
                        distanceValue = double.Parse(distancestr.Replace(" m", ""), CultureInfo.InvariantCulture) / 1000;
                    }
                    double totalCost = distanceValue * kilometer;
                    pris += totalCost;
                    label4.Text = pris.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdatePrice()
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                basePrice = 37;
                kilometer = 12.75;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                basePrice = 47;
                kilometer = 16;
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                basePrice = 77;
                kilometer = 17;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                basePrice = 87;
                kilometer = 19;
            }
            pris = basePrice;
            label4.Text = pris.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            UpdatePrice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
