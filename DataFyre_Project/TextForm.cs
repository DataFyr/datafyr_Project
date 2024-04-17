using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace datascience_project
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            // URL of the website containing the gold price
            string url = "https://www.goldprice.org/";

            // Create a web client to download the website content
            using (WebClient client = new WebClient())
            {
                // Download the website content as a string
                string html = client.DownloadString(url);

                // Parse the HTML content using HtmlAgilityPack
                HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);

                // Find the element containing the gold price
                HtmlNode priceNode = doc.DocumentNode.SelectSingleNode("//span[@id='spnGoldPrice']");

                if (priceNode != null)
                {
                    // Get the inner text of the element, which should contain the gold price
                    string goldPrice = priceNode.InnerText.Trim();
                    richTextBox1.Text = goldPrice;
                }
                else
                {
                    Console.WriteLine("Gold price not found on the website.");
                }
            }
        }
    }
}
