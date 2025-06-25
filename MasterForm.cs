using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantronWinApp
{
    public partial class MasterForm : Form
    {
        //private ToolStripMenuItem printSetupMenuItem;

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
            ToolStripMenuItem masterMenu = new ToolStripMenuItem("Master");
            ToolStripMenuItem setupMenu = new ToolStripMenuItem("Setup");
            ToolStripMenuItem markersMenu = new ToolStripMenuItem("Markers");
            ToolStripMenuItem infusionMenu = new ToolStripMenuItem("Infusion");
            ToolStripMenuItem testRecordingMenu = new ToolStripMenuItem("Test Recording");
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");

            // Create sub-menu items for File menu
            ToolStripMenuItem newMenuItem = new ToolStripMenuItem("New");
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Open..");
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openMenuItem.Click += OpenMenuItem_Click;

            ToolStripMenuItem printSetupMenuItem = new ToolStripMenuItem("Print Setup...");
            printSetupMenuItem.Click += PrintSetupMenuItem_Click;
            fileMenu.DropDownItems.Add(printSetupMenuItem);
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");


            // Create sub-menu items for View menu
            ToolStripMenuItem toolBarMenuItem = new ToolStripMenuItem("Toolbar");
            toolBarMenuItem.CheckOnClick = true; // Enable check/uncheck on click
            toolBarMenuItem.Checked = true; // Default checked state (toolbar visible)
            ToolStripMenuItem statusBarMenuItem = new ToolStripMenuItem("Status Bar");
            statusBarMenuItem.CheckOnClick = true; // Enable check/uncheck on click
            statusBarMenuItem.Checked = true; // Default checked state (status bar visible)

            //For Master 
            ToolStripMenuItem doctersItem = new ToolStripMenuItem("Docters");
            ToolStripMenuItem symptomsItem = new ToolStripMenuItem("Symptoms");

            //For Markers
            // Markers -> Bladder Sensation
            ToolStripMenuItem bladderItem = new ToolStripMenuItem("Bladder Sensation");
            bladderItem.DropDownItems.Add("First Sensation (FS)");
            bladderItem.DropDownItems.Add("First Desire (FD)");
            bladderItem.DropDownItems.Add("Normal Desire (ND)");
            bladderItem.DropDownItems.Add("Strong Desire (SD)");
            bladderItem.DropDownItems.Add("Bladder Capacity (BC)");
            bladderItem.DropDownItems.Add("End Filling Phase");
            bladderItem.DropDownItems.Add("Start of Voiding");

            // Markers -> General
            ToolStripMenuItem generalItem = new ToolStripMenuItem("General");
            generalItem.DropDownItems.Add("Leak (L)");
            generalItem.DropDownItems.Add("Cough (C)");
            generalItem.DropDownItems.Add("Laugh (La)");
            generalItem.DropDownItems.Add("Artifact (X)");
            generalItem.DropDownItems.Add("General Purpose");
            generalItem.DropDownItems.Add("Standing");
            generalItem.DropDownItems.Add("Supine");
            generalItem.DropDownItems.Add("Sitting");


            //Infusion Menu
            ToolStripMenuItem startInfusionItem = new ToolStripMenuItem("Start Infusion (STI)");
            ToolStripMenuItem stopInfusionItem = new ToolStripMenuItem("Stop Infusion (STP)");
            ToolStripMenuItem increaseRateItem = new ToolStripMenuItem("Increase Rate");
            ToolStripMenuItem decreaseRateItem = new ToolStripMenuItem("Decrease Rate");

            //Test Recording Menu
            ToolStripMenuItem startRcdItem = new ToolStripMenuItem("Start");
            ToolStripMenuItem pauseRcdItem = new ToolStripMenuItem("Pause");
            ToolStripMenuItem stopRcdItem = new ToolStripMenuItem("Stop");

            //Window Menu
            ToolStripMenuItem windowItem = new ToolStripMenuItem("New Window");
            ToolStripMenuItem casCadeItem = new ToolStripMenuItem("Cascade");
            ToolStripMenuItem tileItem = new ToolStripMenuItem("Tile");
            ToolStripMenuItem iconsItem = new ToolStripMenuItem("Arrange Icons");
            ToolStripMenuItem currentOpenItem = new ToolStripMenuItem("Current Open");

            // Create sub-menu items for Setup menu
            ToolStripMenuItem systemMenuItem = new ToolStripMenuItem("System");
            ToolStripMenuItem hospitalMenuItem = new ToolStripMenuItem("Hospital / Docter Information");
            ToolStripMenuItem pressureMenuItem = new ToolStripMenuItem("Pressure Flow Study");

            // Create sub-menu items for Help menu
            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About Santron UroDynamics...");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help Topics");
            helpMenuItem.Enabled = false; // Make it read-only (disabled)

            // Attach event handlers for menu items

            newMenuItem.Click += (s, args) =>
            {
                Patient_Information patientForm = new Patient_Information();
                patientForm.Show(); // Open Patient_Information form
            };
            exitMenuItem.Click += (s, args) => Application.Exit();

            //For View Menu

            //For Master Menu
            doctersItem.Click += (s, args) =>
            {
                Doctor docterForm = new Doctor();
                docterForm.Show();

            };

            symptomsItem.Click += (s, args) =>
            {
                Symptoms symptomsForm = new Symptoms();
                symptomsForm.Show();

            };




            //For Setup Menu
            systemMenuItem.Click += (s, args) =>
            {
                //SystemSetup systemForm = new SystemSetup();
                //systemForm.Show(); 

                PasswordForm systemForm = new PasswordForm();
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
            //aboutMenuItem.Click += (s, args) => MessageBox.Show("Santron UroDynamics Version U3.0 with UPP && UFM+EMG\r\nUpgrade dated 27-05-2024\r\nMfg. by : Santron Meditronic, Pune 411037, Email: santronmeditronic@gmail.com\r\nVisit us at www.santronmeditronic.in\r\nSales: +91-9561030550\r\nService Customer care Support: +91-9209584218", "About");
            aboutMenuItem.Click += (s, args) =>
            {
                AboutSantron aboutForm = new AboutSantron();
                aboutForm.Show();
            };
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


            //For Master Menu
            masterMenu.DropDownItems.Add(doctersItem);
            masterMenu.DropDownItems.Add(symptomsItem);


            // Add sub-menu items to Setup menu
            setupMenu.DropDownItems.Add(systemMenuItem);
            setupMenu.DropDownItems.Add(hospitalMenuItem);
            setupMenu.DropDownItems.Add(pressureMenuItem);

            //Markers Menu
            markersMenu.DropDownItems.Add(bladderItem);
            markersMenu.DropDownItems.Add(generalItem);

            //Infusion Menu
            infusionMenu.DropDownItems.Add(startInfusionItem);
            infusionMenu.DropDownItems.Add(stopInfusionItem);
            infusionMenu.DropDownItems.Add(new ToolStripSeparator()); // Adds a separator line
            infusionMenu.DropDownItems.Add(increaseRateItem);
            infusionMenu.DropDownItems.Add(decreaseRateItem);

            //Test Recording Menu
            testRecordingMenu.DropDownItems.Add(startRcdItem);
            testRecordingMenu.DropDownItems.Add(pauseRcdItem);
            testRecordingMenu.DropDownItems.Add(stopRcdItem);

            //Window Menu
            windowMenu.DropDownItems.Add(windowItem);
            windowMenu.DropDownItems.Add(casCadeItem);
            windowMenu.DropDownItems.Add(tileItem);
            windowMenu.DropDownItems.Add(iconsItem);
            windowMenu.DropDownItems.Add(new ToolStripSeparator()); // Adds a separator line
            windowMenu.DropDownItems.Add(currentOpenItem);

            // Add sub-menu items to Help menu
            helpMenu.DropDownItems.Add(aboutMenuItem);
            helpMenu.DropDownItems.Add(helpMenuItem);



            // Add top-level menu items to MenuStrip
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(viewMenu);
            menuStrip.Items.Add(masterMenu);
            menuStrip.Items.Add(setupMenu);
            menuStrip.Items.Add(markersMenu);
            menuStrip.Items.Add(infusionMenu);
            menuStrip.Items.Add(testRecordingMenu);
            menuStrip.Items.Add(windowMenu);
            menuStrip.Items.Add(helpMenu);

            // Add MenuStrip to the form's controls
            this.Controls.Add(menuStrip);
            // Set the MenuStrip as the form's main menu
            this.MainMenuStrip = menuStrip;

            //markersMenu.Visible = false;
            //infusionMenu.Visible = false;
            //testRecordingMenu.Visible = false;
            //windowMenu.Visible = false;
        }



        private void OpenMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open File";
                openFileDialog.InitialDirectory = @"D:\";
                openFileDialog.Filter =
                    "All Supported Files (*.xlsx;*.xls;*.pdf;*.png;*.jpg;*.jpeg;*.bmp;*.txt;*.docx)|*.xlsx;*.xls;*.pdf;*.png;*.jpg;*.jpeg;*.bmp;*.txt;*.docx|" +
                    "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|" +
                    "PDF Files (*.pdf)|*.pdf|" +
                    "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|" +
                    "Text Files (*.txt)|*.txt|" +
                    "Word Files (*.docx)|*.docx|" +
                    "All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    //MessageBox.Show("Selected file: " + selectedFile);

                    FilePreviewForm previewForm = new FilePreviewForm(selectedFile);
                    previewForm.Show();

                }

            }
        }


        //Code For Show Print settings
        private void PrintSetupMenuItem_Click(object sender, EventArgs e)
        {
            using (var pageSetup = new PageSetupDialog())
            {
                // initialize with your defaults (optional)
                pageSetup.PageSettings = new PageSettings();
                pageSetup.PrinterSettings = new PrinterSettings();

                if (pageSetup.ShowDialog(this) == DialogResult.OK)
                {
                    // user clicked OK — you can inspect
                    // pageSetup.PageSettings and
                    // pageSetup.PrinterSettings here
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ReportComments reportsForm = new ReportComments();
            reportsForm.Show();
        }
    }
}
