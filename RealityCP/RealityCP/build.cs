using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        private List<string> worldList = new List<string>();
        System.IO.StreamReader file;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void build_Load(object sender, EventArgs e)
        {
            setupMenu();
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

        class MyType
        {
            public string world { get; set; }
            public string worldbuild { get; set; }
            public string worldversion { get; set; }

            public override string ToString()
            {
                return worldbuild;
            }
        }


       /* private string returnWorldID(string worldname){
            try {
                string line;
                file = new System.IO.StreamReader("RealityCPWorlds.cfg");
                while ((line = file.ReadLine()) != null)
                {
                    var fields = line.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string world = fields[1];
                    string version = fields[2];
                    
                    if (world == worldname)
                    {
                        return version;
                    }
                }
                return "0";
            }
            catch (Exception up)
            {
                return "999";
            }
            
        }*/

        private string returnWorldBuild(string worldname)
        {
            try
            {
                for (int i = 0; worldList.Count > i; i++ )
                {
                    var fields = worldList[i].Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string world = fields[1];
                    string version = fields[2];

                    if (world == worldname)
                    {
                        return version;
                    }
                }
                return "0";
            }
            catch (Exception up)
            {
                return "999";
            }

        }

        private string returnWorldID(string worldname)
        {
            try
            {
                for (int i = 0; worldList.Count > i; i++)
                {
                    var fields = worldList[i].Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string world = fields[1];
                    string version = fields[2];

                    if (world == worldname)
                    {
                        return version;
                    }
                }
                return "0";
            }
            catch (Exception up)
            {
                return "999";
            }

        }

        private MyType item;
        private void setupMenu() {
            try{
                string line;
                file = new System.IO.StreamReader("RealityCPWorlds.cfg");
                buildWorldListCombo.DisplayMember = "world";
                buildWorldListCombo.ValueMember = "worldbuild";
                while ((line = file.ReadLine()) != null)
                {
                    var fields = line.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string _world = fields[0];
                    string _worldbuild = fields[1];
                    string _worldversion = fields[2];
                    worldList.Add(_world + "," + _worldbuild + "," + _worldversion);
                    item = new MyType { world = _world, worldbuild = _worldbuild, worldversion = _worldversion };
                    buildWorldListCombo.Items.Add(item); // Add the item
                    buildWorldListCombo.SelectedIndex = 0; // Selects the first item

                }
            }
            catch (Exception up)
            {
                throw up;
            }
        
        }

        public void messageHandler(string message)
        {
            DateTime dn = DateTime.Now;
            string currentDate = dn.ToString("dddd dd MMMM");
            try
            {
                var file = new StreamWriter(currentDate + " RealityCP.log", true);
                file.WriteLine(message);
                file.Close();
            }
            catch (Exception)
            {
                var file = new StreamWriter(currentDate + " RealityCP.log", true);
                file.WriteLine(message);
                file.Close();

            }



        }

        // Build button
        private void buildBuildBtn_Click(object sender, EventArgs e)
        {
            // Check if instance number chosen
            if (string.IsNullOrEmpty(buildInstanceText.Text) == false)
            {
                string worldbuild = "none";

                //worldbuild = buildWorldListCombo.SelectedValue.ToString();
                worldbuild = (buildWorldListCombo.SelectedItem as MyType).worldbuild;

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
                    string ssZedsMessaging = "";
                    string serverversion;
                    if (buildPackagesListBox.GetItemChecked(0) == true) buildings = "--with-buildings";
                    if (buildPackagesListBox.GetItemChecked(1) == true) carepkg = "--with-carepkgs";
                    if (buildPackagesListBox.GetItemChecked(2) == true) invcust = "--with-invcust";
                    if (buildPackagesListBox.GetItemChecked(3) == true) killmsg = "--with-killmsgs";
                    if (buildPackagesListBox.GetItemChecked(4) == true) msg = "--with-messaging";
                    if (buildPackagesListBox.GetItemChecked(5) == true) ssZeds = "--with-ssZeds";
                    if (buildPackagesListBox.GetItemChecked(6) == true) wrecks = "--with-wrecks";
                    if (buildPackagesListBox.GetItemChecked(7) == true) ssZedsMessaging = "--with-ssZedsMessaging";

                    if (worldbuild == "dayzplus") worldtobuild = "--with-dayzplus";
                    if (worldbuild == "i44.chernarus") worldtobuild = "--with-i44.chernarus";

                    serverversion = returnWorldID(worldbuild);
                    if (serverversion == "0")
                    {
                        MessageBox.Show("World defined was not specified in the data file.");
                    }
                    else if (serverversion == "999")
                    {
                        MessageBox.Show("There was a problem with the detection, something went wrong.");
                    }

                    // Conflict check between messaging and ssZeds package
                    if (msg == "--with-messaging" & ssZeds == "--with-ssZeds")
                    {
                        MessageBox.Show("Messaging and ssZeds conflict each other. Please choose the ssZedsMessaging package for both.");
                    }
                    
                    else
                    {
                        if (worldbuild == "i44.chernarus")
                        {
                            if (buildings == "--with-buildings" | carepkg == "--with-carepkgs" | invcust == "--with-invcust" | killmsg == "--with-killmsgs" | msg == "--with-messaging" | ssZeds == "--with-ssZeds" | wrecks == "--with-wrecks" | ssZedsMessaging == "--with-ssZedsMessaging")
                            {
                                MessageBox.Show("i44 isn't known to work with any of the current box, use these at your own risk, no support will be given for these until everything has been verified by the Reality team.");
                            }
                        }
                        try
                        {
                            // Build
                            System.Diagnostics.Process.Start("CMD.exe", "/C build.pl --clean");
                            System.Threading.Thread.Sleep(1000);
                            Updates.cmdLine("/C perl build.pl --world " + worldbuild + " --serverversion " + serverversion + " " + worldtobuild + " --instance " + buildInstanceText.Text + " " + buildings + " " + carepkg + " " + invcust + " " + killmsg + " " + msg + " " + wrecks + " " + " " + ssZeds + " " + ssZedsMessaging);
                        }
                        catch (Exception up)
                        {
                            //throw up; 
                        }
                        if (ssZedsMessaging == "--with-ssZedsMessaging" | msg == "--with-messaging")
                        {
                            MessageBox.Show("Make sure you have imported the messaging schema or the database will crash.");
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
