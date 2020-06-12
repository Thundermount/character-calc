using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string alphabet = "йцукенгшщзхъфывапролджэячсмитьбю./:;1234567890-+=!@#$%^&*()'<>;' ";
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToLower();
            richTextBox2.Text = "";
            textBox1.Text = Convert.ToString(richTextBox1.Text.Length);
            char[] al = alphabet.ToArray();
            for (int i = 0; i < al.Length; i++)
            {
                int count = 0;
                for (int l = 0; l < richTextBox1.Text.Length; l++)
                {
                    if (al[i] == richTextBox1.Text[l])
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    if (al[i] == ' ')
                    {
                        richTextBox2.Text += "[ПРОБЕЛ]" + " = " + count + "\n";
                    } else
                    richTextBox2.Text += al[i] + " = " + count + "\n";
                }

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}