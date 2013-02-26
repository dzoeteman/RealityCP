namespace RealityCP
{
    partial class vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicles));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vehiclesSpawnVehiclesBtn = new System.Windows.Forms.Button();
            this.vehiclesItemBtn = new System.Windows.Forms.Button();
            this.vehiclesBackbtn = new System.Windows.Forms.Button();
            this.vehiclesInstanceText = new System.Windows.Forms.TextBox();
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
            // vehiclesSpawnVehiclesBtn
            // 
            this.vehiclesSpawnVehiclesBtn.Location = new System.Drawing.Point(38, 128);
            this.vehiclesSpawnVehiclesBtn.Name = "vehiclesSpawnVehiclesBtn";
            this.vehiclesSpawnVehiclesBtn.Size = new System.Drawing.Size(96, 23);
            this.vehiclesSpawnVehiclesBtn.TabIndex = 9;
            this.vehiclesSpawnVehiclesBtn.Text = "Spawn Vehicles";
            this.vehiclesSpawnVehiclesBtn.UseVisualStyleBackColor = true;
            this.vehiclesSpawnVehiclesBtn.Click += new System.EventHandler(this.vehiclesSpawnVehiclesBtn_Click);
            // 
            // vehiclesItemBtn
            // 
            this.vehiclesItemBtn.Location = new System.Drawing.Point(154, 128);
            this.vehiclesItemBtn.Name = "vehiclesItemBtn";
            this.vehiclesItemBtn.Size = new System.Drawing.Size(96, 23);
            this.vehiclesItemBtn.TabIndex = 10;
            this.vehiclesItemBtn.Text = "Item Distribution";
            this.vehiclesItemBtn.UseVisualStyleBackColor = true;
            this.vehiclesItemBtn.Click += new System.EventHandler(this.vehiclesItemBtn_Click);
            // 
            // vehiclesBackbtn
            // 
            this.vehiclesBackbtn.Location = new System.Drawing.Point(38, 226);
            this.vehiclesBackbtn.Name = "vehiclesBackbtn";
            this.vehiclesBackbtn.Size = new System.Drawing.Size(212, 23);
            this.vehiclesBackbtn.TabIndex = 11;
            this.vehiclesBackbtn.Text = "Back";
            this.vehiclesBackbtn.UseVisualStyleBackColor = true;
            this.vehiclesBackbtn.Click += new System.EventHandler(this.vehiclesBackbtn_Click);
            // 
            // vehiclesInstanceText
            // 
            this.vehiclesInstanceText.Location = new System.Drawing.Point(92, 91);
            this.vehiclesInstanceText.Name = "vehiclesInstanceText";
            this.vehiclesInstanceText.Size = new System.Drawing.Size(100, 20);
            this.vehiclesInstanceText.TabIndex = 12;
            this.vehiclesInstanceText.Text = "Instance";
            // 
            // vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.vehiclesInstanceText);
            this.Controls.Add(this.vehiclesBackbtn);
            this.Controls.Add(this.vehiclesItemBtn);
            this.Controls.Add(this.vehiclesSpawnVehiclesBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vehicles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Control Panel";
            this.Load += new System.EventHandler(this.vehicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vehiclesSpawnVehiclesBtn;
        private System.Windows.Forms.Button vehiclesItemBtn;
        private System.Windows.Forms.Button vehiclesBackbtn;
        private System.Windows.Forms.TextBox vehiclesInstanceText;
    }
}