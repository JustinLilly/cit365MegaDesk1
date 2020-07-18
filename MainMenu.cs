using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___Lilly
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuoteBtn_Click(object sender, EventArgs e)
        {
            var AddQuote = new AddQuote(this);
            AddQuote.Show();
            this.Hide();
        }

        private void viewQuoteBtn_Click(object sender, EventArgs e)
        {
            var ViewQuote = new ViewAllQuotes(this);
            ViewQuote.Show();
            this.Hide();
        }

        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes(this);
            searchQuotes.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
