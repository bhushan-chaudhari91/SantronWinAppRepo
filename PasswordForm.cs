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
    public partial class PasswordForm : Form
    {
        private const string StaticPassword = "12345";
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == StaticPassword)
            {
                // Password is correct, open the SystemSetup form
                SystemSetup setupForm = new SystemSetup();
                setupForm.Show();

                this.Close(); // Close the current PasswordForm
            }
            else
            {
                // Password is incorrect
                MessageBox.Show("Incorrect password. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
