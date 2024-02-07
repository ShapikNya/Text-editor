using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // �������� ��������� ����
                string filename = saveFileDialog1.FileName;

                // ��������� ����� � ����
                System.IO.File.WriteAllText(filename, textBox1.Text);
                MessageBox.Show("���� ��������");
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
        }
    }

