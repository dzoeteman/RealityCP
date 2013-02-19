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

        // Clean Vehicles button
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --cleanup damaged");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Clean Tents button
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --cleanup tents");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Clean Bounds button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --cleanup bounds");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Clean Dead button
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                if (textBox3.Text != "Days to clean" & string.IsNullOrEmpty(textBox3.Text) == false)
                {
                    Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --cleandead " + textBox3.Text);
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

        // Clean All button
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --cleanup all");
            }
            else
            {
                MessageBox.Show("Instance number not filled in.");
            }
        }

        // Clean Items button
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Instance" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                if (textBox2.Text != "Clean Item(s)" & string.IsNullOrEmpty(textBox2.Text) == false)
                {
                    Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox1.Text + " --cleanitem " + textBox2.Text);
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

        // Clean Temp button
        private void button7_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C build.pl --clean");
        }

        // Back button
        private void button8_Click(object sender, EventArgs e)
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
