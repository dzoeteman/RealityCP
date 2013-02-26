namespace RealityCP
{
    partial class message
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(message));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.messageListMessagesBtn = new System.Windows.Forms.Button();
            this.messageSearchText = new System.Windows.Forms.TextBox();
            this.messageAddMessageBtn = new System.Windows.Forms.Button();
            this.messageDeleteBtn = new System.Windows.Forms.Button();
            this.messageMessageIDtext = new System.Windows.Forms.TextBox();
            this.messageBackBtn = new System.Windows.Forms.Button();
            this.messageInstanceText = new System.Windows.Forms.TextBox();
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
            // messageListMessagesBtn
            // 
            this.messageListMessagesBtn.Location = new System.Drawing.Point(155, 70);
            this.messageListMessagesBtn.Name = "messageListMessagesBtn";
            this.messageListMessagesBtn.Size = new System.Drawing.Size(95, 23);
            this.messageListMessagesBtn.TabIndex = 9;
            this.messageListMessagesBtn.Text = "List Messages";
            this.messageListMessagesBtn.UseVisualStyleBackColor = true;
            this.messageListMessagesBtn.Click += new System.EventHandler(this.messageListMessagesBtn_Click);
            // 
            // messageSearchText
            // 
            this.messageSearchText.Location = new System.Drawing.Point(23, 72);
            this.messageSearchText.Name = "messageSearchText";
            this.messageSearchText.Size = new System.Drawing.Size(126, 20);
            this.messageSearchText.TabIndex = 11;
            this.messageSearchText.Text = "Search phrase (optional)";
            // 
            // messageAddMessageBtn
            // 
            this.messageAddMessageBtn.Location = new System.Drawing.Point(23, 113);
            this.messageAddMessageBtn.Name = "messageAddMessageBtn";
            this.messageAddMessageBtn.Size = new System.Drawing.Size(227, 23);
            this.messageAddMessageBtn.TabIndex = 12;
            this.messageAddMessageBtn.Text = "Add/Edit Message";
            this.messageAddMessageBtn.UseVisualStyleBackColor = true;
            this.messageAddMessageBtn.Click += new System.EventHandler(this.messageAddMessageBtn_Click);
            // 
            // messageDeleteBtn
            // 
            this.messageDeleteBtn.Location = new System.Drawing.Point(155, 169);
            this.messageDeleteBtn.Name = "messageDeleteBtn";
            this.messageDeleteBtn.Size = new System.Drawing.Size(95, 23);
            this.messageDeleteBtn.TabIndex = 14;
            this.messageDeleteBtn.Text = "Delete Message";
            this.messageDeleteBtn.UseVisualStyleBackColor = true;
            this.messageDeleteBtn.Click += new System.EventHandler(this.messageDeleteBtn_Click);
            // 
            // messageMessageIDtext
            // 
            this.messageMessageIDtext.Location = new System.Drawing.Point(23, 183);
            this.messageMessageIDtext.Name = "messageMessageIDtext";
            this.messageMessageIDtext.Size = new System.Drawing.Size(126, 20);
            this.messageMessageIDtext.TabIndex = 15;
            this.messageMessageIDtext.Text = "Message ID";
            // 
            // messageBackBtn
            // 
            this.messageBackBtn.Location = new System.Drawing.Point(23, 226);
            this.messageBackBtn.Name = "messageBackBtn";
            this.messageBackBtn.Size = new System.Drawing.Size(227, 23);
            this.messageBackBtn.TabIndex = 16;
            this.messageBackBtn.Text = "Back";
            this.messageBackBtn.UseVisualStyleBackColor = true;
            this.messageBackBtn.Click += new System.EventHandler(this.messageBackBtn_Click);
            // 
            // messageInstanceText
            // 
            this.messageInstanceText.Location = new System.Drawing.Point(23, 157);
            this.messageInstanceText.Name = "messageInstanceText";
            this.messageInstanceText.Size = new System.Drawing.Size(126, 20);
            this.messageInstanceText.TabIndex = 18;
            this.messageInstanceText.Text = "Instance";
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.messageInstanceText);
            this.Controls.Add(this.messageBackBtn);
            this.Controls.Add(this.messageMessageIDtext);
            this.Controls.Add(this.messageDeleteBtn);
            this.Controls.Add(this.messageAddMessageBtn);
            this.Controls.Add(this.messageSearchText);
            this.Controls.Add(this.messageListMessagesBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "message";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button messageListMessagesBtn;
        private System.Windows.Forms.TextBox messageSearchText;
        private System.Windows.Forms.Button messageAddMessageBtn;
        private System.Windows.Forms.Button messageDeleteBtn;
        private System.Windows.Forms.TextBox messageMessageIDtext;
        private System.Windows.Forms.Button messageBackBtn;
        private System.Windows.Forms.TextBox messageInstanceText;
    }
}