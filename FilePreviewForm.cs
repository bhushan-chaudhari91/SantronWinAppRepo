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

namespace SantronWinApp
{
    public partial class FilePreviewForm : Form
    {
        public FilePreviewForm(string filePath)
        {
            InitializeComponent();

            this.Text = "Preview: " + Path.GetFileName(filePath);
            this.Size = new Size(800, 600); // Set a good preview size

            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".txt") // Notepad files
            {
                var textBox = new TextBox
                {
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    ScrollBars = ScrollBars.Both,
                    ReadOnly = true,
                    Text = File.ReadAllText(filePath),
                    Font = new Font("Consolas", 12)
                };
                this.Controls.Add(textBox);
            }
            else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
            {
                var pictureBox = new PictureBox
                {
                    Image = Image.FromFile(filePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(pictureBox);
            }
            else if (extension == ".pdf")
            {
                var webBrowser = new WebBrowser
                {
                    Dock = DockStyle.Fill,
                    Url = new Uri(filePath) 
                };
                this.Controls.Add(webBrowser);
            }
            else
            {
                Label label = new Label
                {
                    Text = "Preview not supported for this file type.\n\nFile Path:\n" + filePath,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(label);
            }
        }

        private void FilePreviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
