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
    public partial class vehicles : Form
    {
        public static bool vehSpawnbox = false;
        public vehicles()
        {
            InitializeComponent();
        }

        // Spawn Vehicles button
        private void button1_Click(object sender, EventArgs e)
        {
            if (vehiclesInstanceText.Text != "Instance" & string.IsNullOrEmpty(vehiclesInstanceText.Text) == false)
            {
                if (!vehSpawnbox)
                {
                    if (MessageBox.Show("Have you cleaned up your vehicles lately? If not, no vehicles might spawn.", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + vehiclesInstanceText.Text);
                    }
                    vehSpawnbox = true;
                }
                else
                {
                    Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + vehiclesInstanceText.Text);
                }
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Item Distr. button
        private void button2_Click(object sender, EventArgs e)
        {
            if (vehiclesInstanceText.Text != "Instance" & string.IsNullOrEmpty(vehiclesInstanceText.Text) == false)
            {
                Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + vehiclesInstanceText.Text + " --itemdistr");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Back button
        private void button3_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vehicles_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.vehiclesBackbtn, "This will take you back to the main menu of the program.");
        }

    }
}
