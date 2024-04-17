using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGratedLabPart
{
    public class PenTool : Tools
    {
        private bool isPainting = false;
        private Point previousPoint;
        private Pen pen;
        private float zoomFactor = 1.0f; 

        public PenTool(Color color)
        {
            pen = new Pen(color, 1);
        }
        public override void Draw(PictureBox pictureBox1, MouseEventArgs e)
        {
            if (isPainting && pictureBox1.Image != null)
            {
                using (Graphics graphics = Graphics.FromImage(pictureBox1.Image))
                {
                    PointF adjustedPreviousPoint = new PointF(previousPoint.X / zoomFactor, previousPoint.Y / zoomFactor);
                    PointF adjustedCurrentPoint = new PointF(e.Location.X / zoomFactor, e.Location.Y / zoomFactor);
                    graphics.DrawLine(pen, adjustedPreviousPoint, adjustedCurrentPoint);
                    pictureBox1.Invalidate();
                    previousPoint = e.Location;
                }
            }
        }

        public override void EndDrawing(PictureBox pictureBox1, MouseEventArgs e)
        {
            isPainting = false;
        }


        public override void Paint(object sender, PaintEventArgs e)
        {

        }

        public override void SelectAll(PictureBox pictureBox1)
        {

        }

        public override void StartDrawing(PictureBox pictureBox1, MouseEventArgs e)
        {
            isPainting = true;
            previousPoint = e.Location;
        }

        public override void UpdateStatusBar(ToolStripStatusLabel toolStripStatusLabel2)
        {
        }

        public void UpdateZoomFactor(float factor)
        {
            zoomFactor = factor;
        }
    }
}
