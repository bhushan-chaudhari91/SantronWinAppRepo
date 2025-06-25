using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantronWinApp
{
    public partial class ScaleAndColorSteup : Form
    {
        public ScaleAndColorSteup()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonColor0_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor0.BackColor = colorDialog1.Color;
 
            }
        }
    }
}
