using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk___Lilly
{
    public partial class SearchQuotes : Form
    {
        private Form _MainMenu;
        public SearchQuotes(Form MainMenu)
        {
            InitializeComponent();
            materialListDrop.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            _MainMenu = MainMenu;
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            _MainMenu.Show();
            Close();
        }

        private void materialListDrop_Select(object sender, EventArgs e)
        {
            try
            {
                var orderFile = @"quotes.json";
                string materialSelected = materialListDrop.SelectedItem.ToString();
                using (StreamReader reader = new StreamReader(orderFile))
                {
                    string newQuotes = reader.ReadToEnd();
                    List<DeskQuote> deskOrders = JsonConvert.DeserializeObject<List<DeskQuote>>(newQuotes);
                    List<DeskQuote> showOrders = new List<DeskQuote>();

                    foreach (DeskQuote selectedQuote in deskOrders)
                    {
                        if (selectedQuote.Desk.Material.ToString() == materialSelected)
                        {
                            showOrders.Add(selectedQuote);
                        }
                    }
                    searchQuotesGrid.DataSource = deskOrders.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.Name,
                        Width = d.Desk.Width,
                        Depth = d.Desk.Depth,
                        Drawers = d.Desk.NumDrawers,
                        Material = d.Desk.Material,
                        Delivery = d.DeliveryType,
                        Total = d.GetQuotePrice().ToString("c")
                    }).Where(q => q.Material == (DesktopMaterial)materialListDrop.SelectedItem).ToList();
                }
            }

            catch (Exception)
            {

                throw;
            }
        }
    }
}
