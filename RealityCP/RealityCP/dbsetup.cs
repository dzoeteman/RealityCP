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
    public partial class dbsetup : Form
    {
        public dbsetup()
        {
            InitializeComponent();
        }

        // Database scheme button
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Reality Main (req.)":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL);
                    break;
                case "Buildings":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityBuildings --version 0.01");
                    break;
                case "Messaging":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityMessaging --version 0.01");
                    break;
                case "Custom Inventory":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityInvCust --version 0.02");
                    break;
                case "DayZ+":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityDayzPlus --version 0.01");
                    break;
                case "Thirsk":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityThirsk --version 0.01");
                    break;
                case "Thirsk Winter":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityThirskWinter --version 0.01");
                    break;
                case "Lingor (Skaro)":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealitySkaroLingor --version 0.01");
                    break;
                case "Oring":
                    Updates.cmdLine("/C perl db_migrate.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityOring --version 0.01");
                    break;
                default:
                    MessageBox.Show("No option selected.");
                    break;
            }
        }

        // Add Instance button
        private void button3_Click(object sender, EventArgs e)
        {
            string worldadd = "0";
            switch (comboBox2.Text)
            {
                case "Chernarus":
                    worldadd = "chernarus";
                    break;
                case "Utes":
                    worldadd = "utes";
                    break;
                case "Thirsk":
                    worldadd = "thirsk";
                    break;
                case "Thirsk Winter":
                    worldadd = "thirskw";
                    break;
                case "Celle":
                    worldadd = "mbg_celle2";
                    break;
                case "Lingor (Skaro)":
                    worldadd = "lingor";
                    break;
                case "Oring":
                    worldadd = "oring";
                    break;
                default:
                    MessageBox.Show("No option selected.");
                    break;
            }
            if (worldadd != "0")
            {
                Updates.cmdLine("/C perl db_utility.pl addinstance " + worldadd + "--host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL);
            }
        }

        // Remove Instance button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No instance number filled in.");
            }
            else
            {
                Updates.cmdLine("/C perl db_utility.pl deleteinstance " + textBox1.Text + "--host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL);
            }
        }

        // Bliss migration button
        private void button5_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --schema RealityMigrate --version 0.01");
        }

        // Back button
        private void button4_Click(object sender, EventArgs e)
        {
            setup setUp = new setup();
            setUp.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
