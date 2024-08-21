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
using Newtonsoft.Json.Linq;

namespace New_Taxa
{
    public partial class Form1 : Form
    {
        private WebView2 webView;
        private string apiKey = "";
        public Form1()
        {
            InitializeComponent();
            map_type.SelectedIndex = 1;
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            webView = new WebView2
            {
                Width = 800,  
                Height = 600, 
                Left = 10,    
                Top = 50,
            };
            this.Controls.Add(webView);
            await webView.EnsureCoreWebView2Async(null);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] types = new string[] { "m", "k", "h", "p", "e" };
            string url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1}",types[map_type.SelectedIndex], name_Location.Text);
            webView.Source = new Uri(url);
        }
    

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void map_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string location = name_Location.Text;
            string destination = destination_Location.Text;
            if(string.IsNullOrEmpty(location) || string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please enter both origin and destination.");
                return;
            }
            try
            {
                string url = $"https://maps.googleapis.com/maps/api/directions/json?origin={location}&destination={destination}&key={apiKey}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);
                    var distance = json["routes"][0]["legs"][0]["distance"]["text"];
                    MessageBox.Show($"Distance: {distance}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void name_Location_TextChanged(object sender, EventArgs e)
        {

        }

        private void map_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
