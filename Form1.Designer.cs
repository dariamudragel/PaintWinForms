namespace WinFormsGratedLabPart
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            resetZoomToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            editColorsToolStripMenuItem = new ToolStripMenuItem();
            invertColorsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            colorDialogPen = new ColorDialog();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog = new OpenFileDialog();
            buttonPen = new Button();
            buttonSelect = new Button();
            buttonLine = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonRed = new Button();
            buttonYell = new Button();
            buttonlightRed = new Button();
            buttonLightYell = new Button();
            buttonGreen = new Button();
            buttonlightgreen = new Button();
            buttonlightblue = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eToolStripMenuItem, viewToolStripMenuItem, imageToolStripMenuItem, colorsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, toolStripSeparator2, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(240, 26);
            newToolStripMenuItem.Text = "New...";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(240, 26);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(240, 26);
            saveToolStripMenuItem.Text = "Save..";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(240, 26);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(237, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(240, 26);
            printToolStripMenuItem.Text = "Print...";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(237, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(240, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(49, 24);
            eToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(204, 26);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(204, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(204, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(201, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(204, 26);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, resetZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(132, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomInToolStripMenuItem.Size = new Size(265, 26);
            zoomInToolStripMenuItem.Text = "Zoom in ";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click_1;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomOutToolStripMenuItem.Size = new Size(265, 26);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // resetZoomToolStripMenuItem
            // 
            resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            resetZoomToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            resetZoomToolStripMenuItem.Size = new Size(265, 26);
            resetZoomToolStripMenuItem.Text = "Reset zoom";
            resetZoomToolStripMenuItem.Click += resetZoomToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(65, 24);
            imageToolStripMenuItem.Text = "Image";
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editColorsToolStripMenuItem, invertColorsToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(65, 24);
            colorsToolStripMenuItem.Text = "Colors";
            // 
            // editColorsToolStripMenuItem
            // 
            editColorsToolStripMenuItem.Name = "editColorsToolStripMenuItem";
            editColorsToolStripMenuItem.Size = new Size(219, 26);
            editColorsToolStripMenuItem.Text = "Edit Colors";
            editColorsToolStripMenuItem.Click += editColorsToolStripMenuItem_Click;
            // 
            // invertColorsToolStripMenuItem
            // 
            invertColorsToolStripMenuItem.Name = "invertColorsToolStripMenuItem";
            invertColorsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            invertColorsToolStripMenuItem.Size = new Size(219, 26);
            invertColorsToolStripMenuItem.Text = "Invert colors";
            invertColorsToolStripMenuItem.Click += invertColorsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F12;
            aboutToolStripMenuItem.Size = new Size(165, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 850);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1262, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Margin = new Padding(1, 4, 0, 2);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(300, 20);
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.MouseMove += pictureBox1_MouseMove;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.Margin = new Padding(1, 4, 1, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(400, 20);
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.AutoSize = false;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(200, 20);
            toolStripStatusLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.AutoSize = false;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(100, 20);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(872, 646);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog2";
            // 
            // buttonPen
            // 
            buttonPen.Location = new Point(21, 45);
            buttonPen.Name = "buttonPen";
            buttonPen.Size = new Size(94, 29);
            buttonPen.TabIndex = 3;
            buttonPen.Text = "Pen";
            buttonPen.UseVisualStyleBackColor = true;
            buttonPen.Click += buttonPen_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(21, 88);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(94, 29);
            buttonSelect.TabIndex = 4;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonLine
            // 
            buttonLine.Location = new Point(21, 139);
            buttonLine.Name = "buttonLine";
            buttonLine.Size = new Size(94, 29);
            buttonLine.TabIndex = 5;
            buttonLine.Text = "Line";
            buttonLine.UseVisualStyleBackColor = true;
            buttonLine.Click += buttonLine_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(140, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 716);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 648);
            panel2.TabIndex = 12;
            panel2.Resize += panel2_Resize;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Cursor = Cursors.SizeNWSE;
            button3.Location = new Point(820, 607);
            button3.Name = "button3";
            button3.Size = new Size(28, 23);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Cursor = Cursors.SizeNS;
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 636);
            button2.Name = "button2";
            button2.Size = new Size(862, 10);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.MouseDown += button2_MouseDown;
            button2.MouseMove += button2_MouseMove;
            button2.MouseUp += button2_MouseUp;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.SizeWE;
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(862, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(10, 646);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.MouseDown += button1_MouseDown;
            button1.MouseMove += button1_MouseMove;
            button1.MouseUp += button1_MouseUp;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.Red;
            buttonRed.Location = new Point(145, 39);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(30, 30);
            buttonRed.TabIndex = 9;
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // buttonYell
            // 
            buttonYell.BackColor = Color.Yellow;
            buttonYell.Location = new Point(181, 39);
            buttonYell.Name = "buttonYell";
            buttonYell.Size = new Size(30, 30);
            buttonYell.TabIndex = 10;
            buttonYell.UseVisualStyleBackColor = false;
            buttonYell.Click += buttonYell_Click;
            // 
            // buttonlightRed
            // 
            buttonlightRed.BackColor = Color.FromArgb(255, 192, 192);
            buttonlightRed.Location = new Point(145, 82);
            buttonlightRed.Name = "buttonlightRed";
            buttonlightRed.Size = new Size(30, 30);
            buttonlightRed.TabIndex = 11;
            buttonlightRed.UseVisualStyleBackColor = false;
            buttonlightRed.Click += buttonlightRed_Click;
            // 
            // buttonLightYell
            // 
            buttonLightYell.BackColor = Color.FromArgb(255, 255, 192);
            buttonLightYell.Location = new Point(181, 82);
            buttonLightYell.Margin = new Padding(0);
            buttonLightYell.Name = "buttonLightYell";
            buttonLightYell.Size = new Size(30, 30);
            buttonLightYell.TabIndex = 12;
            buttonLightYell.UseVisualStyleBackColor = false;
            buttonLightYell.Click += buttonLightYell_Click;
            // 
            // buttonGreen
            // 
            buttonGreen.BackColor = Color.Lime;
            buttonGreen.Location = new Point(217, 39);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(30, 30);
            buttonGreen.TabIndex = 13;
            buttonGreen.UseVisualStyleBackColor = false;
            buttonGreen.Click += buttonGreen_Click;
            // 
            // buttonlightgreen
            // 
            buttonlightgreen.BackColor = Color.FromArgb(192, 255, 192);
            buttonlightgreen.Location = new Point(217, 82);
            buttonlightgreen.Name = "buttonlightgreen";
            buttonlightgreen.Size = new Size(30, 30);
            buttonlightgreen.TabIndex = 14;
            buttonlightgreen.UseVisualStyleBackColor = false;
            buttonlightgreen.Click += buttonlightgreen_Click;
            // 
            // buttonlightblue
            // 
            buttonlightblue.BackColor = Color.Cyan;
            buttonlightblue.Location = new Point(253, 39);
            buttonlightblue.Name = "buttonlightblue";
            buttonlightblue.Size = new Size(30, 30);
            buttonlightblue.TabIndex = 15;
            buttonlightblue.UseVisualStyleBackColor = false;
            buttonlightblue.Click += buttonlightblue_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(192, 255, 255);
            button11.Location = new Point(253, 80);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 16;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Blue;
            button12.Location = new Point(289, 39);
            button12.Name = "button12";
            button12.Size = new Size(30, 30);
            button12.TabIndex = 17;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(192, 192, 255);
            button13.Location = new Point(289, 80);
            button13.Name = "button13";
            button13.Size = new Size(30, 30);
            button13.TabIndex = 18;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Fuchsia;
            button14.Location = new Point(325, 39);
            button14.Name = "button14";
            button14.Size = new Size(30, 30);
            button14.TabIndex = 19;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(255, 192, 255);
            button15.Location = new Point(325, 80);
            button15.Name = "button15";
            button15.Size = new Size(30, 30);
            button15.TabIndex = 20;
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Gray;
            button16.Location = new Point(361, 39);
            button16.Name = "button16";
            button16.Size = new Size(30, 30);
            button16.TabIndex = 21;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(224, 224, 224);
            button17.Location = new Point(361, 80);
            button17.Name = "button17";
            button17.Size = new Size(30, 30);
            button17.TabIndex = 22;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.White;
            button18.Location = new Point(397, 39);
            button18.Name = "button18";
            button18.Size = new Size(30, 30);
            button18.TabIndex = 23;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Black;
            button19.Location = new Point(397, 80);
            button19.Name = "button19";
            button19.Size = new Size(30, 30);
            button19.TabIndex = 24;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Fuchsia;
            pictureBox3.Location = new Point(453, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 27);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.DoubleClick += pictureBox3_DoubleClick;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Maroon;
            pictureBox4.Location = new Point(453, 85);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 27);
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(515, 39);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 27);
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(515, 85);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 27);
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(585, 39);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 27);
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(585, 88);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(34, 27);
            pictureBox8.TabIndex = 30;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(652, 39);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(34, 27);
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(652, 88);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(34, 27);
            pictureBox10.TabIndex = 32;
            pictureBox10.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 876);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(buttonlightblue);
            Controls.Add(buttonlightgreen);
            Controls.Add(buttonGreen);
            Controls.Add(buttonLightYell);
            Controls.Add(buttonlightRed);
            Controls.Add(buttonYell);
            Controls.Add(buttonRed);
            Controls.Add(buttonLine);
            Controls.Add(buttonSelect);
            Controls.Add(buttonPen);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ColorDialog colorDialogPen;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem editColorsToolStripMenuItem;
        private ToolStripMenuItem invertColorsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private Button buttonPen;
        private Button buttonSelect;
        private Button buttonLine;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private PictureBox pictureBox2;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem resetZoomToolStripMenuItem;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Button buttonRed;
        private Button buttonYell;
        private Button buttonlightRed;
        private Button buttonLightYell;
        private Button buttonGreen;
        private Button buttonlightgreen;
        private Button buttonlightblue;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private ColorDialog colorDialog1;
    }
}
