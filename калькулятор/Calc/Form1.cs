using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox1.Text);
            float c = a/100;
            float bmi = b / (c * c);
            label10.Text = bmi.ToString();
            
            if (bmi < 18.5) { label15.Text = "Недостаточный"; trackBar1.Value = Convert.ToInt32(bmi); }
            if (bmi >= 18.5 & bmi < 24.9) { label15.Text = "Здоровый"; trackBar1.Value = Convert.ToInt32(bmi); }
            if (bmi >=25 & bmi < 29.9) { label15.Text = "Избыточный"; trackBar1.Value = Convert.ToInt32(bmi); }
            else { label15.Text = "Ожирение"; }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
