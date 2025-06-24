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
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            MenuStrip menuStrip = new MenuStrip();

            // Create top-level menu items
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem viewMenu = new ToolStripMenuItem("View");
            ToolStripMenuItem setupMenu = new ToolStripMenuItem("Setup");
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");

            // Create sub-menu items for File menu
            ToolStripMenuItem newMenuItem = new ToolStripMenuItem("New");
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Open..");
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            ToolStripMenuItem printSetupMenuItem = new ToolStripMenuItem("Print Setup...");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");


            // Create sub-menu items for View menu
            ToolStripMenuItem toolBarMenuItem = new ToolStripMenuItem("Toolbar");
            toolBarMenuItem.CheckOnClick = true; // Enable check/uncheck on click
            toolBarMenuItem.Checked = true; // Default checked state (toolbar visible)
            ToolStripMenuItem statusBarMenuItem = new ToolStripMenuItem("Status Bar");
            statusBarMenuItem.CheckOnClick = true; // Enable check/uncheck on click
            statusBarMenuItem.Checked = true; // Default checked state (status bar visible)

            // Create sub-menu items for Setup menu
            ToolStripMenuItem systemMenuItem = new ToolStripMenuItem("System");
            ToolStripMenuItem hospitalMenuItem = new ToolStripMenuItem("Hospital / Docter Information");
            ToolStripMenuItem pressureMenuItem = new ToolStripMenuItem("Pressure Flow Study");

            // Create sub-menu items for Help menu
            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About Santron UroDynamics...");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help Topics");
            helpMenuItem.Enabled = false; // Make it read-only (disabled)

            // Attach event handlers for menu items
            //For File Menu
            //newMenuItem.Click += (s, args) => MessageBox.Show("New file created!", "Info");
            newMenuItem.Click += (s, args) =>
            {
                Patient_Information patientForm = new Patient_Information();
                patientForm.Show(); // Open Patient_Information form
            };
            openMenuItem.Click += (s, args) => MessageBox.Show("Opening file...", "Info");
            printSetupMenuItem.Click += (s, args) => MessageBox.Show("Opening file...", "Info");
            exitMenuItem.Click += (s, args) => Application.Exit();

            //For View Menu
            //toolBarMenuItem.Click += (s, args) => MessageBox.Show("Copy selected!", "Info");
            //statusBarMenuItem.Click += (s, args) => MessageBox.Show("Copy selected!", "Info");

            //For Setup Menu
            systemMenuItem.Click += (s, args) =>
            {
                SystemSetup systemForm = new SystemSetup();
                systemForm.Show(); 
            };
            hospitalMenuItem.Click += (s, args) =>
            {
                HospitalAndDoctorInfoSetUp hospitalForm = new HospitalAndDoctorInfoSetUp();
                hospitalForm.Show();
            };
            //pressureMenuItem.Click += (s, args) => MessageBox.Show("Paste completed!", "Info");
            pressureMenuItem.Click += (s, args) =>
            {
                ScaleAndColorSteup pressureStudyForm = new ScaleAndColorSteup();
                pressureStudyForm.Show();
            };
            //For Help Menu
            aboutMenuItem.Click += (s, args) => MessageBox.Show("Santron UroDynamics Version U3.0 with UPP && UFM+EMG\r\nUpgrade dated 27-05-2024\r\nMfg. by : Santron Meditronic, Pune 411037, Email: santronmeditronic@gmail.com\r\nVisit us at www.santronmeditronic.in\r\nSales: +91-9561030550\r\nService Customer care Support: +91-9209584218", "About");
            helpMenuItem.Click += (s, args) => MessageBox.Show("Read Only", "About");

            // Add sub-menu items to File menu
            fileMenu.DropDownItems.Add(newMenuItem);
            fileMenu.DropDownItems.Add(openMenuItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator()); // Adds a separator line
            fileMenu.DropDownItems.Add(printSetupMenuItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator()); // Adds a separator line
            fileMenu.DropDownItems.Add(exitMenuItem);

            // Add sub-menu items to View menu
            viewMenu.DropDownItems.Add(toolBarMenuItem);
            viewMenu.DropDownItems.Add(statusBarMenuItem);
           

            // Add sub-menu items to Setup menu
            setupMenu.DropDownItems.Add(systemMenuItem);
            setupMenu.DropDownItems.Add(hospitalMenuItem);
            setupMenu.DropDownItems.Add(pressureMenuItem);

            // Add sub-menu items to Help menu
            helpMenu.DropDownItems.Add(aboutMenuItem);
            helpMenu.DropDownItems.Add(helpMenuItem);

            // Add top-level menu items to MenuStrip
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(viewMenu);
            menuStrip.Items.Add(setupMenu);
            menuStrip.Items.Add(helpMenu);

            // Add MenuStrip to the form's controls
            this.Controls.Add(menuStrip);

            // Set the MenuStrip as the form's main menu
            this.MainMenuStrip = menuStrip;
        }
    }
}
