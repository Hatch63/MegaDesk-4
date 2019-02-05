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
    public partial class SearchQuotes : Form
    {
        public string[] deskQuotes;

        public SearchQuotes()
        {
            InitializeComponent();
            loadGrid();

            var materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();

            com_SearchBox.DataSource = materials;
            com_SearchBox.SelectedIndex = -1;
        }

        private void loadGrid()
        {
            try
            {
                deskQuotes = File.ReadAllLines(@"quotes.txt");
                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    gridSearchQuotes.Rows.Add(arrRow);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Scan shows file not found Captain!!!");
            }

        }

        private void SCancelBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void com_SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridSearchQuotes.Rows.Clear();
            foreach (string deskQuote in deskQuotes)
            {
                switch (com_SearchBox.SelectedIndex)
                {
                    case 0:
                        if (deskQuote.Contains("oak"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            gridSearchQuotes.Rows.Add(arrRow);
                        }
                        break;
                    case 1:
                        if (deskQuote.Contains("laminate"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            gridSearchQuotes.Rows.Add(arrRow);
                        }
                        break;
                    case 2:
                        if (deskQuote.Contains("pine"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            gridSearchQuotes.Rows.Add(arrRow);
                        }
                        break;
                    case 3:
                        if (deskQuote.Contains("rosewood"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            gridSearchQuotes.Rows.Add(arrRow);
                        }
                        break;
                    case 4:
                        if (deskQuote.Contains("veneer"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            gridSearchQuotes.Rows.Add(arrRow);
                        }
                        break;
                }
            }
        }
    }
}
