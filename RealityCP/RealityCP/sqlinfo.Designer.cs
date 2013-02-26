namespace RealityCP
{
    partial class sqlinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sqlinfo));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlinfoIPText = new System.Windows.Forms.TextBox();
            this.sqlinfoPortText = new System.Windows.Forms.TextBox();
            this.sqlinfoUserText = new System.Windows.Forms.TextBox();
            this.sqlinfoPasswordText = new System.Windows.Forms.TextBox();
            this.sqlinfoDatabaseText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlinfoContinueBtn = new System.Windows.Forms.Button();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "To use the Control Panel, please\r\n enter your MySQL details.";
            // 
            // sqlinfoIPText
            // 
            this.sqlinfoIPText.Location = new System.Drawing.Point(114, 102);
            this.sqlinfoIPText.Name = "sqlinfoIPText";
            this.sqlinfoIPText.Size = new System.Drawing.Size(100, 20);
            this.sqlinfoIPText.TabIndex = 10;
            this.sqlinfoIPText.Text = "127.0.0.1";
            this.sqlinfoIPText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sqlinfoIPText_KeyDown);
            // 
            // sqlinfoPortText
            // 
            this.sqlinfoPortText.Location = new System.Drawing.Point(114, 128);
            this.sqlinfoPortText.Name = "sqlinfoPortText";
            this.sqlinfoPortText.Size = new System.Drawing.Size(100, 20);
            this.sqlinfoPortText.TabIndex = 11;
            this.sqlinfoPortText.Text = "3306";
            // 
            // sqlinfoUserText
            // 
            this.sqlinfoUserText.Location = new System.Drawing.Point(114, 154);
            this.sqlinfoUserText.Name = "sqlinfoUserText";
            this.sqlinfoUserText.Size = new System.Drawing.Size(100, 20);
            this.sqlinfoUserText.TabIndex = 12;
            this.sqlinfoUserText.Text = "root";
            // 
            // sqlinfoPasswordText
            // 
            this.sqlinfoPasswordText.Location = new System.Drawing.Point(114, 180);
            this.sqlinfoPasswordText.Name = "sqlinfoPasswordText";
            this.sqlinfoPasswordText.PasswordChar = '*';
            this.sqlinfoPasswordText.Size = new System.Drawing.Size(100, 20);
            this.sqlinfoPasswordText.TabIndex = 13;
            // 
            // sqlinfoDatabaseText
            // 
            this.sqlinfoDatabaseText.Location = new System.Drawing.Point(114, 206);
            this.sqlinfoDatabaseText.Name = "sqlinfoDatabaseText";
            this.sqlinfoDatabaseText.Size = new System.Drawing.Size(100, 20);
            this.sqlinfoDatabaseText.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Database";
            // 
            // sqlinfoContinueBtn
            // 
            this.sqlinfoContinueBtn.Location = new System.Drawing.Point(114, 232);
            this.sqlinfoContinueBtn.Name = "sqlinfoContinueBtn";
            this.sqlinfoContinueBtn.Size = new System.Drawing.Size(75, 23);
            this.sqlinfoContinueBtn.TabIndex = 20;
            this.sqlinfoContinueBtn.Text = "Continue";
            this.sqlinfoContinueBtn.UseVisualStyleBackColor = true;
            this.sqlinfoContinueBtn.Click += new System.EventHandler(this.sqlinfoContinueBtn_Click);
            // 
            // sqlinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sqlinfoContinueBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sqlinfoDatabaseText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sqlinfoPortText);
            this.Controls.Add(this.sqlinfoIPText);
            this.Controls.Add(this.sqlinfoUserText);
            this.Controls.Add(this.sqlinfoPasswordText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sqlinfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.sqlinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sqlinfoIPText;
        private System.Windows.Forms.TextBox sqlinfoPortText;
        private System.Windows.Forms.TextBox sqlinfoUserText;
        private System.Windows.Forms.TextBox sqlinfoPasswordText;
        private System.Windows.Forms.TextBox sqlinfoDatabaseText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sqlinfoContinueBtn;

    }
}

