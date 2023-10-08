namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a = Random.Shared.Next(0, this.Size.Width - label1.Size.Width - 20);
            int b = Random.Shared.Next(0, this.Size.Height - label1.Size.Height - 20);

            label1.Location = new Point(a, b);
        }


    }
}