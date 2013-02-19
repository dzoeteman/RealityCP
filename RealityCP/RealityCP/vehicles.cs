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
        public vehicles()
        {
            InitializeComponent();
        }

        // Spawn Vehicles button
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C perl db_spawn_vehicles.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Item Distr. button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --itemdistr");
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

    }
}
