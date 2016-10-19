namespace Pixels_and_Windows
{
    partial class PixelLable
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
            this.PixelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PixelLabel
            // 
            this.PixelLabel.AutoSize = true;
            this.PixelLabel.Location = new System.Drawing.Point(0, 0);
            this.PixelLabel.Name = "PixelLabel";
            this.PixelLabel.Size = new System.Drawing.Size(88, 13);
            this.PixelLabel.TabIndex = 0;
            this.PixelLabel.Text = "Pixel in Winow = ";
            // 
            // PixelLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PixelLabel);
            this.Name = "PixelLable";
            this.Text = "Pixel in Window =";
            this.Load += new System.EventHandler(this.PixelLable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PixelLabel;
    }
}

