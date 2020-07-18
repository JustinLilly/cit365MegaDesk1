using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.ComponentModel;

namespace MegaDesk___Lilly
{
    public partial class AddQuote : Form
    {
        private Form _MainMenu;
        public AddQuote(Form MainMenu)
        {
            InitializeComponent();
            deskMatBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));

            rushBox.ValueMember = "Value";
            rushBox.DisplayMember = "Description";
            rushBox.DataSource = Enum.GetValues(typeof(Delivery))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            _MainMenu = MainMenu;
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            var desk = new Desk
            {
                Depth = depthBox.Value,
                Width = widthBox.Value,
                NumDrawers = (int)numDrawBox.Value,
                Material = (DesktopMaterial)deskMatBox.SelectedValue
            };

            var deskQuote = new DeskQuote
            {
                Desk = desk,
                Name = nameBox.Text,
                QuoteDate = DateTime.Now,
                DeliveryType = (Delivery)rushBox.SelectedValue
            };
            try
            {
                var price = deskQuote.GetQuotePrice();

                deskQuote.QuotePrice = price;

                List<DeskQuote> deskQuotes = new List<DeskQuote>();

                if (!File.Exists(@"quotes.json"))
                {
                    deskQuotes.Add(deskQuote);
                    var list = JsonConvert.SerializeObject(deskQuotes);
                    File.WriteAllText(@"quotes.json", JsonConvert.SerializeObject(deskQuotes));
                }
                else
                {
                    using (StreamReader reader = new StreamReader(@"quotes.json"))
                    {
                        string allQuotes = reader.ReadToEnd();
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                    }
                    deskQuotes.Add(deskQuote);
                    var list = JsonConvert.SerializeObject(deskQuotes);
                    File.WriteAllText(@"quotes.json", list);
                }

                DisplayQuote displayQuoteForm = new DisplayQuote(_MainMenu, deskQuote);
                displayQuoteForm.Show();
                Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void addQuoteCancelBtn_Click(object sender, EventArgs e)
        {
            _MainMenu.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            quoteDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void widthBox_ValueChanged(object sender, EventArgs e)
        {
            if (double.TryParse(widthBox.Text, out double value))
            {
                if (value < 24 || value > 96)
                {
                    widthBox.ForeColor = Color.Red;
                    WidthWarning.Text = "Enter between 24 inches and 96 inches";
                    WidthWarning.ForeColor = Color.Red;
                }
                else
                {
                    widthBox.ForeColor = Color.Green;
                    WidthWarning.Text = "";
                }      
            }
            else
            {
                widthBox.ForeColor = Color.Red;
                WidthWarning.Text = "Enter between 24 inches and 96 inches";
                WidthWarning.ForeColor = Color.Red;
            }
        }

        private void depthBox_ValueChanged(object sender, EventArgs e)
        {
            if (double.TryParse(depthBox.Text, out double value))
            {
                if (value < 12 || value > 48)
                {
                    depthBox.ForeColor = Color.Red;

                    DepthWarning.Text = "Enter between 12 inches and 48 inches";
                    DepthWarning.ForeColor = Color.Red;
                }
                else
                {
                    depthBox.ForeColor = Color.Green;
                    DepthWarning.Text = "";
                }
            }
            else
            {
                depthBox.ForeColor = Color.Red;

                DepthWarning.Text = "Enter between 12 inches and 48 inches";
                DepthWarning.ForeColor = Color.Red;
            }
        }

        private void numDrawBox_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void depthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar) != '.')
            {
                e.Handled = true;
            }
        }
    }
}
