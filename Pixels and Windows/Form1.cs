using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixels_and_Windows
{
    public partial class PixelLable : Form
    {
        public PixelLable()
        {
            InitializeComponent();
        }

        private void PixelLable_Load(object sender, EventArgs e)
        {
            int pixels = getPixels();
            PixelLabel.Text = "This window contains " + pixels + "pixels ";
        }

        private int getPixels()
        {
            int height = this.Size.Height;
            int width = this.Size.Width;
            int pixels = height * width;
            return pixels;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int pixel = getPixels();
            PixelLabel.Text = "After resizing, this window contains " + pixel + " pixels";
        }
    }
}
