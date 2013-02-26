namespace RealityCP
{
    partial class msgae
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgae));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msgaeMessageIDText = new System.Windows.Forms.TextBox();
            this.msgaeInstanceText = new System.Windows.Forms.TextBox();
            this.msgaeStartText = new System.Windows.Forms.TextBox();
            this.msgaeLoopText = new System.Windows.Forms.TextBox();
            this.msgaeMessageText = new System.Windows.Forms.TextBox();
            this.msgaeAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.msgaeEditBtn = new System.Windows.Forms.Button();
            this.msgaeCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "by gdscei";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reality Control Panel";
            // 
            // msgaeMessageIDText
            // 
            this.msgaeMessageIDText.Location = new System.Drawing.Point(126, 73);
            this.msgaeMessageIDText.Name = "msgaeMessageIDText";
            this.msgaeMessageIDText.Size = new System.Drawing.Size(100, 20);
            this.msgaeMessageIDText.TabIndex = 11;
            // 
            // msgaeInstanceText
            // 
            this.msgaeInstanceText.Location = new System.Drawing.Point(126, 99);
            this.msgaeInstanceText.Name = "msgaeInstanceText";
            this.msgaeInstanceText.Size = new System.Drawing.Size(100, 20);
            this.msgaeInstanceText.TabIndex = 12;
            // 
            // msgaeStartText
            // 
            this.msgaeStartText.Location = new System.Drawing.Point(126, 125);
            this.msgaeStartText.Name = "msgaeStartText";
            this.msgaeStartText.Size = new System.Drawing.Size(100, 20);
            this.msgaeStartText.TabIndex = 13;
            // 
            // msgaeLoopText
            // 
            this.msgaeLoopText.Location = new System.Drawing.Point(126, 151);
            this.msgaeLoopText.Name = "msgaeLoopText";
            this.msgaeLoopText.Size = new System.Drawing.Size(100, 20);
            this.msgaeLoopText.TabIndex = 14;
            // 
            // msgaeMessageText
            // 
            this.msgaeMessageText.Location = new System.Drawing.Point(126, 177);
            this.msgaeMessageText.Name = "msgaeMessageText";
            this.msgaeMessageText.Size = new System.Drawing.Size(100, 20);
            this.msgaeMessageText.TabIndex = 15;
            // 
            // msgaeAddBtn
            // 
            this.msgaeAddBtn.Location = new System.Drawing.Point(20, 226);
            this.msgaeAddBtn.Name = "msgaeAddBtn";
            this.msgaeAddBtn.Size = new System.Drawing.Size(75, 23);
            this.msgaeAddBtn.TabIndex = 16;
            this.msgaeAddBtn.Text = "Add";
            this.msgaeAddBtn.UseVisualStyleBackColor = true;
            this.msgaeAddBtn.Click += new System.EventHandler(this.msgaeAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Instance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Start Delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Loop Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Message ID (if edit)";
            // 
            // msgaeEditBtn
            // 
            this.msgaeEditBtn.Location = new System.Drawing.Point(101, 226);
            this.msgaeEditBtn.Name = "msgaeEditBtn";
            this.msgaeEditBtn.Size = new System.Drawing.Size(75, 23);
            this.msgaeEditBtn.TabIndex = 23;
            this.msgaeEditBtn.Text = "Edit";
            this.msgaeEditBtn.UseVisualStyleBackColor = true;
            this.msgaeEditBtn.Click += new System.EventHandler(this.msgaeEditBtn_Click);
            // 
            // msgaeCloseBtn
            // 
            this.msgaeCloseBtn.Location = new System.Drawing.Point(182, 226);
            this.msgaeCloseBtn.Name = "msgaeCloseBtn";
            this.msgaeCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.msgaeCloseBtn.TabIndex = 24;
            this.msgaeCloseBtn.Text = "Close";
            this.msgaeCloseBtn.UseVisualStyleBackColor = true;
            this.msgaeCloseBtn.Click += new System.EventHandler(this.msgaeCloseBtn_Click);
            // 
            // msgae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.msgaeCloseBtn);
            this.Controls.Add(this.msgaeEditBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msgaeAddBtn);
            this.Controls.Add(this.msgaeMessageText);
            this.Controls.Add(this.msgaeLoopText);
            this.Controls.Add(this.msgaeStartText);
            this.Controls.Add(this.msgaeInstanceText);
            this.Controls.Add(this.msgaeMessageIDText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "msgae";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.msgae_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgaeMessageIDText;
        private System.Windows.Forms.TextBox msgaeInstanceText;
        private System.Windows.Forms.TextBox msgaeStartText;
        private System.Windows.Forms.TextBox msgaeLoopText;
        private System.Windows.Forms.TextBox msgaeMessageText;
        private System.Windows.Forms.Button msgaeAddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button msgaeEditBtn;
        private System.Windows.Forms.Button msgaeCloseBtn;
    }
}