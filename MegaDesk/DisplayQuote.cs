using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote (DeskQuotes desks)
        {
            InitializeComponent();
            txt_CustomerName2.Text = desks.CustomerName;
            txt_total.Text = desks.GetQuote().ToString();
            txt_depth.Text = desks.Desk.Depth.ToString();
            txt_width.Text = desks.Desk.Width.ToString();
            txt_drawers.Text = desks.Desk.DrawerNum.ToString();
            txt_material.Text = desks.Desk.Material.ToString();
            txt_shipping.Text = desks.Shipping.ToString();
        }

        private void DisCancelButton_Click(object sender, EventArgs e)
        {
            AddForm addNewQuoteForm = new AddForm();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide(); ;
        }
    }
}
