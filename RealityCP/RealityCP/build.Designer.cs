namespace RealityCP
{
    partial class build
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(build));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buildWorldListCombo = new System.Windows.Forms.ComboBox();
            this.buildInstanceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buildPackagesListBox = new System.Windows.Forms.CheckedListBox();
            this.buildBuildBtn = new System.Windows.Forms.Button();
            this.buildBackBtn = new System.Windows.Forms.Button();
            this.buildHelpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "World";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Packages";
            // 
            // buildWorldListCombo
            // 
            this.buildWorldListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildWorldListCombo.FormattingEnabled = true;
            this.buildWorldListCombo.Items.AddRange(new object[] {
            "Celle",
            "Chernarus",
            "i44.Chernarus",
            "Lingor (Skaro)",
            "Namalsk",
            "Oring",
            "Thirsk",
            "Thirsk Winter",
            "Utes",
            ""});
            this.buildWorldListCombo.Location = new System.Drawing.Point(76, 68);
            this.buildWorldListCombo.Name = "buildWorldListCombo";
            this.buildWorldListCombo.Size = new System.Drawing.Size(174, 21);
            this.buildWorldListCombo.TabIndex = 3;
            this.buildWorldListCombo.SelectedIndexChanged += new System.EventHandler(this.buildWorldListCombo_SelectedIndexChanged);
            // 
            // buildInstanceText
            // 
            this.buildInstanceText.Location = new System.Drawing.Point(76, 95);
            this.buildInstanceText.Name = "buildInstanceText";
            this.buildInstanceText.Size = new System.Drawing.Size(174, 20);
            this.buildInstanceText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "by gdscei";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(33, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reality Control Panel";
            // 
            // buildPackagesListBox
            // 
            this.buildPackagesListBox.FormattingEnabled = true;
            this.buildPackagesListBox.Items.AddRange(new object[] {
            "Buildings",
            "Carepackages",
            "Custom Inventory",
            "Killmessages",
            "Messaging",
            "Disable server zombies",
            "Wrecks"});
            this.buildPackagesListBox.Location = new System.Drawing.Point(76, 124);
            this.buildPackagesListBox.Name = "buildPackagesListBox";
            this.buildPackagesListBox.Size = new System.Drawing.Size(174, 49);
            this.buildPackagesListBox.TabIndex = 9;
            // 
            // buildBuildBtn
            // 
            this.buildBuildBtn.Location = new System.Drawing.Point(76, 179);
            this.buildBuildBtn.Name = "buildBuildBtn";
            this.buildBuildBtn.Size = new System.Drawing.Size(174, 23);
            this.buildBuildBtn.TabIndex = 10;
            this.buildBuildBtn.Text = "Build!";
            this.buildBuildBtn.UseVisualStyleBackColor = true;
            this.buildBuildBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // buildBackBtn
            // 
            this.buildBackBtn.Location = new System.Drawing.Point(38, 226);
            this.buildBackBtn.Name = "buildBackBtn";
            this.buildBackBtn.Size = new System.Drawing.Size(212, 23);
            this.buildBackBtn.TabIndex = 11;
            this.buildBackBtn.Text = "Back";
            this.buildBackBtn.UseVisualStyleBackColor = true;
            this.buildBackBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // buildHelpBtn
            // 
            this.buildHelpBtn.Location = new System.Drawing.Point(38, 140);
            this.buildHelpBtn.Name = "buildHelpBtn";
            this.buildHelpBtn.Size = new System.Drawing.Size(32, 23);
            this.buildHelpBtn.TabIndex = 12;
            this.buildHelpBtn.Text = "?";
            this.buildHelpBtn.UseVisualStyleBackColor = true;
            this.buildHelpBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // build
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buildHelpBtn);
            this.Controls.Add(this.buildBackBtn);
            this.Controls.Add(this.buildBuildBtn);
            this.Controls.Add(this.buildPackagesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buildInstanceText);
            this.Controls.Add(this.buildWorldListCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "build";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.build_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox buildWorldListCombo;
        private System.Windows.Forms.TextBox buildInstanceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox buildPackagesListBox;
        private System.Windows.Forms.Button buildBuildBtn;
        private System.Windows.Forms.Button buildBackBtn;
        private System.Windows.Forms.Button buildHelpBtn;
    }
}