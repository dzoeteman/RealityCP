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
    public partial class cleanup : Form
    {
        public cleanup()
        {
            InitializeComponent();
        }

       

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void removeVehiclesBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                if (cleanupDaysText.Text != "Days to clean" & string.IsNullOrEmpty(cleanupDaysText.Text) == false)
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " cleanvehicle " + cleanupItemText.Text);
                }
                else
                {
                    MessageBox.Show("Vehicles to clean not filled in (seperate by comma)");
                }
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Back button
        private void cleanupBackBtn_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Hide();
        }


        // Clean Temp button
        private void cleanTempBtn_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl build.pl --clean");
        }


        // Clean All button
        private void cleanAllBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup all");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Clean Dead button
        private void cleanDeadBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                if (cleanupDaysText.Text != "Days to clean" & string.IsNullOrEmpty(cleanupDaysText.Text) == false)
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " cleandead " + cleanupDaysText.Text);
                }
                else
                {
                    MessageBox.Show("Number of days to delete dead survivors not filled in.");
                }
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }


        // Clean Items button
        private void cleanItemsBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                if (cleanupItemText.Text != "Clean Item(s)" & string.IsNullOrEmpty(cleanupItemText.Text) == false)
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " cleanitem " + cleanupItemText.Text);
                }
                else
                {
                    MessageBox.Show("Items to clean not filled in (seperate by comma)");
                }
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        private void removeDeployedBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                if (cleanupItemText.Text != "Clean Item(s)" & string.IsNullOrEmpty(cleanupItemText.Text) == false)
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " cleandeploy " + cleanupItemText.Text);
                }
                else
                {
                    MessageBox.Show("Items to clean not filled in (seperate by comma)");
                }
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }


        // Clean Bounds button
        private void cleanBoundsBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup bounds");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }


        // Clean Tents button
        private void cleanTentsBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup tents");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Clean Vehicles button
        private void cleanDamageBtn_Click(object sender, EventArgs e)
        {
            if (cleanupInstanceText.Text != "Instance" & string.IsNullOrEmpty(cleanupInstanceText.Text) == false)
            {
                Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup damaged");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        private void cleanup_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.cleanupInstanceText, "This is the instance number that you would like to clean up items from. This is a required setting for almost all cleanup options on this page. You will be notifed if you have not filled this out properly.");
            ToolTip1.SetToolTip(this.cleanupDaysText, "This is the number of days that you would like to clean up items for. This is a required setting for almost all cleanup options on this page. You will be notifed if you have not filled this out properly.");
            ToolTip1.SetToolTip(this.cleanupItemText, "This is the item/vehicle/deployable object number that you would like to clean up items for. This is a required setting for almost all cleanup options on this page. You will be notifed if you have not filled this out properly.");
            ToolTip1.SetToolTip(this.removeVehiclesBtn, "This will remove the vehicles that are listed in the ID box for the instance that you have selected. This must be a proper Vehicle ID as listed in the database.");
            ToolTip1.SetToolTip(this.cleanDamageBtn, "This will cleanup any and all damaged items that are on the server in the instance that you select.");
            ToolTip1.SetToolTip(this.cleanTentsBtn, "This will cleanup any tents that are on the server for the instance that you select.");
            ToolTip1.SetToolTip(this.cleanAllBtn, "This will clean all deployables, tents and damaged vehicles for the instance number that you select.");
            ToolTip1.SetToolTip(this.cleanDeadBtn, "This will purge all records for dead players on the server for the instance you select.");
            ToolTip1.SetToolTip(this.cleanItemsBtn, "This will cleanup any items on the server for the instance that you select. Item ID is a required field, this is a comma delimited feild.");
            ToolTip1.SetToolTip(this.removeDeployedBtn, "This will cleanup any deployables on the server for the instance that you select. Item ID is a required field, this is a comma delimited feild.");
            ToolTip1.SetToolTip(this.cleanBoundsBtn, "This will cleanup any items that are outside of the world bounds for the instance number that you have slected.");
            ToolTip1.SetToolTip(this.cleanTempBtn, "This will clean all build files on the server from the last build attempt.");
            ToolTip1.SetToolTip(this.cleanupBackBtn, "This will take you back to the main menu of the program.");

        }

    }
}
