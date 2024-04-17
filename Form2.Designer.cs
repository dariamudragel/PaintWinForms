namespace WinFormsGratedLabPart
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(164, 30);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 800, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(164, 75);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 37);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 82);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Height:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 37);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 6;
            label3.Text = "px";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 77);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 7;
            label4.Text = "px";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 154);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Background";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 9;
            textBox1.Click += textBox1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(164, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 280);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New image...";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        public NumericUpDown numericUpDown2;
        private ColorDialog colorDialog1;
    }
}