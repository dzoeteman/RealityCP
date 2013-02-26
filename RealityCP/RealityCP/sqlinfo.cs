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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int up;
        int down;
        int left;
        int right;
        int b;
        int a;

        private void sqlinfo_Load(object sender, EventArgs e)
        {
            up = 0;
            down = 0;
            left = 0;
            right = 0;
            b = 0;
            a = 0;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.sqlinfoContinueBtn, "This will save the settings and exit the application.");
            ToolTip1.SetToolTip(this.sqlinfoIPText, "Please enter your servers mysql IP here.");
            ToolTip1.SetToolTip(this.sqlinfoPortText, "Please enter your servers mysql Port here.");
            ToolTip1.SetToolTip(this.sqlinfoUserText, "Please enter your servers mysql User here.");
            ToolTip1.SetToolTip(this.sqlinfoPasswordText, "Please enter your servers mysql Password here.");
            ToolTip1.SetToolTip(this.sqlinfoDatabaseText, "Please enter your servers mysql Database name here.");
        }

        private void sqlinfoContinueBtn_Click(object sender, EventArgs e)
        {
            Updates.UpdateSetting("host", sqlinfoIPText.Text);
            Updates.UpdateSetting("port", sqlinfoPortText.Text);
            Updates.UpdateSetting("user", sqlinfoUserText.Text);
            Updates.UpdateSetting("pass", sqlinfoPasswordText.Text);
            Updates.UpdateSetting("name", sqlinfoDatabaseText.Text);
            MessageBox.Show("Settings saved! Please restart the application.");
            Application.Exit();
        }

        private void sqlinfoIPText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up++;
                if (up > 2)
                { up = 0; }
                textBox1.Text = Convert.ToString(e.KeyCode + up );
            }

            if (e.KeyCode == Keys.Down)
            {
                down++;
                if (down > 2)
                { down = 0; }
                textBox1.Text = Convert.ToString(e.KeyCode + down);
            }

            if (e.KeyCode == Keys.Left)
            {
                left++;
                if (left > 2)
                { left = 0; }
                textBox1.Text = Convert.ToString(e.KeyCode + left);
            }

            if (e.KeyCode == Keys.Right)
            {
                right++;
                if (right > 2)
                { right = 0; }
                textBox1.Text = Convert.ToString(e.KeyCode + right);
            }

            if (e.KeyCode == Keys.B)
            {
                b++;
                if (b > 2)
                { b = 0; }
                textBox1.Text = Convert.ToString(e.KeyCode + b);
            }

            if (e.KeyCode == Keys.A)
            {
                a++;
                if (a > 2)
                { a = 0; }
                textBox1.Text = Convert.ToString(e.KeyCode + a);
            }
            if (up == 2 & down == 2 & left == 2 & right == 2 & b == 1 & a == 1)
            {
                MessageBox.Show("Stop Playing R4Z0RMod, go play DayzMod!");
            }
            else
            {
                textBox1.Text = Convert.ToString(up + " " + down + " " + left  + " " + right  + " " + b  + " " + a );
            }
           
        }
    }
}
