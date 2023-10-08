using System.Net.NetworkInformation;
using System.Reflection;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool isCheck = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isCheck)
            {

                label1.Text = DateTime.Now.ToString("hh:mm:ss");
                this.BackgroundImage = Resources.Aze;
                isCheck = false;
            }
            else
            {

                label1.Text = DateTime.Now.ToString("hh:mm:ss");
                this.BackgroundImage = Resources.Aze;
                isCheck = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (isCheck)
            {

                label1.Text = DateTime.UtcNow.ToString("hh:mm:ss");
                this.BackgroundImage = Resources._847138_white_england_flag_color_blue_3d_and_abstract;
                isCheck = false;
            }
            else
            {

                label1.Text = DateTime.UtcNow.ToString("hh:mm:ss");
                this.BackgroundImage = Resources._847138_white_england_flag_color_blue_3d_and_abstract;
                isCheck = true;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {



        }
    }
}