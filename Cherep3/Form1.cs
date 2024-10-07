using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cherep3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int min) && int.TryParse(textBox2.Text, out int max))
            {
                if (min < max)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(min, max + 1);
                    label1.Text = $"Случайное число: {randomNumber}";
                }
                else
                {
                    MessageBox.Show("Минимальное число должно быть меньше максимального.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные целые числа.");
            }
        }
    }
}
