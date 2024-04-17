using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGratedLabPart
{
    public abstract class Tools
    {
        public abstract void StartDrawing(PictureBox pictureBox1, MouseEventArgs e);
        public abstract void EndDrawing(PictureBox pictureBox1, MouseEventArgs e);
        public abstract void Draw(PictureBox pictureBox1, MouseEventArgs e);
        public abstract void Paint(object sender, PaintEventArgs e);
        public abstract void SelectAll(PictureBox pictureBox1);
        public abstract void UpdateStatusBar(ToolStripStatusLabel toolStripStatusLabel2);
        public virtual void InvertColors(DirectBitmap originalBitmap)
        {
            for (int x = 0; x < originalBitmap.Width; x++)
            {
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color pixelColor = originalBitmap.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    originalBitmap.SetPixel(x, y, invertedColor);
                }
            }
        }
       
    }
}
