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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        //CANCEL NAVIGATION
        private void CancelViewButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void loadGrid()
        {
            try
            {
                string[] deskQuotes = File.ReadAllLines(@"quotes.txt");
                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    gridAllQuotes.Rows.Add(arrRow);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Scan shows file not found Captain!!!");
            }

        }

        private void gridAllQuotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
