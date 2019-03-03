using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private double currentValue;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!output.Text[output.Text.Length - 1].Equals(0))
            {
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!output.Text[output.Text.Length-1].Equals(0))
            {
                currentValue *= 10;
                output.Text = currentValue.ToString();
            } 

            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.AppendText("2");
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.AppendText("9");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.AppendText("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.AppendText("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.AppendText("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.AppendText("8");
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.AppendText("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.AppendText("4");
        }
    }
}
