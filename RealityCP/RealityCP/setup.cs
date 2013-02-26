using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace RealityCP
{
    public partial class setup : Form
    {
        public setup()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["perl"] == "done")
            {
                setupSetupPerlBtn.Enabled = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void setup_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.setupSetupPerlBtn, "Setup the Perl system to work with the tool properly. Do this if you get any errors running options.");
            ToolTip1.SetToolTip(this.setupMyqlBtn, "Setup the servers MySQL information so you can connect to the database with the rest of the tool.");
            ToolTip1.SetToolTip(this.setupDatabaseBtn, "Setup the servers database settings, import all new schemas and more.");
            ToolTip1.SetToolTip(this.setupUpdateBtn, "Update all of the Battleye scripts on the server.");
            ToolTip1.SetToolTip(this.setupBackBtn, "This will take you back to the main menu of the program.");
        }

        // Set-up Perl button
        private void setupSetupPerlBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("setup_perl.bat");
            setupSetupPerlBtn.Enabled = false;
            Updates.UpdateSetting("perl", "done");
        }

        // MySQL details button
        private void setupMyqlBtn_Click(object sender, EventArgs e)
        {
            sqlinfo form1 = new sqlinfo();
            form1.Show();
            this.Hide();
        }

        // Database button
        private void setupDatabaseBtn_Click(object sender, EventArgs e)
        {
            dbsetup dbSetup = new dbsetup();
            dbSetup.Show();
            this.Hide();
        }

        // Update BE scripts button
        private void setupUpdateBtn_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl update_scripts.pl ./util/dayz_config/Battleye");
            MessageBox.Show("BattlEye scripts are updated. Rebuild your server package to get the filters.");
        }

        // Back button
        private void setupBackBtn_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            this.Hide();
        }
    }
}
