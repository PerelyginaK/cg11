
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.smoothedPictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.smoothButton = new System.Windows.Forms.Button();
            this.maskSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Location = new System.Drawing.Point(110, 165);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(271, 225);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // smoothedPictureBox
            // 
            this.smoothedPictureBox.Location = new System.Drawing.Point(406, 161);
            this.smoothedPictureBox.Name = "smoothedPictureBox";
            this.smoothedPictureBox.Size = new System.Drawing.Size(274, 228);
            this.smoothedPictureBox.TabIndex = 1;
            this.smoothedPictureBox.TabStop = false;
            this.smoothedPictureBox.Click += new System.EventHandler(this.smoothedPictureBox_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(187, 65);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(112, 57);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "button1";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // smoothButton
            // 
            this.smoothButton.Location = new System.Drawing.Point(445, 70);
            this.smoothButton.Name = "smoothButton";
            this.smoothButton.Size = new System.Drawing.Size(120, 51);
            this.smoothButton.TabIndex = 3;
            this.smoothButton.Text = "button1";
            this.smoothButton.UseVisualStyleBackColor = true;
            this.smoothButton.Click += new System.EventHandler(this.smoothButton_Click);
            // 
            // maskSizeNumericUpDown
            // 
            this.maskSizeNumericUpDown.Location = new System.Drawing.Point(619, 87);
            this.maskSizeNumericUpDown.Name = "maskSizeNumericUpDown";
            this.maskSizeNumericUpDown.Size = new System.Drawing.Size(81, 23);
            this.maskSizeNumericUpDown.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskSizeNumericUpDown);
            this.Controls.Add(this.smoothButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.smoothedPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox smoothedPictureBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button smoothButton;
        private System.Windows.Forms.NumericUpDown maskSizeNumericUpDown;
    }
}

