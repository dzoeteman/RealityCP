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
                button1.Enabled = false;
            }
        }

        // Set-up Perl button
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("setup_perl.bat");
            button1.Enabled = false;
            Updates.UpdateSetting("perl", "done");
        }

        // MySQL details button
        private void button2_Click(object sender, EventArgs e)
        {
            sqlinfo form1 = new sqlinfo();
            form1.Show();
            this.Hide();
        }

        // Database button
        private void button3_Click(object sender, EventArgs e)
        {
            dbsetup dbSetup = new dbsetup();
            dbSetup.Show();
            this.Hide();
        }

        // Update BE scripts button
        private void button5_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl update_scripts.pl ./util/dayz_config/Battleye");
            MessageBox.Show("BattlEye scripts are updated. Rebuild your server package to get the filters.");
        }

        // Back button
        private void button4_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
