using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boss_of_this_Gym
{
    public partial class Automat : Form
    {
        ClassAutomat pi;
        public Automat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pi = new ClassAutomat(richTextBox1.Text);

            richTextBox1.ReadOnly = true;
            richTextBox1.Enabled = false;
            button1.Visible = false;
            button1.Enabled = false;

            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pi.check_word(textBox1.Text))
            {
                MessageBox.Show("Понимаю слово!!!");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("НЕ понимаю слово!!!");
                textBox1.Text = "";
            }
        }
    }
}
