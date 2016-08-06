using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author: Zun Dai
 * Student ID: 300839401
 * Date modified: 2016-08-05
 * Program description: Assigment6, GUI, BMI Calculator APP
 */

namespace COMP123_S2016_Assignment6
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BMITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CalcuButton_Click_1(object sender, EventArgs e)
        {
            double height, weight, bmi;
            height = Convert.ToDouble(HeightTextBox.Text);
            weight = Convert.ToDouble(WeightTextBox.Text);

            if (height > 0 && weight > 0)
            {
                HeightTextBox.Enabled = false;
                WeightTextBox.Enabled = false;

                if (ImpRadioButton.Checked == true)
                {
                    bmi = (weight * 4.88) / ((height) * (height));
                    BMITextBox.Text = Convert.ToString(bmi);

                    if (bmi < 18.5)
                    {
                        MessageBox.Show("Underweight < 18.5");
                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        MessageBox.Show("Normal = 18.5~24.9 ");
                    }
                    else if (bmi > 25 && bmi <= 29.9)
                    {
                        MessageBox.Show("Overweight = 25~29.9");
                    }
                    else if (bmi >= 30)
                    {
                        MessageBox.Show("Obesity >= 30");
                    }
                }

                else if (MetricRadioButton.Checked == true)
                {
                    bmi = weight / ((height) * (height));
                    BMITextBox.Text = Convert.ToString(bmi);

                    if (bmi < 18.5)
                    {
                        MessageBox.Show("Underweight = <18.5");
                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        MessageBox.Show("Normal = 18.5-24.9 ");
                    }
                    else if (bmi > 25 && bmi <= 29.9)
                    {
                        MessageBox.Show("Overweight = 25-29.9");
                    }
                    else if (bmi >= 30)
                    {
                        MessageBox.Show("Obesity = BMI of 30 or greater");
                    }
                }
            }
        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";

            BMITextBox.Text = "";

            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;
        }
    }
}
