using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGratedLabPart
{
    public partial class Form2 : Form
    {
        public Size PictureBoxSize { get; private set; }
        public Color PictureBoxBackColor { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_Click_1(object sender, EventArgs e)
        {
            //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-show-a-color-palette-with-the-colordialog-component?view=netframeworkdesktop-4.8

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int width = (int)numericUpDown1.Value;
            int height = (int)numericUpDown2.Value;
            PictureBoxSize = new Size(width, height);

            PictureBoxBackColor = textBox1.BackColor;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
