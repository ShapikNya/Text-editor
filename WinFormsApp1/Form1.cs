using System.Media;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SoundPlayer sf = new SoundPlayer(@"Music.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;

                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, textBox1.Text);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            sf.Play();
        }
    }
}

