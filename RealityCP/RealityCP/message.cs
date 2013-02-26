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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void message_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.messageListMessagesBtn, "This will search for all messages or optionally all messages if you enter a text to search for to the left.");
            ToolTip1.SetToolTip(this.messageSearchText, "If you enter text here and click the button to the right it will search for all messages with this text.");
            ToolTip1.SetToolTip(this.messageAddMessageBtn, "This will take you to the add messages control panel.");
            ToolTip1.SetToolTip(this.messageInstanceText, "This is the instance ID that you would like to delete a message from.");
            ToolTip1.SetToolTip(this.messageMessageIDtext, "This is the message ID that you would like to delete, find this using the find messages button above.");
            ToolTip1.SetToolTip(this.messageDeleteBtn, "Use this to delete the message with instance and message ID selected to the left.");
            ToolTip1.SetToolTip(this.messageBackBtn, "This will take you back to the main menu of the program.");
        }


        // List Messages button
        private void messageListMessagesBtn_Click(object sender, EventArgs e)
        {
            if (messageSearchText.Text != "Search phrase (optional)" & string.IsNullOrEmpty(messageSearchText.Text) == false)
            {
                Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " messages list");
            }
            else
            {
                Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " messages list " + messageSearchText.Text);
            }
        }

        // Add/Edit Message button
        private void messageAddMessageBtn_Click(object sender, EventArgs e)
        {
            msgae MsgAE = new msgae();
            MsgAE.Show();
        }

        // Delete Message button
        private void messageDeleteBtn_Click(object sender, EventArgs e)
        {
            Updates.cmdLine("/C perl db_utility.pl --host " + Config.hostMySQL + " --user " + Config.userMySQL + " --pass " + Config.passMySQL + " --name " + Config.nameMySQL + " --port " + Config.portMySQL + " --instance " + messageInstanceText.Text + " messages del " + messageMessageIDtext.Text);
        }


        // Back button
        private void messageBackBtn_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            this.Hide();
        }

    }
}
