using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsGratedLabPart
{
    public class LineTool : Tools
    {
        private PointF startPoint;
        private PointF endPoint;
        private bool isDrawing = false;
        private Bitmap bitmap;
        private float zoomFactor = 1.0f;
        private Color color;

        public LineTool(Color color)
        {
            this.color = color;
        }

        public override void StartDrawing(PictureBox pictureBox1, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                //startPoint = ScalePoint(e.Location);
                startPoint = e.Location;
                endPoint = e.Location;
            }
        }

        public override void Draw(PictureBox pictureBox1, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
               // endPoint = ScalePoint(e.Location);
                pictureBox1.Invalidate();
            }
        }

        public override void EndDrawing(PictureBox pictureBox1, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                isDrawing = false;
                if (bitmap == null)
                {
                    bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                }
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(color))
                    {
                        g.DrawLine(pen, startPoint, endPoint);
                    }
                }

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    using (Pen pen = new Pen(color))
                    {
                        g.DrawLine(pen, startPoint, endPoint);
                    }
                }

                pictureBox1.Invalidate();
            }
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                using (Pen pen = new Pen(color))
                {
                    e.Graphics.DrawLine(pen, startPoint, endPoint);
                }
            }
        }

        public void UpdateZoomFactor(float factor)
        {
            zoomFactor = factor;
        }
        //public void SetZoom(float zoomFactor)
        //{
        //    if (zoomFactor <= 0) throw new ArgumentException("Zoom must be positive");
        //    float oldZoom = this.zoomFactor;
        //    this.zoomFactor = zoomFactor / 100f;
        //}

        //public PointF ScalePoint(PointF point)
        //{
        //    zoomFactor = 0.9f;
        //    return new PointF((int)(point.X / zoomFactor), (int)(point.Y / zoomFactor));
        //}



        public override void SelectAll(PictureBox pictureBox1)
        {
        }

        public override void UpdateStatusBar(ToolStripStatusLabel toolStripStatusLabel2)
        {
        }
    }
}
