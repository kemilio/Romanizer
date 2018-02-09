using System;
using System.Windows.Forms;
using Romanizer;

namespace WindowsFormsApplication1
{
    public partial class Romanizer : Form
    {
        public Romanizer()
        {
            InitializeComponent();
        }

        private void Romanizer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.AppendText(Romanizer.Romanize(textBox1.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
