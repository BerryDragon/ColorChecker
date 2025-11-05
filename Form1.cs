using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorChecker
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer updateTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            updateTimer = new System.Windows.Forms.Timer
            {
                Interval = 1 
            };
            updateTimer.Tick += UpdateTimer_Tick;
        }

        private void CheckColorButton_Click(object sender, EventArgs e)
        {
            updateTimer.Enabled = !updateTimer.Enabled;
            checkColorButton.Text = updateTimer.Enabled ? "Stop checking" : "Check the color!";
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateColorInfo();
        }

        private void UpdateColorInfo()
        {
            Point cursorPosition = Cursor.Position;
            using var screenCapture = new Bitmap(20, 20);
            using (var g = Graphics.FromImage(screenCapture))
            {
                g.CopyFromScreen(cursorPosition.X - 10, cursorPosition.Y - 10, 0, 0, screenCapture.Size);
            }

            zoomedAreaPictureBox.Image = new Bitmap(screenCapture, zoomedAreaPictureBox.Size);
            Color pixelColor = screenCapture.GetPixel(10, 10);

            string colorName = GetColorName(pixelColor);
            colorHexLabel.Text = $"Color: #{pixelColor.R:X2}{pixelColor.G:X2}{pixelColor.B:X2} ({colorName})";

        }

        private string GetColorName(Color color)
        {
            var colorMatches = new Dictionary<string, Color>
    {
        {"Red", Color.Red}, {"Green", Color.Green}, {"Blue", Color.Blue},
        {"Yellow", Color.Yellow}, {"Orange", Color.Orange}, {"Purple", Color.Purple},
        {"Pink", Color.Pink}, {"Brown", Color.Brown}, {"Gray", Color.Gray},
        {"White", Color.White}, {"Black", Color.Black}, {"Cyan", Color.Cyan},
        {"Magenta", Color.Magenta}, {"Lime", Color.Lime}, {"Teal", Color.Teal},
        {"Navy", Color.Navy}, {"Maroon", Color.Maroon}, {"Olive", Color.Olive}
    };

            string closestColor = "Unknown";
            double minDistance = double.MaxValue;

            foreach (var namedColor in colorMatches)
            {
                double distance = Math.Sqrt(
                    Math.Pow(color.R - namedColor.Value.R, 2) +
                    Math.Pow(color.G - namedColor.Value.G, 2) +
                    Math.Pow(color.B - namedColor.Value.B, 2)
                );

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestColor = namedColor.Key;
                }
            }

            return closestColor;
        }
    }
    
}