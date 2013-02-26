namespace RealityCP
{
    partial class dbsetup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importSchemaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dbsetupBackBtn = new System.Windows.Forms.Button();
            this.importSchemaList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removeInstanceText = new System.Windows.Forms.TextBox();
            this.removeInstanceBtn = new System.Windows.Forms.Button();
            this.addInstanceBtn = new System.Windows.Forms.Button();
            this.migrateFromBlissBtn = new System.Windows.Forms.Button();
            this.addInstanceList = new System.Windows.Forms.ComboBox();
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
            // importSchemaBtn
            // 
            this.importSchemaBtn.Location = new System.Drawing.Point(197, 86);
            this.importSchemaBtn.Name = "importSchemaBtn";
            this.importSchemaBtn.Size = new System.Drawing.Size(75, 23);
            this.importSchemaBtn.TabIndex = 9;
            this.importSchemaBtn.Text = "Go";
            this.importSchemaBtn.UseVisualStyleBackColor = true;
            this.importSchemaBtn.Click += new System.EventHandler(this.importSchemaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Import scheme";
            // 
            // dbsetupBackBtn
            // 
            this.dbsetupBackBtn.Location = new System.Drawing.Point(12, 226);
            this.dbsetupBackBtn.Name = "dbsetupBackBtn";
            this.dbsetupBackBtn.Size = new System.Drawing.Size(256, 23);
            this.dbsetupBackBtn.TabIndex = 13;
            this.dbsetupBackBtn.Text = "Back";
            this.dbsetupBackBtn.UseVisualStyleBackColor = true;
            this.dbsetupBackBtn.Click += new System.EventHandler(this.dbsetupBackBtn_Click);
            // 
            // importSchemaList
            // 
            this.importSchemaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.importSchemaList.FormattingEnabled = true;
            this.importSchemaList.Items.AddRange(new object[] {
            "Reality Main (req.)",
            "Buildings",
            "Messaging",
            "Custom Inventory",
            "DayZ+",
            "Thirsk",
            "Thirsk Winter",
            "Namalsk",
            "Oring"});
            this.importSchemaList.Location = new System.Drawing.Point(91, 86);
            this.importSchemaList.Name = "importSchemaList";
            this.importSchemaList.Size = new System.Drawing.Size(100, 21);
            this.importSchemaList.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add Instance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Remove Instance";
            // 
            // removeInstanceText
            // 
            this.removeInstanceText.Location = new System.Drawing.Point(91, 139);
            this.removeInstanceText.Name = "removeInstanceText";
            this.removeInstanceText.Size = new System.Drawing.Size(100, 20);
            this.removeInstanceText.TabIndex = 19;
            // 
            // removeInstanceBtn
            // 
            this.removeInstanceBtn.Location = new System.Drawing.Point(197, 137);
            this.removeInstanceBtn.Name = "removeInstanceBtn";
            this.removeInstanceBtn.Size = new System.Drawing.Size(75, 23);
            this.removeInstanceBtn.TabIndex = 21;
            this.removeInstanceBtn.Text = "Go";
            this.removeInstanceBtn.UseVisualStyleBackColor = true;
            this.removeInstanceBtn.Click += new System.EventHandler(this.removeInstanceBtn_Click);
            // 
            // addInstanceBtn
            // 
            this.addInstanceBtn.Location = new System.Drawing.Point(197, 111);
            this.addInstanceBtn.Name = "addInstanceBtn";
            this.addInstanceBtn.Size = new System.Drawing.Size(75, 23);
            this.addInstanceBtn.TabIndex = 22;
            this.addInstanceBtn.Text = "Go";
            this.addInstanceBtn.UseVisualStyleBackColor = true;
            this.addInstanceBtn.Click += new System.EventHandler(this.addInstanceBtn_Click);
            // 
            // migrateFromBlissBtn
            // 
            this.migrateFromBlissBtn.Location = new System.Drawing.Point(87, 166);
            this.migrateFromBlissBtn.Name = "migrateFromBlissBtn";
            this.migrateFromBlissBtn.Size = new System.Drawing.Size(185, 23);
            this.migrateFromBlissBtn.TabIndex = 23;
            this.migrateFromBlissBtn.Text = "Migrate from Bliss";
            this.migrateFromBlissBtn.UseVisualStyleBackColor = true;
            this.migrateFromBlissBtn.Click += new System.EventHandler(this.migrateFromBlissBtn_Click);
            // 
            // addInstanceList
            // 
            this.addInstanceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addInstanceList.FormattingEnabled = true;
            this.addInstanceList.Items.AddRange(new object[] {
            "Chernarus",
            "Utes",
            "Thirsk",
            "Thirsk Winter",
            "Celle",
            "Lingor (Skaro)",
            "Oring",
            "Namalsk",
            "DayZ+"});
            this.addInstanceList.Location = new System.Drawing.Point(91, 113);
            this.addInstanceList.Name = "addInstanceList";
            this.addInstanceList.Size = new System.Drawing.Size(100, 21);
            this.addInstanceList.TabIndex = 24;
            // 
            // dbsetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addInstanceList);
            this.Controls.Add(this.migrateFromBlissBtn);
            this.Controls.Add(this.addInstanceBtn);
            this.Controls.Add(this.removeInstanceBtn);
            this.Controls.Add(this.removeInstanceText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.importSchemaList);
            this.Controls.Add(this.dbsetupBackBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.importSchemaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dbsetup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.dbsetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importSchemaBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dbsetupBackBtn;
        private System.Windows.Forms.ComboBox importSchemaList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox removeInstanceText;
        private System.Windows.Forms.Button removeInstanceBtn;
        private System.Windows.Forms.Button addInstanceBtn;
        private System.Windows.Forms.Button migrateFromBlissBtn;
        private System.Windows.Forms.ComboBox addInstanceList;
    }
}