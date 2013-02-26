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

        private void msgae_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.msgaeAddBtn, "This will add the message to the server based on the information entered above.");
            ToolTip1.SetToolTip(this.msgaeEditBtn, "This will edit the message on the server based on the information listed above.");
            ToolTip1.SetToolTip(this.msgaeCloseBtn, "This will take you back to the main menu of the program.");
        }

        private void msgaeAddBtn_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + msgaeInstanceText.Text + " messages add " + msgaeInstanceText.Text + " " + msgaeStartText.Text + " " + msgaeLoopText.Text + " " + msgaeMessageText.Text);
        }

        private void msgaeEditBtn_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + msgaeInstanceText.Text + " messages edit " + msgaeMessageIDText.Text + " " + msgaeInstanceText.Text + " " + msgaeStartText.Text + " " + msgaeLoopText.Text + " " + msgaeMessageText.Text);
        }

        private void msgaeCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
