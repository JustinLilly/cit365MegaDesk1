using System;
using System.Windows.Forms;

namespace MegaDesk___Lilly
{
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;
        public DisplayQuote(Form mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            _mainMenu = mainMenu;

            deskQuoteCustomer.Text = deskQuote.Name;
            deskQuoteWidth.Text = deskQuote.Desk.Width.ToString();
            deskQuoteDepth.Text = deskQuote.Desk.Depth.ToString();
            deskQuoteDrawers.Text = deskQuote.Desk.NumDrawers.ToString();
            deskQuoteMaterial.Text = deskQuote.Desk.Material.ToString();
            deskQuoteDelivery.Text = deskQuote.DeliveryType.ToString();
            priceQuoteTxt.Text = deskQuote.QuotePrice.ToString("C");
        }

        private void rushLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
            _mainMenu.Show();
        }
    }
}
