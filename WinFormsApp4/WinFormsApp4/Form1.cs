using System.Drawing.Drawing2D;
namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int x, y, h, w;
        Pen p = new Pen(Color.Blue, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;

            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                g.DrawEllipse(p, shape);
            }
            else if (radioButton2.Checked)
            {
                g.DrawRectangle(p, shape);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}