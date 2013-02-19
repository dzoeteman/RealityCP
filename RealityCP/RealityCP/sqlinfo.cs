// Setting up MySQL details
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace RealityCP
{
    public partial class sqlinfo : Form
    {
        public sqlinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updates.UpdateSetting("host", textBox1.Text);
            Updates.UpdateSetting("port", textBox2.Text);
            Updates.UpdateSetting("user", textBox3.Text);
            Updates.UpdateSetting("pass", textBox4.Text);
            Updates.UpdateSetting("name", textBox5.Text);
            MessageBox.Show("Settings saved! Please restart the application.");
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
