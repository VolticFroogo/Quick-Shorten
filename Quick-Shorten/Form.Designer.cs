namespace Quick_Shorten
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.LongURLTextBox = new System.Windows.Forms.TextBox();
            this.LongURLLabel = new System.Windows.Forms.Label();
            this.ShortenButton = new System.Windows.Forms.Button();
            this.ShortURLLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LongURLTextBox
            // 
            this.LongURLTextBox.Location = new System.Drawing.Point(15, 25);
            this.LongURLTextBox.Name = "LongURLTextBox";
            this.LongURLTextBox.Size = new System.Drawing.Size(260, 20);
            this.LongURLTextBox.TabIndex = 0;
            // 
            // LongURLLabel
            // 
            this.LongURLLabel.AutoSize = true;
            this.LongURLLabel.Location = new System.Drawing.Point(12, 9);
            this.LongURLLabel.Name = "LongURLLabel";
            this.LongURLLabel.Size = new System.Drawing.Size(56, 13);
            this.LongURLLabel.TabIndex = 1;
            this.LongURLLabel.Text = "Long URL";
            // 
            // ShortenButton
            // 
            this.ShortenButton.Location = new System.Drawing.Point(15, 51);
            this.ShortenButton.Name = "ShortenButton";
            this.ShortenButton.Size = new System.Drawing.Size(75, 23);
            this.ShortenButton.TabIndex = 2;
            this.ShortenButton.Text = "Shorten";
            this.ShortenButton.UseVisualStyleBackColor = true;
            this.ShortenButton.Click += new System.EventHandler(this.ShortenButton_Click);
            // 
            // ShortURLLabel
            // 
            this.ShortURLLabel.AutoSize = true;
            this.ShortURLLabel.Location = new System.Drawing.Point(12, 102);
            this.ShortURLLabel.Name = "ShortURLLabel";
            this.ShortURLLabel.Size = new System.Drawing.Size(0, 13);
            this.ShortURLLabel.TabIndex = 3;
            this.ShortURLLabel.TabStop = true;
            this.ShortURLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShortURLLabel_LinkClicked);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.ShortURLLabel);
            this.Controls.Add(this.ShortenButton);
            this.Controls.Add(this.LongURLLabel);
            this.Controls.Add(this.LongURLTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 172);
            this.MinimumSize = new System.Drawing.Size(300, 172);
            this.Name = "Form";
            this.Text = "Quick Shorten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LongURLTextBox;
        private System.Windows.Forms.Label LongURLLabel;
        private System.Windows.Forms.Button ShortenButton;
        private System.Windows.Forms.LinkLabel ShortURLLabel;
    }
}

