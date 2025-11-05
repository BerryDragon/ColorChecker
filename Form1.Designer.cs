namespace ColorChecker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button checkColorButton;
        private System.Windows.Forms.PictureBox zoomedAreaPictureBox;
        private System.Windows.Forms.Label colorHexLabel;
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


        private void InitializeComponent()
        {
            checkColorButton = new Button();
            zoomedAreaPictureBox = new PictureBox();
            colorHexLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)zoomedAreaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // checkColorButton
            // 
            checkColorButton.Location = new Point(14, 16);
            checkColorButton.Margin = new Padding(3, 4, 3, 4);
            checkColorButton.Name = "checkColorButton";
            checkColorButton.Size = new Size(137, 40);
            checkColorButton.TabIndex = 0;
            checkColorButton.Text = "Check the color!";
            checkColorButton.UseVisualStyleBackColor = true;
            checkColorButton.Click += CheckColorButton_Click;
            // 
            // zoomedAreaPictureBox
            // 
            zoomedAreaPictureBox.BorderStyle = BorderStyle.FixedSingle;
            zoomedAreaPictureBox.Location = new Point(14, 64);
            zoomedAreaPictureBox.Margin = new Padding(3, 4, 3, 4);
            zoomedAreaPictureBox.Name = "zoomedAreaPictureBox";
            zoomedAreaPictureBox.Size = new Size(228, 266);
            zoomedAreaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            zoomedAreaPictureBox.TabIndex = 1;
            zoomedAreaPictureBox.TabStop = false;
            // 
            // colorHexLabel
            // 
            colorHexLabel.AutoSize = true;
            colorHexLabel.Font = new Font("Segoe UI", 12F);
            colorHexLabel.Location = new Point(14, 344);
            colorHexLabel.Name = "colorHexLabel";
            colorHexLabel.Size = new Size(64, 28);
            colorHexLabel.TabIndex = 2;
            colorHexLabel.Text = "Color:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 382);
            Controls.Add(colorHexLabel);
            Controls.Add(zoomedAreaPictureBox);
            Controls.Add(checkColorButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Color Checker";
            ((System.ComponentModel.ISupportInitialize)zoomedAreaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}