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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        //CANCEL BUTTON
        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        //WIDTH VALIDATION
        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            if (widthBox.Value == null)
            {
                MessageBox.Show("Please Enter a Width");
            }
            else if (widthBox.Value < 24 || widthBox.Value > 96)
            {
                MessageBox.Show("The minimum width is 24 and the maximum is 96");
            }
            
        }

        //DEPTH VALIDATION
        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            if (depthBox.Value == null)
            {
                MessageBox.Show("Please Enter a Width");
            }
            else if (depthBox.Value < 12 || widthBox.Value > 48)
            {
                MessageBox.Show("The minimum depth is 12 and the maximum is 48");
            }
        }


        //WIDTH AND DEPTH FUNCTIONS
        private void calculateSurfaceArea_Click(object sender, EventArgs e)
        {
            decimal width = widthBox.Value;
            decimal depth = depthBox.Value;

            decimal surfaceArea = width * depth;
            surfaceAreBox.Text = surfaceArea.ToString();
        }

        private void selectMaterial_Click(object sender, EventArgs e)
        {
            string materialType = box_Materials.Text;
        }

        
    }
}
