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

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor1.BackColor = colorDialog1.Color;
            }

        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor2.BackColor = colorDialog1.Color;
            }
        }

        private void buttonColor3_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor3.BackColor = colorDialog1.Color;
            }
        }

        private void buttonColor4_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor4.BackColor = colorDialog1.Color;
            }
        }
         
 
        private void buttonColor5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor5.BackColor = colorDialog1.Color;
            }
        }

        private void buttonColor6_Click_1(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textPlotColor6.BackColor = colorDialog1.Color;
            }
        }





        private void buttonBgColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textBackgroundColor.BackColor = colorDialog1.Color;
            }
        }

        private void buttonBladderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textBladderSensation.BackColor = colorDialog1.Color;
            }
        }

        private void buttonGeneralColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textGeneralPurpose.BackColor = colorDialog1.Color;
            }

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Apply selected color to the TextBox background
                textResponseMarkers.BackColor = colorDialog1.Color;
            }
        }

        private void ScaleAndColorSteup_Load(object sender, EventArgs e)
        {

        }
    }
}
