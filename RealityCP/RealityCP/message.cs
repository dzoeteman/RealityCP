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
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
        }

        // List Messages button
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Search phrase (optional)" & string.IsNullOrEmpty(textBox1.Text) == false)
            {
                Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " messages list");
            }
            else
            {
                Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " messages list " + textBox1.Text);
            }
        }

        // Add/Edit Message button
        private void button2_Click(object sender, EventArgs e)
        {
            msgae MsgAE = new msgae();
            MsgAE.Show();
        }

        // Delete Message button
        private void button4_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox3.Text + " messages del " + textBox2.Text);
        }

        // Back button
        private void button5_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
