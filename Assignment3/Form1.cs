using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weight, Height, BMI;

            Weight = double.Parse(textBox1.Text);
            Height = double.Parse(textBox2.Text);

            BMI = Weight / Math.Pow(Height, 2) * 703;
            BMI = Math.Round(BMI, 2);

            if (BMI < 18.5)
            {
                textBox3.Text = "BMI:" + BMI + "\r" + "\n" + "Status: underweight";
            }

            else if (BMI > 25)
            {
                textBox3.Text = "BMI:" + BMI + "\r" + "\n" + "Status: overweight";
            }

            else if (BMI >= 18.5 & BMI <= 25)
            {
                textBox3.Text = "BMI:" + BMI + "\r" + "\n" + "Status: normal";
            }
        }
    }
}
