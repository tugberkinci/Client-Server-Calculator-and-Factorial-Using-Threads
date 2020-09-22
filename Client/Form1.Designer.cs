namespace Client
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
            this.label = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RecivedLabel = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label.Location = new System.Drawing.Point(34, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 24);
            this.label.TabIndex = 0;
            this.label.Text = "CLIENT";
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(12, 59);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(20, 13);
            this.IpLabel.TabIndex = 1;
            this.IpLabel.Text = "IP:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(149, 59);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(40, 13);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "PORT:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(38, 98);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(257, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IpTextBox
            // 
            this.IpTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IpTextBox.Location = new System.Drawing.Point(38, 56);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpTextBox.TabIndex = 4;
            // 
            // PortTextBox
            // 
            this.PortTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PortTextBox.Location = new System.Drawing.Point(195, 56);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 5;
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(38, 180);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(100, 20);
            this.SendTextBox.TabIndex = 6;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(195, 177);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 23);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "CALCULATE";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectLabel
            // 
            this.ConnectLabel.AutoSize = true;
            this.ConnectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConnectLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConnectLabel.Location = new System.Drawing.Point(38, 137);
            this.ConnectLabel.Name = "ConnectLabel";
            this.ConnectLabel.Size = new System.Drawing.Size(0, 13);
            this.ConnectLabel.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // RecivedLabel
            // 
            this.RecivedLabel.AutoSize = true;
            this.RecivedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RecivedLabel.ForeColor = System.Drawing.Color.Red;
            this.RecivedLabel.Location = new System.Drawing.Point(191, 272);
            this.RecivedLabel.Name = "RecivedLabel";
            this.RecivedLabel.Size = new System.Drawing.Size(0, 24);
            this.RecivedLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "RESULT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(35, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "For Fibonacci: xf eg:2f";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(35, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "For Factorial: x! eg:2!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecivedLabel);
            this.Controls.Add(this.ConnectLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label ConnectLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label RecivedLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

