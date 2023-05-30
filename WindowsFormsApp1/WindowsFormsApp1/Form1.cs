using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Bitmap originalImage;
        private Bitmap smoothedImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                originalPictureBox.Image = originalImage;
                smoothedImage = new Bitmap(originalImage);
                smoothedPictureBox.Image = smoothedImage;
            }
        }

        private void smoothedPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void smoothButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please open an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maskSize = (int)maskSizeNumericUpDown.Value;
            int[,] mask = new int[maskSize, maskSize];

            for (int i = 0; i < maskSize; i++)
            {
                for (int j = 0; j < maskSize; j++)
                {
                    mask[i, j] = 1;
                }
            }

            smoothedImage = ApplyMask(originalImage, mask);
            smoothedPictureBox.Image = smoothedImage;
        }

        private Bitmap ApplyMask(Bitmap image, int[,] mask)
        {
            int maskSize = mask.GetLength(0);
            int maskOffset = maskSize / 2;
            Bitmap result = new Bitmap(image);

            for (int i = maskOffset; i < image.Width - maskOffset; i++)
            {
                for (int j = maskOffset; j < image.Height - maskOffset; j++)
                {
                    int redSum = 0;
                    int greenSum = 0;
                    int blueSum = 0;

                    for (int x = 0; x < maskSize; x++)
                    {
                        for (int y = 0; y < maskSize; y++)
                        {
                            Color pixelColor = image.GetPixel(i + x - maskOffset, j + y - maskOffset);
                            redSum += pixelColor.R * mask[x, y];
                            greenSum += pixelColor.G * mask[x, y];
                            blueSum += pixelColor.B * mask[x, y];
                        }
                    }

                    Color newColor = Color.FromArgb(
                        Math.Min(255, redSum / maskSize / maskSize),
                        Math.Min(255, greenSum / maskSize / maskSize),
                        Math.Min(255, blueSum / maskSize / maskSize)
                    );

                    result.SetPixel(i, j, newColor);
                }
            }

            return result;
        }
    }
}
