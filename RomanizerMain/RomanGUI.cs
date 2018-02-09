using System;
using System.Windows.Forms;
using RomanNumeralsGUI;
using Romanizer;

namespace RomanNumeralsGUI
{
    public partial class RomanizerForm : Form
    {
        private int intVal;

        public RomanizerForm()
        {
            InitializeComponent();
        }

        private void Romanizer_Load(object sender, EventArgs e)
        {

        }

        private void Romanize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(intIn.Text, out intVal))
            {
                try
                {
                    outBox.Text = Numerals.Romanize(intVal);
                }
                catch (ArgumentOutOfRangeException)
                {
                    outBox.Text = @"No negativity here!";
                }
                catch (ArgumentException)
                {
                    outBox.Text = @"Too big!";
                }
            }
            else
            {
                if (intIn.Text.ToLower().Equals("marco"))
                {
                    outBox.Text = @"Polo!";
                }
                else if (intIn.Text.ToLower().Equals("caesar"))
                {
                    outBox.Text = @"Hail Caesar!";
                }
                else
                {
                    outBox.Text = @"Integers please.";
                }
            }
        }

        private void Deromanize_Click(object sender, EventArgs e)
        {
            bool error = false;
            int input = -1;
            try
            {
                input = Numerals.Deromanize(intOut.Text);

            }
            catch (InvalidOperationException)
            {
                outBox.Text = @"Invalid numeral!";
                error = true;
            }
            catch (ArgumentException)
            {
                outBox.Text = @"Valid numerals only!";
                error = true;
            }
            if (!error)
            {
                outBox.Text = input.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void outBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}