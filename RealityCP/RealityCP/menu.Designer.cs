namespace RealityCP
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuBuildBtn = new System.Windows.Forms.Button();
            this.menuVehiclesBtn = new System.Windows.Forms.Button();
            this.menuCleanupBtn = new System.Windows.Forms.Button();
            this.menuMessagesBtn = new System.Windows.Forms.Button();
            this.menuSetupBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuExitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBuildBtn
            // 
            this.menuBuildBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.menuBuildBtn.Location = new System.Drawing.Point(74, 83);
            this.menuBuildBtn.Name = "menuBuildBtn";
            this.menuBuildBtn.Size = new System.Drawing.Size(140, 60);
            this.menuBuildBtn.TabIndex = 0;
            this.menuBuildBtn.Text = "Build";
            this.menuBuildBtn.UseVisualStyleBackColor = true;
            this.menuBuildBtn.Click += new System.EventHandler(this.menuBuildBtn_Click);
            // 
            // menuVehiclesBtn
            // 
            this.menuVehiclesBtn.Location = new System.Drawing.Point(38, 149);
            this.menuVehiclesBtn.Name = "menuVehiclesBtn";
            this.menuVehiclesBtn.Size = new System.Drawing.Size(97, 23);
            this.menuVehiclesBtn.TabIndex = 1;
            this.menuVehiclesBtn.Text = "Vehicles/Items";
            this.menuVehiclesBtn.UseVisualStyleBackColor = true;
            this.menuVehiclesBtn.Click += new System.EventHandler(this.menuVehiclesBtn_Click);
            // 
            // menuCleanupBtn
            // 
            this.menuCleanupBtn.Location = new System.Drawing.Point(153, 149);
            this.menuCleanupBtn.Name = "menuCleanupBtn";
            this.menuCleanupBtn.Size = new System.Drawing.Size(97, 23);
            this.menuCleanupBtn.TabIndex = 2;
            this.menuCleanupBtn.Text = "Cleanup";
            this.menuCleanupBtn.UseVisualStyleBackColor = true;
            this.menuCleanupBtn.Click += new System.EventHandler(this.menuCleanupBtn_Click);
            // 
            // menuMessagesBtn
            // 
            this.menuMessagesBtn.Location = new System.Drawing.Point(38, 178);
            this.menuMessagesBtn.Name = "menuMessagesBtn";
            this.menuMessagesBtn.Size = new System.Drawing.Size(97, 23);
            this.menuMessagesBtn.TabIndex = 3;
            this.menuMessagesBtn.Text = "Messages";
            this.menuMessagesBtn.UseVisualStyleBackColor = true;
            this.menuMessagesBtn.Click += new System.EventHandler(this.menuMessagesBtn_Click);
            // 
            // menuSetupBtn
            // 
            this.menuSetupBtn.Location = new System.Drawing.Point(153, 178);
            this.menuSetupBtn.Name = "menuSetupBtn";
            this.menuSetupBtn.Size = new System.Drawing.Size(97, 23);
            this.menuSetupBtn.TabIndex = 4;
            this.menuSetupBtn.Text = "Setup / DB";
            this.menuSetupBtn.UseVisualStyleBackColor = true;
            this.menuSetupBtn.Click += new System.EventHandler(this.menuSetupBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reality Control Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "by gdscei";
            // 
            // menuExitBtn
            // 
            this.menuExitBtn.Location = new System.Drawing.Point(38, 226);
            this.menuExitBtn.Name = "menuExitBtn";
            this.menuExitBtn.Size = new System.Drawing.Size(212, 23);
            this.menuExitBtn.TabIndex = 7;
            this.menuExitBtn.Text = "Exit";
            this.menuExitBtn.UseVisualStyleBackColor = true;
            this.menuExitBtn.Click += new System.EventHandler(this.menuExitBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(88, 54);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(109, 23);
            this.helpBtn.TabIndex = 8;
            this.helpBtn.Text = "OMG I need Help!";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // menu
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.menuExitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuSetupBtn);
            this.Controls.Add(this.menuMessagesBtn);
            this.Controls.Add(this.menuCleanupBtn);
            this.Controls.Add(this.menuVehiclesBtn);
            this.Controls.Add(this.menuBuildBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBuildBtn;
        private System.Windows.Forms.Button menuVehiclesBtn;
        private System.Windows.Forms.Button menuCleanupBtn;
        private System.Windows.Forms.Button menuMessagesBtn;
        private System.Windows.Forms.Button menuSetupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menuExitBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}