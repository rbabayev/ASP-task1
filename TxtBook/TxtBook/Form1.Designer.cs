namespace TxtBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fontLbl = new Label();
            sizeLbl = new Label();
            fontCombo = new ComboBox();
            sizeCombo = new ComboBox();
            colorLbl = new Label();
            colorCombo = new ComboBox();
            styleLbl = new Label();
            alignmentLbl = new Label();
            Bbutton = new Button();
            Ubutton = new Button();
            Sbutton = new Button();
            Lbutton = new Button();
            Cbutton = new Button();
            Rbutton = new Button();
            loadTextBox = new TextBox();
            loadButton = new Button();
            saveButton = new Button();
            saveTextBox = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fontLbl
            // 
            fontLbl.AutoSize = true;
            fontLbl.Location = new Point(91, 15);
            fontLbl.Name = "fontLbl";
            fontLbl.Size = new Size(38, 20);
            fontLbl.TabIndex = 0;
            fontLbl.Text = "Font";
            // 
            // sizeLbl
            // 
            sizeLbl.AutoSize = true;
            sizeLbl.Location = new Point(216, 15);
            sizeLbl.Name = "sizeLbl";
            sizeLbl.Size = new Size(36, 20);
            sizeLbl.TabIndex = 1;
            sizeLbl.Text = "Size";
            // 
            // fontCombo
            // 
            fontCombo.FormattingEnabled = true;
            fontCombo.Location = new Point(37, 42);
            fontCombo.Name = "fontCombo";
            fontCombo.Size = new Size(151, 28);
            fontCombo.TabIndex = 2;
            fontCombo.SelectedIndexChanged += fontCombo_SelectedIndexChanged;
            // 
            // sizeCombo
            // 
            sizeCombo.FormattingEnabled = true;
            sizeCombo.Location = new Point(194, 42);
            sizeCombo.Name = "sizeCombo";
            sizeCombo.Size = new Size(83, 28);
            sizeCombo.TabIndex = 3;
            sizeCombo.SelectedIndexChanged += sizeCombo_SelectedIndexChanged;
            // 
            // colorLbl
            // 
            colorLbl.AutoSize = true;
            colorLbl.Location = new Point(669, 15);
            colorLbl.Name = "colorLbl";
            colorLbl.Size = new Size(45, 20);
            colorLbl.TabIndex = 4;
            colorLbl.Text = "Color";
            // 
            // colorCombo
            // 
            colorCombo.FormattingEnabled = true;
            colorCombo.Location = new Point(614, 42);
            colorCombo.Name = "colorCombo";
            colorCombo.Size = new Size(151, 28);
            colorCombo.TabIndex = 5;
            colorCombo.SelectedIndexChanged += colorCombo_SelectedIndexChanged;

            // 
            // styleLbl
            // 
            styleLbl.AutoSize = true;
            styleLbl.Location = new Point(343, 15);
            styleLbl.Name = "styleLbl";
            styleLbl.Size = new Size(70, 20);
            styleLbl.TabIndex = 6;
            styleLbl.Text = "FontStyle";
            // 
            // alignmentLbl
            // 
            alignmentLbl.AutoSize = true;
            alignmentLbl.Location = new Point(473, 15);
            alignmentLbl.Name = "alignmentLbl";
            alignmentLbl.Size = new Size(78, 20);
            alignmentLbl.TabIndex = 7;
            alignmentLbl.Text = "Alignment";
            // 
            // Bbutton
            // 
            Bbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Bbutton.Location = new Point(329, 42);
            Bbutton.Name = "Bbutton";
            Bbutton.Size = new Size(29, 28);
            Bbutton.TabIndex = 8;
            Bbutton.Text = "B";
            Bbutton.UseVisualStyleBackColor = true;
            Bbutton.Click += Bbutton_Click;
            // 
            // Ubutton
            // 
            Ubutton.Location = new Point(364, 42);
            Ubutton.Name = "Ubutton";
            Ubutton.Size = new Size(29, 28);
            Ubutton.TabIndex = 9;
            Ubutton.Text = "U̲";
            Ubutton.UseVisualStyleBackColor = true;
            Ubutton.Click += Ubutton_Click;
            // 
            // Sbutton
            // 
            Sbutton.Location = new Point(399, 42);
            Sbutton.Name = "Sbutton";
            Sbutton.Size = new Size(29, 28);
            Sbutton.TabIndex = 10;
            Sbutton.Text = "/";
            Sbutton.UseVisualStyleBackColor = true;
            Sbutton.Click += Sbutton_Click;
            // 
            // Lbutton
            // 
            Lbutton.Location = new Point(464, 42);
            Lbutton.Name = "Lbutton";
            Lbutton.Size = new Size(29, 28);
            Lbutton.TabIndex = 11;
            Lbutton.Text = "L";
            Lbutton.UseVisualStyleBackColor = true;
            Lbutton.Click += Lbutton_Click;
            // 
            // Cbutton
            // 
            Cbutton.Location = new Point(499, 42);
            Cbutton.Name = "Cbutton";
            Cbutton.Size = new Size(29, 28);
            Cbutton.TabIndex = 12;
            Cbutton.Text = "C";
            Cbutton.UseVisualStyleBackColor = true;
            Cbutton.Click += Cbutton_Click;
            // 
            // Rbutton
            // 
            Rbutton.Location = new Point(534, 42);
            Rbutton.Name = "Rbutton";
            Rbutton.Size = new Size(29, 28);
            Rbutton.TabIndex = 13;
            Rbutton.Text = "R";
            Rbutton.UseVisualStyleBackColor = true;
            Rbutton.Click += Rbutton_Click;
            // 
            // loadTextBox
            // 
            loadTextBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            loadTextBox.ForeColor = SystemColors.WindowFrame;
            loadTextBox.Location = new Point(815, 11);
            loadTextBox.Multiline = true;
            loadTextBox.Name = "loadTextBox";
            loadTextBox.Size = new Size(258, 29);
            loadTextBox.TabIndex = 14;
            loadTextBox.Text = "Enter name and load file ";
            loadTextBox.TextChanged += loadTextBox_TextChanged;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(1114, 11);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(94, 29);
            loadButton.TabIndex = 16;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1114, 56);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // saveTextBox
            // 
            saveTextBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            saveTextBox.ForeColor = SystemColors.WindowFrame;
            saveTextBox.Location = new Point(815, 56);
            saveTextBox.Multiline = true;
            saveTextBox.Name = "saveTextBox";
            saveTextBox.Size = new Size(258, 29);
            saveTextBox.TabIndex = 18;
            saveTextBox.Text = "Tap to enter name and save";
            saveTextBox.TextChanged += saveTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(colorCombo);
            panel1.Controls.Add(saveTextBox);
            panel1.Controls.Add(fontLbl);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(sizeLbl);
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(fontCombo);
            panel1.Controls.Add(loadTextBox);
            panel1.Controls.Add(sizeCombo);
            panel1.Controls.Add(Rbutton);
            panel1.Controls.Add(colorLbl);
            panel1.Controls.Add(Cbutton);
            panel1.Controls.Add(styleLbl);
            panel1.Controls.Add(Lbutton);
            panel1.Controls.Add(alignmentLbl);
            panel1.Controls.Add(Sbutton);
            panel1.Controls.Add(Bbutton);
            panel1.Controls.Add(Ubutton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 100);
            panel1.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1269, 508);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 608);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Notepad+";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fontLbl;
        private Label sizeLbl;
        private ComboBox fontCombo;
        private ComboBox sizeCombo;
        private Label colorLbl;
        private ComboBox colorCombo;
        private Label styleLbl;
        private Label alignmentLbl;
        private Button Bbutton;
        private Button Ubutton;
        private Button Sbutton;
        private Button Lbutton;
        private Button Cbutton;
        private Button Rbutton;
        private TextBox loadTextBox;
        private Button loadButton;
        private Button saveButton;
        private TextBox saveTextBox;
        private Panel panel1;
        private TextBox textBox1;
    }
}