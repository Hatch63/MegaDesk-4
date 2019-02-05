using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

            //var Material = new List<Desk.DesktopMaterial>();

            //FILL MATERIALS DROP DOWN
            var material = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();

            box_Materials.DataSource = material;
            box_Materials.SelectedIndex = -1;

            //FILL SHIPPING DROP DOWN
            var shipping = Enum.GetValues(typeof(DeskQuotes.ShippingOptions))
                .Cast<DeskQuotes.ShippingOptions>()
                .ToList();

            box_Shipping.DataSource = shipping;
            box_Shipping.SelectedIndex = -1;

        }

        //CANCEL BUTTON
        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenus = new MainMenu();
            mainMenus.Tag = this;
            mainMenus.Show(this);
            Hide();
        }

        //Calculate Quote
        private void calculateQuote_click(object sender, EventArgs e)
        {

            //CREATE NEW DESK OBJECT
            var desk = new Desk
            {
                Width = widthBox.Value,
                Depth = depthBox.Value,
                DrawerNum = (int)num_Drawers.Value
            };

            //GET SELECTED MATERIAL
            desk.Material = (Desk.DesktopMaterial)box_Materials.SelectedItem;

            //MAKE NEW QUOTE
            var deskQuote = new DeskQuotes
            {
                Desk = desk,
                CustomerName = txt_CustomerName.Text,
                QuoteDate = DateTime.Now,
                Shipping = (DeskQuotes.ShippingOptions)box_Shipping.SelectedValue
            };

            //TRY ADDING NEW QUOTE
            try
            {
                var quote = deskQuote.GetQuote();
                string quoteInfo = deskQuote.QuoteDate.ToString() + ", " + txt_CustomerName.Text + ", "
                    + depthBox.Value + ", " + widthBox.Value + ", " + num_Drawers.Value + ", "
                    + box_Materials.Text + ", " + box_Shipping.Text + ", " + quote + Environment.NewLine;

                File.AppendAllText(@"quotes.txt", quoteInfo);

                DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote);
                displayQuoteForm.Tag = this;
                displayQuoteForm.Show(this);
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ops...there seems to be a problem. {0}", err.Message);
            }

        }
    }
}
