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
    public partial class build : Form
    {
        public build()
        {
            InitializeComponent();
        }

        





        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void build_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buildWorldListCombo, "This is the list of all worlds that are currently supported by this latest version of the tool.");
            ToolTip1.SetToolTip(this.buildInstanceText, "This is the instance number for the world that will be added above. This will be added to the mission and appended to all files built.");
            ToolTip1.SetToolTip(this.buildPackagesListBox, "This is a list of all of the packages that are available, when building you will be warned if you have selected packages not supported by this world.");
            ToolTip1.SetToolTip(this.buildBuildBtn, "This button will build the world and packages that you have selected above.");
            ToolTip1.SetToolTip(this.buildBackBtn, "This will take you back to the main menu of the program.");
            ToolTip1.SetToolTip(this.buildInstanceText, "Type your instance number that you would like here. This will be automatically merged into the world that is being built.");
            
        }

        private void buildWorldListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                buildInstanceText.Text = "";
                foreach (int i in buildPackagesListBox.CheckedIndices)
                {
                    buildPackagesListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            catch (Exception up)
            { 
                //throw up;
            }
        }


        // Build button
        private void buildBuildBtn_Click(object sender, EventArgs e)
        {
            // Check if instance number chosen
            if (string.IsNullOrEmpty(buildInstanceText.Text) == false)
            {
                string worldbuild = "none";
                switch (buildWorldListCombo.Text)
                {
                    case "Chernarus":
                        worldbuild = "chernarus";
                        break;
                    case "Utes":
                        worldbuild = "utes";
                        break;
                    case "Thirsk":
                        worldbuild = "thirsk";
                        break;
                    case "Thirsk Winter":
                        worldbuild = "thirskw";
                        break;
                    case "Celle":
                        worldbuild = "mbg_celle2";
                        break;
                    case "Lingor (Skaro)":
                        worldbuild = "lingor";
                        break;
                    case "DayZ+":
                        worldbuild = "dayzplus";
                        break;
                    case "Oring":
                        worldbuild = "oring";
                        break;
                    case "Namalsk":
                        worldbuild = "namalsk";
                        break;
                    case "i44.Chernarus":
                        worldbuild = "i44.chernarus";
                        break;
                }

                // Check if world is chosen
                if (worldbuild != "none")
                {
                    // Assign packages
                    string buildings = "";
                    string carepkg = "";
                    string invcust = "";
                    string killmsg = "";
                    string msg = "";
                    string ssZeds = "";
                    string wrecks = "";
                    string worldtobuild = "";
                    if (buildPackagesListBox.GetItemChecked(0) == true) buildings = "--with-buildings";
                    if (buildPackagesListBox.GetItemChecked(1) == true) carepkg = "--with-carepkgs";
                    if (buildPackagesListBox.GetItemChecked(2) == true) invcust = "--with-invcust";
                    if (buildPackagesListBox.GetItemChecked(3) == true) killmsg = "--with-killmsgs";
                    if (buildPackagesListBox.GetItemChecked(4) == true) msg = "--with-messaging";
                    if (buildPackagesListBox.GetItemChecked(5) == true) ssZeds = "--with-ssZeds";
                    if (buildPackagesListBox.GetItemChecked(6) == true) wrecks = "--with-wrecks";
                    if (worldbuild == "mbg_celle2") worldtobuild = "--with-mbg_celle2";
                    if (worldbuild == "dayzplus") worldtobuild = "--with-dayzplus";
                    if (worldbuild == "oring") worldtobuild = "--with-oring";
                    if (worldbuild == "namalsk") worldtobuild = "--with-namalsk";
                    if (worldbuild == "i44.chernarus") worldtobuild = "--with-i44.chernarus";

                    // Conflict check between messaging and ssZeds package
                    if (msg == "--with-messaging" & ssZeds == "--with-ssZeds")
                    {
                        MessageBox.Show("Messaging and ssZeds conflict each other. Please choose one or the other.");
                    }
                    else if (worldbuild == "i44.chernarus" & buildings == "--with-buildings" | carepkg == "--with-carepkgs" | invcust == "--with-invcust" | killmsg == "--with-killmsgs" | msg == "--with-messaging" | ssZeds == "--with-ssZeds" | wrecks == "--with-wrecks")
                    {
                        MessageBox.Show("i44 isn't known to work with any of the current box, this is currently an unsupported feature.");
                    }
                    else
                    {
                        try
                        {
                            // Build
                            System.Diagnostics.Process.Start("CMD.exe", "/C build.pl --clean");
                            System.Threading.Thread.Sleep(1000);
                            Updates.cmdLine("/C perl build.pl --world " + worldbuild + " " + worldtobuild + " --instance " + buildInstanceText.Text + " " + buildings + " " + carepkg + " " + invcust + " " + killmsg + " " + msg + " " + wrecks + " " + " " + ssZeds);
                        }
                        catch (Exception up)
                        {
                            //throw up; 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You didn't choose a world.");
                }
            }
            else
            {
                MessageBox.Show("You didn't choose an instance number.");
            }
        }


        // Back button
        private void buildBackBtn_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Hide();
        }


        // Packages info button
        private void buildHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buildings: buildings placed on the map through the database.\nCarepackages: random loot packages around the map.\nCustom Inventory: allows to set a custom inventory when spawned.\nKillmessages: a message when someone has been killed.\nMessaging: scheduled rcon messages\nDisable server zombies: Disable server-side simulation of zombies (may improve server FPS)\nWrecks: random wrecks around the map with loot");
        }

    }
}
