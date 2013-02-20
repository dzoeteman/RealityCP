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

        // Build button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if instance number chosen
            if(string.IsNullOrEmpty(textBox1.Text) == false)
            {
                string worldbuild = "none";
                switch (comboBox1.Text)
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
                        worldbuild = "skaro.lingor";
                        break;
                    case "DayZ+":
                        worldbuild = "dayzplus";
                        break;
                    case "Oring":
                        worldbuild = "oring";
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
                    string celle = "";
                    string dayzplus = "";
                    string oring = "";
                    if (checkedListBox1.GetItemChecked(0) == true) buildings = "--with-buildings";
                    if (checkedListBox1.GetItemChecked(1) == true) carepkg = "--with-carepkgs";
                    if (checkedListBox1.GetItemChecked(2) == true) invcust = "--with-invcust";
                    if (checkedListBox1.GetItemChecked(3) == true) killmsg = "--with-killmsgs";
                    if (checkedListBox1.GetItemChecked(4) == true) msg = "--with-messaging";
                    if (checkedListBox1.GetItemChecked(5) == true) ssZeds = "--with-ssZeds";
                    if (checkedListBox1.GetItemChecked(6) == true) wrecks = "--with-wrecks";
                    if (worldbuild == "mbg_celle2") celle = "--with-mbg_celle2";
                    if (worldbuild == "dayzplus") dayzplus = "--with-dayzplus";
                    if (worldbuild == "oring") dayzplus = "--with-oring";

                    // Conflict check between messaging and ssZeds package
                    if (msg == "--with-messaging" & ssZeds == "--with-ssZeds")
                    {
                        MessageBox.Show("Messaging and ssZeds conflict eachother. Please use either or.");
                    }
                    else
                    {
                        // Build
                        System.Diagnostics.Process.Start("CMD.exe", "/C build.pl --clean");
                        System.Threading.Thread.Sleep(1000);
                    Updates.cmdLine("/C perl build.pl --world " + worldbuild + " --instance " + textBox1.Text + " " + buildings + " " + carepkg + " " + dayzplus + " " + invcust + " " + killmsg + " " + msg + " " + wrecks + " " + ssZeds + " " + celle + " " + oring);
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

        // Packages info button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buildings: buildings placed on the map through the database.\nCarepackages: random loot packages around the map.\nCustom Inventory: allows to set a custom inventory when spawned.\nKillmessages: a message when someone has been killed.\nMessaging: scheduled rcon messages\nDisable server zombies: Disable server-side simulation of zombies (may improve server FPS)\nWrecks: random wrecks around the map with loot");
        }

        // Back button
        private void button2_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
