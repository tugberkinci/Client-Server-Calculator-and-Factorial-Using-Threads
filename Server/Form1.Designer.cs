namespace Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.İpLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerSatartButton = new System.Windows.Forms.Button();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.RecivedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // İpLabel
            // 
            this.İpLabel.AutoSize = true;
            this.İpLabel.Location = new System.Drawing.Point(42, 74);
            this.İpLabel.Name = "İpLabel";
            this.İpLabel.Size = new System.Drawing.Size(20, 13);
            this.İpLabel.TabIndex = 1;
            this.İpLabel.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT:";
            // 
            // ServerSatartButton
            // 
            this.ServerSatartButton.Location = new System.Drawing.Point(42, 157);
            this.ServerSatartButton.Name = "ServerSatartButton";
            this.ServerSatartButton.Size = new System.Drawing.Size(141, 23);
            this.ServerSatartButton.TabIndex = 3;
            this.ServerSatartButton.Text = "START";
            this.ServerSatartButton.UseVisualStyleBackColor = true;
            this.ServerSatartButton.Click += new System.EventHandler(this.ServerSatartButton_Click);
            // 
            // IpTextBox
            // 
            this.IpTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IpTextBox.Location = new System.Drawing.Point(83, 67);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpTextBox.TabIndex = 4;
            // 
            // PortTextBox
            // 
            this.PortTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PortTextBox.Location = new System.Drawing.Point(83, 110);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // RecivedLabel
            // 
            this.RecivedLabel.AutoSize = true;
            this.RecivedLabel.Location = new System.Drawing.Point(108, 206);
            this.RecivedLabel.Name = "RecivedLabel";
            this.RecivedLabel.Size = new System.Drawing.Size(0, 13);
            this.RecivedLabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "REQUEST:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecivedLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.ServerSatartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.İpLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label İpLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ServerSatartButton;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label RecivedLabel;
        private System.Windows.Forms.Label label2;
    }
}

