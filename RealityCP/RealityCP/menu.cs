// Main menu
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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

        }

        // Build button
        private void button1_Click(object sender, EventArgs e)
        {
            build bui = new build();
            bui.Show();
            this.Hide();
        }

        // Vehicles/Items button
        private void button2_Click(object sender, EventArgs e)
        {
            vehicles veh = new vehicles();
            veh.Show();
            this.Hide();
        }

        // Cleanup button
        private void button3_Click(object sender, EventArgs e)
        {
            cleanup cln = new cleanup();
            cln.Show();
            this.Hide();
        }

        // Messages button
        private void button4_Click(object sender, EventArgs e)
        {
            message msg = new message();
            msg.Show();
            this.Hide();
        }

        // Setup button
        private void button5_Click(object sender, EventArgs e)
        {
            setup setUp = new setup();
            setUp.Show();
            this.Hide();
        }

        // Exit button
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
