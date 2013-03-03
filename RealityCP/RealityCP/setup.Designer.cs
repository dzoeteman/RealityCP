namespace RealityCP
{
    partial class setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setup));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setupSetupPerlBtn = new System.Windows.Forms.Button();
            this.setupMyqlBtn = new System.Windows.Forms.Button();
            this.setupDatabaseBtn = new System.Windows.Forms.Button();
            this.setupBackBtn = new System.Windows.Forms.Button();
            this.setupUpdateBtn = new System.Windows.Forms.Button();
            this.updateBansbtn = new System.Windows.Forms.Button();
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
            // setupSetupPerlBtn
            // 
            this.setupSetupPerlBtn.Location = new System.Drawing.Point(81, 61);
            this.setupSetupPerlBtn.Name = "setupSetupPerlBtn";
            this.setupSetupPerlBtn.Size = new System.Drawing.Size(115, 23);
            this.setupSetupPerlBtn.TabIndex = 9;
            this.setupSetupPerlBtn.Text = "Set-up Perl";
            this.setupSetupPerlBtn.UseVisualStyleBackColor = true;
            this.setupSetupPerlBtn.Click += new System.EventHandler(this.setupSetupPerlBtn_Click);
            // 
            // setupMyqlBtn
            // 
            this.setupMyqlBtn.Location = new System.Drawing.Point(81, 90);
            this.setupMyqlBtn.Name = "setupMyqlBtn";
            this.setupMyqlBtn.Size = new System.Drawing.Size(115, 23);
            this.setupMyqlBtn.TabIndex = 10;
            this.setupMyqlBtn.Text = "MySQL details";
            this.setupMyqlBtn.UseVisualStyleBackColor = true;
            this.setupMyqlBtn.Click += new System.EventHandler(this.setupMyqlBtn_Click);
            // 
            // setupDatabaseBtn
            // 
            this.setupDatabaseBtn.Location = new System.Drawing.Point(81, 119);
            this.setupDatabaseBtn.Name = "setupDatabaseBtn";
            this.setupDatabaseBtn.Size = new System.Drawing.Size(115, 23);
            this.setupDatabaseBtn.TabIndex = 11;
            this.setupDatabaseBtn.Text = "Database";
            this.setupDatabaseBtn.UseVisualStyleBackColor = true;
            this.setupDatabaseBtn.Click += new System.EventHandler(this.setupDatabaseBtn_Click);
            // 
            // setupBackBtn
            // 
            this.setupBackBtn.Location = new System.Drawing.Point(12, 226);
            this.setupBackBtn.Name = "setupBackBtn";
            this.setupBackBtn.Size = new System.Drawing.Size(256, 23);
            this.setupBackBtn.TabIndex = 12;
            this.setupBackBtn.Text = "Back";
            this.setupBackBtn.UseVisualStyleBackColor = true;
            this.setupBackBtn.Click += new System.EventHandler(this.setupBackBtn_Click);
            // 
            // setupUpdateBtn
            // 
            this.setupUpdateBtn.Location = new System.Drawing.Point(81, 148);
            this.setupUpdateBtn.Name = "setupUpdateBtn";
            this.setupUpdateBtn.Size = new System.Drawing.Size(115, 23);
            this.setupUpdateBtn.TabIndex = 13;
            this.setupUpdateBtn.Text = "Update BE scripts";
            this.setupUpdateBtn.UseVisualStyleBackColor = true;
            this.setupUpdateBtn.Click += new System.EventHandler(this.setupUpdateBtn_Click);
            // 
            // updateBansbtn
            // 
            this.updateBansbtn.Location = new System.Drawing.Point(81, 176);
            this.updateBansbtn.Name = "updateBansbtn";
            this.updateBansbtn.Size = new System.Drawing.Size(115, 23);
            this.updateBansbtn.TabIndex = 14;
            this.updateBansbtn.Text = "Update Bans";
            this.updateBansbtn.UseVisualStyleBackColor = true;
            this.updateBansbtn.Click += new System.EventHandler(this.updateBansbtn_Click);
            // 
            // setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.updateBansbtn);
            this.Controls.Add(this.setupUpdateBtn);
            this.Controls.Add(this.setupBackBtn);
            this.Controls.Add(this.setupDatabaseBtn);
            this.Controls.Add(this.setupMyqlBtn);
            this.Controls.Add(this.setupSetupPerlBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setupSetupPerlBtn;
        private System.Windows.Forms.Button setupMyqlBtn;
        private System.Windows.Forms.Button setupDatabaseBtn;
        private System.Windows.Forms.Button setupBackBtn;
        private System.Windows.Forms.Button setupUpdateBtn;
        private System.Windows.Forms.Button updateBansbtn;
    }
}