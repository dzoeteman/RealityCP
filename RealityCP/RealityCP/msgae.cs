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
    public partial class msgae : Form
    {
        public msgae()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox2.Text + " messages add " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + textBox2.Text + " messages edit " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
