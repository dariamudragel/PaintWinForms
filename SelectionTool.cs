using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsGratedLabPart
{
    public class SelectionTool : Tools
    {
        private Point startPoint;
        private Rectangle selectionRectangle;
        private bool isSelecting;
        private ToolStripStatusLabel statusStrip;
        private Bitmap selectedBitmap;

        public SelectionTool(ToolStripStatusLabel statusStrip)
        {
            isSelecting = false;
            this.statusStrip = statusStrip;
        }

        public override void StartDrawing(PictureBox pictureBox1, MouseEventArgs e)
        {
            startPoint = e.Location;
            isSelecting = true;
        }

        public override void Draw(PictureBox pictureBox1, MouseEventArgs e)
        {
            if (isSelecting)
            {
                Point currentPoint = e.Location;
                selectionRectangle = new Rectangle(
                    Math.Min(startPoint.X, currentPoint.X),
                    Math.Min(startPoint.Y, currentPoint.Y),
                    Math.Abs(currentPoint.X - startPoint.X),
                    Math.Abs(currentPoint.Y - startPoint.Y));

                pictureBox1.Invalidate();
            }
                pictureBox1.Invalidate();
        }

        public override void EndDrawing(PictureBox pictureBox1, MouseEventArgs e)
        {
            isSelecting = false;
            pictureBox1.Invalidate();
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            if (isSelecting)
            {
                using (Pen dashedPen = new Pen(Color.Black))
                {
                    dashedPen.DashStyle = DashStyle.Dash;
                    e.Graphics.DrawRectangle(dashedPen, selectionRectangle);
                }
            }
            else if (!selectionRectangle.IsEmpty)
            {
                using (Pen solidPen = new Pen(Color.Blue))
                {
                    e.Graphics.DrawRectangle(solidPen, selectionRectangle);
                }
            }
        }

        public override void SelectAll(PictureBox pictureBox1)
        {
            selectionRectangle = new Rectangle(Point.Empty, pictureBox1.ClientSize);
            pictureBox1.Invalidate();
        }

        public override void UpdateStatusBar(ToolStripStatusLabel toolStripStatusLabel2)
        {
            if (!selectionRectangle.IsEmpty)
            {
                toolStripStatusLabel2.Text = $"S:({selectionRectangle.X}, {selectionRectangle.Y}), E: ({selectionRectangle.Right}, {selectionRectangle.Bottom}, Size:({selectionRectangle.Size.Width},{selectionRectangle.Size.Height}))";
            }
        }
        public override void InvertColors(DirectBitmap originalBitmap)
        {
            if (!selectionRectangle.IsEmpty)
            {
                for (int x = selectionRectangle.Left; x < selectionRectangle.Right; x++)
                {
                    for (int y = selectionRectangle.Top; y < selectionRectangle.Bottom; y++)
                    {
                        Color pixelColor = originalBitmap.GetPixel(x, y);
                        Color invertedColor = InvertColor(pixelColor);
                        originalBitmap.SetPixel(x, y, invertedColor);                       
                    }
                }
            }
            else
            
                base.InvertColors(originalBitmap);

        }

        public Color InvertColor(Color color)
        {
            Color invertedColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            return invertedColor;
        }

        public Bitmap GetSelectedBitmap()
        {
            return selectedBitmap;
        }
    }
}
