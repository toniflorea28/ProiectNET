using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Proiect
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        private List<Product> products;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:8000/products");
            System.Diagnostics.Debug.WriteLine(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                products = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result.Trim());
                foreach (var product in products)
                {
                    listBox1.Items.Add(product.toString());
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            /*
            HttpResponseMessage response = await client.GetAsync(
                $"api/products/{productId}", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
            */
        }

        private async void buyButton_Click(object sender, EventArgs e)
        {
            /*
            HttpResponseMessage response = await client.GetAsync(
                $"api/products/{productId}", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
            */
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int nameEndPosition = listBox1.SelectedItem.ToString().IndexOf("|");
            string productId = listBox1.SelectedItem.ToString().Substring(0, nameEndPosition).Trim();

            HttpResponseMessage response = await client.GetAsync($"http://127.0.0.1:8000/products/delete/{productId}");

            if (response.IsSuccessStatusCode)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Refresh();
            }
        }

        private async void button3_ClickAsync(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "AllProducts.txt")))
            {
                foreach (var product in products)
                    outputFile.WriteLine(product.toString());
            }

            textBox2.Text = "Fisierul a fost generat la adresa: " + docPath;
        }
    }
}
