using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Threads
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;
        public Form2()
        {
            InitializeComponent();
            threshold_trackBar.Minimum = 0;
            threshold_trackBar.Maximum = 255;
            threshold_trackBar.Value = 180;
        }

        private void threshold_trackBar_ValueChanged(object sender, EventArgs e)
        {
            threshold_label.Text = $"Threshold Value: {threshold_trackBar.Value}"; 
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JPG files (*.jpg)|*.jpg|All files (*,*)|*,*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;
                    originalImage = new Bitmap(imagePath);
                    original_pictureBox.Image = originalImage;
                    original_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please open an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a copy of the original image to apply filters
            Bitmap thresholdImage = new Bitmap(originalImage);
            Bitmap grayscaleImage = new Bitmap(originalImage);
            Bitmap negativeImage = new Bitmap(originalImage);
            Bitmap mirrorImage = new Bitmap(originalImage);

            // Apply filters using threads
            Thread thresholdThread = new Thread(() => ApplyThresholdFilter(thresholdImage));
            Thread grayscaleThread = new Thread(() => ApplyGrayscaleFilter(grayscaleImage));
            Thread negativeThread = new Thread(() => ApplyNegativeFilter(negativeImage));
            Thread mirrorThread = new Thread(() => ApplyMirrorFilter(mirrorImage));

            // Start threads
            thresholdThread.Start();
            grayscaleThread.Start();
            negativeThread.Start();
            mirrorThread.Start();

            // Wait for threads to complete
            thresholdThread.Join();
            grayscaleThread.Join();
            negativeThread.Join();
            mirrorThread.Join();

            // Display filtered images
            threshold_pictureBox.Image = thresholdImage;
            gray_scale_pictureBox.Image = grayscaleImage;
            negative_pictureBox.Image = negativeImage;
            mirror_pictureBox.Image = mirrorImage;
        }

        private void ApplyThresholdFilter(Bitmap image)
        {
            // Example threshold value
            int threshold = threshold_trackBar.Value;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int average = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    if (average < threshold)
                        image.SetPixel(x, y, Color.Black);
                    else
                        image.SetPixel(x, y, Color.White);
                }
            }
        }

        private void ApplyGrayscaleFilter(Bitmap image)
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int average = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    image.SetPixel(x, y, Color.FromArgb(average, average, average));
                }
            }
        }

        private void ApplyNegativeFilter(Bitmap image)
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);

                    image.SetPixel(x, y, invertedColor);
                }
            }
        }

        private void ApplyMirrorFilter(Bitmap image)
        {
            for (int x = 0; x < image.Width / 2; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color temp = image.GetPixel(x, y);
                    image.SetPixel(x, y, image.GetPixel(image.Width - 1 - x, y));
                    image.SetPixel(image.Width - 1 - x, y, temp);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            threshold_label.Text = $"Threshold Value: {threshold_trackBar.Value}"; // Wyświetlenie aktualnej wartości progowej
        }
    }
}
