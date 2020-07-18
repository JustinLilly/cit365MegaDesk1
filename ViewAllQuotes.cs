using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk___Lilly
{
    public partial class ViewAllQuotes : Form
    {
        private Form _MainMenu;
        public ViewAllQuotes(Form MainMenu)
        {
            InitializeComponent();
            _MainMenu = MainMenu;
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            _MainMenu.Show();
            Close();
        }
        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            var file = @"quotes.json";
            using (StreamReader reader = new StreamReader(file))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                viewAllQuotesGrid.DataSource = deskOrders.Select(d => new
                {
                    Customer = d.Name,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    Drawers = d.Desk.NumDrawers,
                    SurfaceMaterial = d.Desk.Material,
                    Delivery = d.DeliveryType,
                    QuoteTotal = d.QuotePrice.ToString("C")

                }).ToList();
            }
        }
    }
}
