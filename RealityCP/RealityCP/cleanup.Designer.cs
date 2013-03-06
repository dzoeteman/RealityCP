namespace RealityCP
{
    partial class cleanup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cleanup));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cleanupBackBtn = new System.Windows.Forms.Button();
            this.cleanupInstanceText = new System.Windows.Forms.TextBox();
            this.cleanupItemText = new System.Windows.Forms.TextBox();
            this.cleanupDaysText = new System.Windows.Forms.TextBox();
            this.itemToCleanBox = new System.Windows.Forms.ComboBox();
            this.cleanITBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "by gdscei";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reality Control Panel";
            // 
            // cleanupBackBtn
            // 
            this.cleanupBackBtn.Location = new System.Drawing.Point(57, 226);
            this.cleanupBackBtn.Name = "cleanupBackBtn";
            this.cleanupBackBtn.Size = new System.Drawing.Size(180, 23);
            this.cleanupBackBtn.TabIndex = 16;
            this.cleanupBackBtn.Text = "Back";
            this.cleanupBackBtn.UseVisualStyleBackColor = true;
            this.cleanupBackBtn.Click += new System.EventHandler(this.cleanupBackBtn_Click);
            // 
            // cleanupInstanceText
            // 
            this.cleanupInstanceText.Location = new System.Drawing.Point(168, 96);
            this.cleanupInstanceText.Name = "cleanupInstanceText";
            this.cleanupInstanceText.Size = new System.Drawing.Size(47, 20);
            this.cleanupInstanceText.TabIndex = 17;
            // 
            // cleanupItemText
            // 
            this.cleanupItemText.Location = new System.Drawing.Point(12, 145);
            this.cleanupItemText.Name = "cleanupItemText";
            this.cleanupItemText.Size = new System.Drawing.Size(260, 20);
            this.cleanupItemText.TabIndex = 18;
            // 
            // cleanupDaysText
            // 
            this.cleanupDaysText.Location = new System.Drawing.Point(168, 118);
            this.cleanupDaysText.Name = "cleanupDaysText";
            this.cleanupDaysText.Size = new System.Drawing.Size(47, 20);
            this.cleanupDaysText.TabIndex = 19;
            // 
            // itemToCleanBox
            // 
            this.itemToCleanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemToCleanBox.FormattingEnabled = true;
            this.itemToCleanBox.Items.AddRange(new object[] {
            "all",
            "damaged",
            "bounds",
            "tents",
            "cleanitem",
            "cleandead",
            "cleanvehicle",
            "cleandeploy",
            "buildfiles"});
            this.itemToCleanBox.Location = new System.Drawing.Point(82, 66);
            this.itemToCleanBox.Name = "itemToCleanBox";
            this.itemToCleanBox.Size = new System.Drawing.Size(121, 21);
            this.itemToCleanBox.TabIndex = 22;
            this.itemToCleanBox.SelectedIndexChanged += new System.EventHandler(this.itemToCleanBox_SelectedIndexChanged);
            // 
            // cleanITBtn
            // 
            this.cleanITBtn.Location = new System.Drawing.Point(88, 171);
            this.cleanITBtn.Name = "cleanITBtn";
            this.cleanITBtn.Size = new System.Drawing.Size(108, 23);
            this.cleanITBtn.TabIndex = 23;
            this.cleanITBtn.Text = "Clean IT!";
            this.cleanITBtn.UseVisualStyleBackColor = true;
            this.cleanITBtn.Click += new System.EventHandler(this.cleanITBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Instance ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Days to Clean";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Items";
            // 
            // cleanup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cleanITBtn);
            this.Controls.Add(this.itemToCleanBox);
            this.Controls.Add(this.cleanupDaysText);
            this.Controls.Add(this.cleanupItemText);
            this.Controls.Add(this.cleanupInstanceText);
            this.Controls.Add(this.cleanupBackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cleanup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.cleanup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cleanupBackBtn;
        private System.Windows.Forms.TextBox cleanupInstanceText;
        private System.Windows.Forms.TextBox cleanupItemText;
        private System.Windows.Forms.TextBox cleanupDaysText;
        private System.Windows.Forms.ComboBox itemToCleanBox;
        private System.Windows.Forms.Button cleanITBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}