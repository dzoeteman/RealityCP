// Main menu
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealityCP
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void menu_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.menuBuildBtn, "This button with take you to the build control panel.");
            ToolTip1.SetToolTip(this.menuVehiclesBtn, "This button with take you to the vehicle control panel.");
            ToolTip1.SetToolTip(this.menuCleanupBtn, "This button with take you to the cleanup control panel.");
            ToolTip1.SetToolTip(this.menuMessagesBtn, "This button with take you to the messages control panel.");
            ToolTip1.SetToolTip(this.menuSetupBtn, "This button with take you to the setup control panel.");
            ToolTip1.SetToolTip(this.menuExitBtn, "This will take you back to the main menu of the program.");
        }


        // Build button
        private void menuBuildBtn_Click(object sender, EventArgs e)
        {
            build bui = new build();
            bui.Show();
            this.Hide();
        }


        // Vehicles/Items button
        private void menuVehiclesBtn_Click(object sender, EventArgs e)
        {
            vehicles veh = new vehicles();
            veh.Show();
            this.Hide();
        }

        // Messages button
        private void menuMessagesBtn_Click(object sender, EventArgs e)
        {
            message msg = new message();
            msg.Show();
            this.Hide();
        }

        // Cleanup button
        private void menuCleanupBtn_Click(object sender, EventArgs e)
        {
            cleanup cln = new cleanup();
            cln.Show();
            this.Hide();
        }


        // Setup button
        private void menuSetupBtn_Click(object sender, EventArgs e)
        {
            setup setUp = new setup();
            setUp.Show();
            this.Hide();
        }

        // Exit button
        private void menuExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.teamspeak.com/invite/teamspeak.hngamers.com");
        }

    }
}
