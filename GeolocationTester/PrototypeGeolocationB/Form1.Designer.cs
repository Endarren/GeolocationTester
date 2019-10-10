namespace PrototypeGeolocationB
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.watcherStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.latitudeDisplay = new System.Windows.Forms.TextBox();
            this.longitudeDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.positionPanel = new System.Windows.Forms.Panel();
            this.unknownLabel = new System.Windows.Forms.Label();
            this.positionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Position";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // watcherStatusLabel
            // 
            this.watcherStatusLabel.AutoSize = true;
            this.watcherStatusLabel.Location = new System.Drawing.Point(65, 13);
            this.watcherStatusLabel.Name = "watcherStatusLabel";
            this.watcherStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.watcherStatusLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Latitude";
            // 
            // latitudeDisplay
            // 
            this.latitudeDisplay.Location = new System.Drawing.Point(1, 38);
            this.latitudeDisplay.Name = "latitudeDisplay";
            this.latitudeDisplay.ReadOnly = true;
            this.latitudeDisplay.Size = new System.Drawing.Size(137, 22);
            this.latitudeDisplay.TabIndex = 4;
            // 
            // longitudeDisplay
            // 
            this.longitudeDisplay.Location = new System.Drawing.Point(147, 38);
            this.longitudeDisplay.Name = "longitudeDisplay";
            this.longitudeDisplay.ReadOnly = true;
            this.longitudeDisplay.Size = new System.Drawing.Size(137, 22);
            this.longitudeDisplay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Longitude";
            // 
            // positionPanel
            // 
            this.positionPanel.Controls.Add(this.longitudeDisplay);
            this.positionPanel.Controls.Add(this.label3);
            this.positionPanel.Controls.Add(this.latitudeDisplay);
            this.positionPanel.Controls.Add(this.label2);
            this.positionPanel.Location = new System.Drawing.Point(3, 33);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(295, 75);
            this.positionPanel.TabIndex = 7;
            // 
            // unknownLabel
            // 
            this.unknownLabel.AutoSize = true;
            this.unknownLabel.Location = new System.Drawing.Point(109, 48);
            this.unknownLabel.Name = "unknownLabel";
            this.unknownLabel.Size = new System.Drawing.Size(66, 17);
            this.unknownLabel.TabIndex = 8;
            this.unknownLabel.Text = "Unknown";
            this.unknownLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.unknownLabel);
            this.Controls.Add(this.positionPanel);
            this.Controls.Add(this.watcherStatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "GeoLocation";
            this.positionPanel.ResumeLayout(false);
            this.positionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label watcherStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latitudeDisplay;
        private System.Windows.Forms.TextBox longitudeDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel positionPanel;
        private System.Windows.Forms.Label unknownLabel;
    }
}

