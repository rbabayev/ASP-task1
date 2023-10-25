
namespace TxtBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Fontlar
            foreach (FontFamily font in FontFamily.Families)
            {
                fontCombo.Items.Add(font.Name);
            }
            //Size
            for (int i = 8; i <= 72; i += 2)
            {
                sizeCombo.Items.Add(i);
            }
            //Colors
            colorCombo.Items.Add("Black");
            colorCombo.Items.Add("Red");
            colorCombo.Items.Add("Blue");
            colorCombo.Items.Add("Green");
            colorCombo.Items.Add("Yellow");
            colorCombo.Items.Add("Orange");
            colorCombo.Items.Add("Purple");
            colorCombo.Items.Add("Pink");
            colorCombo.Items.Add("Brown");
            colorCombo.Items.Add("Gray");
            colorCombo.Items.Add("Cyan");
        }

        private void fontCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedFont = fontCombo.SelectedItem.ToString();
            Font currentFont = textBox1.Font;
            Font newFont = new Font(selectedFont, currentFont.Size, currentFont.Style);
            textBox1.Font = newFont;
        }

        private void sizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedSize = Convert.ToInt32(sizeCombo.SelectedItem);
            textBox1.Font = new Font(textBox1.Font.FontFamily, selectedSize, textBox1.Font.Style);
            textBox1.Size = new Size(textBox1.Size.Width, selectedSize + 10);
        }

        private void Bbutton_Click(object sender, EventArgs e)
        {
            Font currentFont = textBox1.Font;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Bold; 

            textBox1.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

        }

        private void Ubutton_Click(object sender, EventArgs e)
        {
            Font currentFont = textBox1.Font;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;

            textBox1.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
        }

        private void Sbutton_Click(object sender, EventArgs e)
        {
            Font currentFont = textBox1.Font;
            FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;

            textBox1.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
        }

        private void Lbutton_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }
    

        private void Cbutton_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void Rbutton_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void colorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = colorCombo.SelectedItem.ToString();
            Color newColor = Color.FromName(selectedColor);
            textBox1.ForeColor = newColor;
        }

        private void loadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string fileContent = File.ReadAllText(fileName);
                loadTextBox.Text = fileContent;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string fileContent = saveTextBox.Text;
                File.WriteAllText(fileName, fileContent);
                MessageBox.Show("Succesfully save.");
            }
        }

        private void txtLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }
    }
}

