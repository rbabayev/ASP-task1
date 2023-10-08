namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            Label TIMER;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            TIMER = new Label();
            SuspendLayout();
            // 
            // TIMER
            // 
            TIMER.AutoEllipsis = true;
            TIMER.AutoSize = true;
            TIMER.BackColor = Color.Transparent;
            TIMER.FlatStyle = FlatStyle.Flat;
            TIMER.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TIMER.ForeColor = Color.Transparent;
            TIMER.ImageAlign = ContentAlignment.MiddleRight;
            TIMER.Location = new Point(303, 31);
            TIMER.Name = "TIMER";
            TIMER.Size = new Size(280, 81);
            TIMER.TabIndex = 2;
            TIMER.Text = "T  I  M  E";
            TIMER.TextAlign = ContentAlignment.TopCenter;
            TIMER.UseMnemonic = false;
            TIMER.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(389, 223);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 0;
            button1.Text = "Baku";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(389, 277);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 1;
            button2.Text = "London";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(306, 123);
            label1.Name = "label1";
            label1.Size = new Size(277, 81);
            label1.TabIndex = 3;
            label1.Text = "00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = Properties.Resources.photo_1614850523459_c2f4c699c52e;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 453);
            Controls.Add(label1);
            Controls.Add(TIMER);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Global Timer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label TIMER;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}