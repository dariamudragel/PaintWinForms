using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsGratedLabPart
{

    public partial class Form1 : Form
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics.drawimage?view=dotnet-plat-ext-8.0
        private bool isPainting = false;
        private Point previousPoint;
        private Graphics graphics;
        Pen pen;
        private bool wasClicked = true;
        private string saveFilePath;
        private bool isResizingLeft;
        private bool isResizingRight;
        private bool isResizingTop;
        private bool isResizingBottom;
        private int initialMouseY;
        private int initialMouseX;
        int deltaX;

        private int previousMouseX;
        private int previousMouseY;
        Tools tool;
        double zoomFactor = 1.1;

        private Bitmap drawingBitmap;
        private int initialWidth;
        private int initialHeight;

        private Color selectedColor = Color.Black;
        private const int MaxRecentFiles = 10;
        private List<string> recentFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();

            toolStripStatusLabel3.Text = $"{pictureBox1.Width} x {pictureBox1.Height} px";

            toolStripStatusLabel4.Text = "100.00%";
            pen = new Pen(Color.Black, 1);
            tool = new PenTool(Color.Black);
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics graphics = Graphics.FromImage(drawingBitmap)) { graphics.Clear(Color.White); }
            pictureBox1.Image = drawingBitmap;
            pictureBox1.Paint += pictureBox1_Paint;
            originalDrawingAreaSize = pictureBox1.Size;

            LoadRecentFiles();
            UpdateRecentFilesMenu();
        }

        private void AddRecentFile(string filePath)
        {
            try
            {
                recentFiles.Remove(filePath);
                recentFiles.Insert(0, filePath);
                recentFiles = recentFiles.Take(MaxRecentFiles).ToList();
                SaveRecentFiles();
                UpdateRecentFilesMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecentFilesMenu()
        {
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.toolstripdropdownitem.dropdownitems?view=windowsdesktop-8.0
            int startIdx = fileToolStripMenuItem.DropDownItems.IndexOf(toolStripSeparator2);
            int endIdx = fileToolStripMenuItem.DropDownItems.IndexOf(toolStripSeparator3);

            if (startIdx != -1 && endIdx != -1 && endIdx > startIdx)
            {
                for (int i = endIdx - 1; i > startIdx; i--)
                {
                    fileToolStripMenuItem.DropDownItems.RemoveAt(i);
                }
            }

            foreach (string filePath in recentFiles)
            {
                string fileName = Path.GetFileName(filePath);
                ToolStripMenuItem menuItem = new ToolStripMenuItem($"| {fileName} |");
                menuItem.Tag = filePath;
                menuItem.Click += RecentFileMenuItem_Click;
                fileToolStripMenuItem.DropDownItems.Insert(startIdx + 1, menuItem);
            }
        }

        private void SaveRecentFiles()
        {
            string iniFilePath = "recent_files.ini";
            File.WriteAllLines(iniFilePath, recentFiles);
        }

        private void LoadRecentFiles()
        {
            string iniFilePath = "recent_files.ini";
            if (File.Exists(iniFilePath))
            {
                recentFiles = File.ReadAllLines(iniFilePath).ToList();
            }
        }

        private void RecentFileMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string filePath = menuItem.Tag.ToString();
            OpenFile(filePath);
        }
        private void OpenFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    drawingBitmap = new Bitmap(filePath);
                    drawingBitmap = new Bitmap(drawingBitmap, new Size(pictureBox1.Width, pictureBox1.Height));
                    pictureBox1.Image = drawingBitmap;
                    graphics = Graphics.FromImage(drawingBitmap);
                    originalDrawingAreaSize = new Size(panel2.Width, panel2.Height);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tool.StartDrawing(pictureBox1, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tool.EndDrawing(pictureBox1, e);
            tool.UpdateStatusBar(toolStripStatusLabel2);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {

                    ////ResizeDrawingArea(form2.PictureBoxSize, form2.PictureBoxBackColor);
                    //Bitmap oldBitmap = (Bitmap)pictureBox1.Image.Clone();
                    //pictureBox1.Size = form2.PictureBoxSize;
                    //pictureBox1.BackColor = form2.PictureBoxBackColor;
                    //panel2.Size = form2.PictureBoxSize;;
                    //panel2.BackColor = form2.PictureBoxBackColor;
                    //drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    //pictureBox1.Image = drawingBitmap;
                    //pictureBox1.Paint += pictureBox1_Paint;
                    //originalDrawingAreaSize = new Size(panel2.Width, panel2.Height);
                    //tool.SelectAll(pictureBox1);

                    //toolStripStatusLabel3.Text = $"{form2.PictureBoxSize.Width} x {form2.PictureBoxSize.Height} px";
                    Bitmap oldBitmap = (Bitmap)pictureBox1.Image.Clone();
                    pictureBox1.Size = form2.PictureBoxSize;
                    pictureBox1.BackColor = form2.PictureBoxBackColor;
                    panel2.Size = form2.PictureBoxSize; ;
                    panel2.BackColor = form2.PictureBoxBackColor;
                    drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = drawingBitmap;

                    // Select all content of pictureBox1
                    tool.SelectAll(pictureBox1);

                    pictureBox1.Paint += pictureBox1_Paint;
                    originalDrawingAreaSize = new Size(panel2.Width, panel2.Height);
                    toolStripStatusLabel3.Text = $"{form2.PictureBoxSize.Width} x {form2.PictureBoxSize.Height} px";
                }
            }
        }
        private void ResizeDrawingArea(Size newSize, Color newBackColor)
        {
            Bitmap oldBitmap = (Bitmap)pictureBox1.Image.Clone();
            pictureBox1.Size = newSize;
            pictureBox1.BackColor = newBackColor;
            panel2.Size = newSize;
            panel2.BackColor = newBackColor;
            drawingBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = drawingBitmap;
            pictureBox1.Paint += pictureBox1_Paint;
            oldBitmap.Dispose();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            tool.Paint(sender, e);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Point imageLocation = PictureBoxToImageCoordinates(e.Location);
                toolStripStatusLabel1.Text = $"({imageLocation.X}, {imageLocation.Y})";
                pictureBox1.Refresh();
            }
            tool.Draw(pictureBox1, e);
            tool.UpdateStatusBar(toolStripStatusLabel2);
        }
        private Point PictureBoxToImageCoordinates(Point pictureBoxPoint)
        {
            Size imageSize = pictureBox1.Image.Size;
            Size pictureBoxSize = pictureBox1.ClientSize;

            float scaleX = (float)imageSize.Width / pictureBoxSize.Width;
            float scaleY = (float)imageSize.Height / pictureBoxSize.Height;

            int imageX = (int)(pictureBoxPoint.X * scaleX);
            int imageY = (int)(pictureBoxPoint.Y * scaleY);

            return new Point(imageX, imageY);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (wasClicked || string.IsNullOrEmpty(saveFilePath))
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                    saveFileDialog.Title = "Save Image";
                    saveFileDialog.FileName = "";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        saveFilePath = saveFileDialog.FileName;
                        Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.Clear(pictureBox1.BackColor);
                        }
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.DrawImage(pictureBox1.Image, Point.Empty);
                        }
                        bitmap.Save(saveFilePath);
                        bitmap.Dispose();
                    }
                    wasClicked = false;
                }
                else
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(pictureBox1.BackColor);
                    }
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.DrawImage(pictureBox1.Image, Point.Empty);
                    }
                    bitmap.Save(saveFilePath);
                    bitmap.Dispose();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save Image";
                saveFileDialog.FileName = null;
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(pictureBox1.BackColor);
                    }
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.DrawImage(pictureBox1.Image, Point.Empty);
                    }
                    bitmap.Save(saveFileDialog.FileName);
                    bitmap.Dispose();
                }
            }
        }
        Size originalDrawingAreaSize;
        //https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                drawingBitmap = new Bitmap(openFileDialog.FileName);
                drawingBitmap = new Bitmap(drawingBitmap, new Size(pictureBox1.Width, pictureBox1.Height));
                pictureBox1.Image = drawingBitmap;
                graphics = Graphics.FromImage(drawingBitmap);
                originalDrawingAreaSize = new Size(panel2.Width, panel2.Height);
                AddRecentFile(openFileDialog.FileName);

            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void editColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogPen.ShowDialog() == DialogResult.OK)
            {
                if (pen != null)
                {
                    pen.Dispose();
                }

                pen = new Pen(colorDialogPen.Color, 1);
            }
        }
        double zoomIn;
        public int zoomINcnt = 0;
        private void zoomInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            zoomFactor = 1.1;
            zoomIn = 1.1;
            ResizeDrawingAreaAndBitmap((int)(pictureBox1.Width * zoomFactor), (int)(pictureBox1.Height * zoomFactor)); zoomINcnt++;
        }
        double zoomOut;
        public int zoomOutcnt = 0;
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.9;
            zoomOut = 0.9;
            
            ResizeDrawingAreaAndBitmap((int)(pictureBox1.Width * zoomFactor), (int)(pictureBox1.Height * zoomFactor)); zoomINcnt++;
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeDrawingAreaAndBitmap(originalDrawingAreaSize.Width, originalDrawingAreaSize.Height);
        }

        private void ResizeDrawingAreaAndBitmap(int newWidth, int newHeight)
        {
            panel2.Size = new Size(newWidth, newHeight);
            pictureBox1.Size = panel2.ClientSize;
            Bitmap oldBitmap = (Bitmap)pictureBox1.Image;
            Bitmap newBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.DrawImage(oldBitmap, new Rectangle(0, 0, newWidth, newHeight));
            }
            pictureBox1.Image = newBitmap;

            UpdateZoomPercentage();
        }


        private void ZoomBitmap(int newWidth, int newHeight)
        {
            Bitmap zoomedBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(zoomedBitmap))
            {
                g.DrawImage(drawingBitmap, 0, 0, newWidth, newHeight);
            }

            drawingBitmap.Dispose();
            drawingBitmap = zoomedBitmap;
            pictureBox1.Image = drawingBitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            UpdateZoomPercentage();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int percent = 100;
            double zoomFactor = 0.9;
            bool zoomIn = false;

            if (e.KeyCode == Keys.Subtract)
            {
                zoomIn = false;
            }
            else if (e.KeyCode == Keys.Add)
            {
                zoomIn = true;
            }

            if (zoomIn)
            {
                if (pictureBox1.Width * zoomFactor <= panel2.MaximumSize.Width &&
                    pictureBox1.Height * zoomFactor <= panel2.MaximumSize.Height)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Width = (int)(pictureBox1.Width * zoomFactor);
                    pictureBox1.Height = (int)(pictureBox1.Height * zoomFactor);
                    percent += 10;
                }
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = (int)(pictureBox1.Width / zoomFactor);
                pictureBox1.Height = (int)(pictureBox1.Height / zoomFactor);
                percent -= 10;
            }

            UpdateZoomPercentage();
        }
        private void UpdateZoomPercentage()
        {
            double zoomPercentage = (double)pictureBox1.Width / (double)drawingBitmap.Width * 100.0;
            toolStripStatusLabel4.Text = $"{zoomPercentage:F2}%";
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizingLeft = true;
                initialMouseX = e.X;
            }
            if (e.Button == MouseButtons.Right)
            {
                isResizingRight = true;
                initialMouseX = e.X;
            }
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizingLeft)
            {
                deltaX = e.X - initialMouseX;
                panel2.Width += deltaX;

                Bitmap newBitmap = new Bitmap(pictureBox1.Width + deltaX, pictureBox1.Height);

                Color backgroundColor = drawingBitmap.GetPixel(0, 0);
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.Clear(backgroundColor);
                    g.DrawImage(drawingBitmap, new Point(deltaX, 0));
                }
                drawingBitmap.Dispose();
                pictureBox1.Image = newBitmap;

                drawingBitmap = newBitmap;

                initialMouseX = e.X;
            }
            if (isResizingRight)
            {
                deltaX = e.X - initialMouseX;
                panel2.Width -= deltaX;

                Bitmap newBitmap = new Bitmap(pictureBox1.Width - deltaX, pictureBox1.Height);

                Color backgroundColor = drawingBitmap.GetPixel(0, 0);
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.Clear(backgroundColor);
                    g.DrawImage(drawingBitmap, new Point(deltaX, 0));
                }
                drawingBitmap.Dispose();

                pictureBox1.Image = newBitmap;

                drawingBitmap = newBitmap;

                initialMouseX = e.X;
            }
            toolStripStatusLabel3.Text = $"{pictureBox1.Width} x {pictureBox1.Height} px";
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            isResizingLeft = false;
            isResizingRight = false;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            if (isResizingLeft == true || isResizingRight == true)
            {
                pictureBox1.Width = panel2.ClientSize.Width;
            }
            if (isResizingTop == true || isResizingBottom == true)
            {
                pictureBox1.Height = panel2.ClientSize.Height;
            }

        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            initialMouseY = e.Y;
            if (e.Y < button2.Top + button2.Height / 2)
            {
                isResizingTop = true;
            }
            else if (e.Y > button2.Top + button2.Height / 2)
            {
                isResizingBottom = true;
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            isResizingTop = false;
            isResizingBottom = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizingBottom)
            {
                int deltaY = e.Y - initialMouseY;
                panel2.Height -= deltaY;

                Bitmap newBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height - deltaY);
                Color backgroundColor = drawingBitmap.GetPixel(0, 0);
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.Clear(backgroundColor);
                    g.DrawImage(drawingBitmap, Point.Empty);
                }
                drawingBitmap.Dispose();
                pictureBox1.Image = newBitmap;
                drawingBitmap = newBitmap;
                initialMouseY = e.Y;
            }
            else if (isResizingTop)
            {
                int deltaY = e.Y - initialMouseY;
                panel2.Height += deltaY;
                Bitmap newBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height + deltaY);

                Color backgroundColor = drawingBitmap.GetPixel(0, 0);
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.Clear(backgroundColor);
                    g.DrawImage(drawingBitmap, Point.Empty);
                }
                drawingBitmap.Dispose();
                pictureBox1.Image = newBitmap;
                drawingBitmap = newBitmap;

                initialMouseY = e.Y;
            }
            toolStripStatusLabel3.Text = $"{pictureBox1.Width} x {pictureBox1.Height} px";
        }

        private void buttonPen_Click(object sender, EventArgs e)
        {
            tool = new PenTool(Color.Black);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            tool = new LineTool(Color.Black);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            tool = new SelectionTool(toolStripStatusLabel2);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tool.SelectAll(pictureBox1);
            tool.UpdateStatusBar(toolStripStatusLabel2);

        }

        private void invertColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invertColorButton_Click(sender, e);
        }

        private void invertColorButton_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null && pictureBox1.Image is Bitmap bmp)
            {
                DirectBitmap originalBitmap = new DirectBitmap(drawingBitmap);

                tool.InvertColors(originalBitmap);
                pictureBox1.Image = originalBitmap.Bitmap;
                drawingBitmap = originalBitmap.Bitmap;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void buttonlightRed_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void buttonYell_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void buttonLightYell_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void buttonlightgreen_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void buttonlightblue_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.Button)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var butt = (System.Windows.Forms.PictureBox)sender;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            var butt = (System.Windows.Forms.PictureBox)sender;
            butt.BackColor = colorDialog1.Color;
            if (tool is PenTool pen)
            {
                tool = new PenTool(butt.BackColor);
            }
            if (tool is LineTool lineTool)
            {
                tool = new LineTool(butt.BackColor);
            }
        }
    }
}


