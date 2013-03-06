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

        // Back button
        private void cleanupBackBtn_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Hide();
        }

        
        private void cleanup_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.cleanupInstanceText, "This is the instance number that you would like to clean up items from. This is a required setting for almost all cleanup options on this page. You will be notifed if you have not filled this out properly.");
            ToolTip1.SetToolTip(this.cleanupDaysText, "This is the number of days that you would like to clean up items for. This is a required setting for almost all cleanup options on this page. You will be notifed if you have not filled this out properly.");
            ToolTip1.SetToolTip(this.cleanupItemText, "This is the item/vehicle/deployable object number that you would like to clean up items for. This is a required setting for almost all cleanup options on this page. You will be notifed if you have not filled this out properly.");
            ToolTip1.SetToolTip(this.cleanupBackBtn, "This will take you back to the main menu of the program.");

        }

        private void cleanITBtn_Click(object sender, EventArgs e)
        {
            string itemToClean = itemToCleanBox.Text;
            if (itemToClean == "all")
            {
                if (cleanupInstanceText.Text != "" )
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup all");
                }
                else
                {
                    MessageBox.Show("Instance number not filled in.");
                }
            }
            else if (itemToClean == "buildfiles")
            {
                Updates.cmdLine("/C perl build.pl --clean");
            }
            else if (itemToClean == "damaged")
            {
                if (cleanupInstanceText.Text != "" )
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup damaged");
                }
                else
                {
                    MessageBox.Show("Instance number not filled in.");
                } 
            }
            else if (itemToClean == "bounds")
            {
                if (cleanupInstanceText.Text != "" )
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup bounds");
                }
                else
                {
                    MessageBox.Show("Instance number not filled in.");
                }
            }
            else if (itemToClean == "tents")
            {
                if (cleanupInstanceText.Text != "" )
                {
                    Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + cleanupInstanceText.Text + " --cleanup tents");
                }
                else
                {
                    MessageBox.Show("Instance number not filled in.");
                }
            }
            else if (itemToClean == "cleanitem")
            {
                if (cleanupInstanceText.Text != "" )
                {
                    if (cleanupItemText.Text != "" )
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
            else if (itemToClean == "cleandead")
            {
                if (cleanupInstanceText.Text != "")
                {
                    if (cleanupDaysText.Text != "")
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
            else if (itemToClean == "cleanvehicle")
            {
                if (cleanupInstanceText.Text != "")
                {
                    if (cleanupDaysText.Text != "")
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
            else if (itemToClean == "cleandeploy")
            {
                if (cleanupInstanceText.Text != "")
                {
                    if (cleanupItemText.Text != "")
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
        }

        private void itemToCleanBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanupInstanceText.Text = "";
            cleanupDaysText.Text = "";
            cleanupItemText.Text = "";
        }

    }
}
