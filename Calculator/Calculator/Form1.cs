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

        private bool calculated = false;
        private char operand;
        
        private void button1_Click(object sender, EventArgs e)
        { // 1 button // append 1
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "1";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("1");
                }
            } else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "1";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("1");
                }
            }
            calculated = false;
        }

        private void button10_Click(object sender, EventArgs e)
        { // 0 button // append 0
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "0";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("0");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "0";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("0");
                }
            }
            calculated = false;
        }

        private void button11_Click(object sender, EventArgs e)
        { // . button // append decimal
            if (!output.Text.Contains("."))
            {
                output.AppendText(".");
            }

            //textbox2 functionality
            calculated = false;
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  // 2 button // append 2
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "2";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("2");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "2";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("2");
                }
            }
            calculated = false;
        }

        private void button12_Click(object sender, EventArgs e)
        { // (+ -) button // sign conversion
            output.Text = (Convert.ToDouble(output.Text)*-1).ToString();

            // textbox2 functionality
        }

        private void button13_Click(object sender, EventArgs e)
        {// ENTER button // resolve operation buttons

            switch (operand)
            {
                case '+':
                    {
                        output.Text = (Convert.ToDouble(output.Text) + Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    }
                case '-':
                    {
                        output.Text = (Convert.ToDouble(output.Text) - Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    }
                case '*':
                    {
                        output.Text = (Convert.ToDouble(output.Text) * Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    }
                case '÷':
                    {
                        output.Text = (Convert.ToDouble(output.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    }
                case '%':
                    {
                        output.Text = (Convert.ToDouble(output.Text) % Convert.ToDouble(textBox2.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
                    
            }
            calculated = true;
        }

        private void button14_Click(object sender, EventArgs e)
        { // + button // addition operation
            operand = '+';
            textBox1.Text = operand.ToString();
            
        }

        private void button15_Click(object sender, EventArgs e)
        { // - button // subtraction operation
            operand = '-';
            textBox1.Text = operand.ToString();
            
        }

        private void button16_Click(object sender, EventArgs e)
        { // * button // multiplication operation
            operand = '*';
            textBox1.Text = operand.ToString();
            
        }

        private void button17_Click(object sender, EventArgs e)
        { // ÷ button // division operation
            operand = '÷';
            textBox1.Text = operand.ToString();
            
        }

        private void button20_Click(object sender, EventArgs e)
        { // C button // clear/reset all
            output.Text = "0";
            textBox2.Text = "0";
            operand = '\0';
            textBox1.Text = operand.ToString();
            calculated = false;
        }

        private void button9_Click(object sender, EventArgs e)
        { // 9 button // append 9
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "9";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("9");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "9";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("9");
                }
            }
            calculated = false;
        }

        private void button6_Click(object sender, EventArgs e)
        { // 6 button // append 6
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "6";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("6");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "6";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("6");
                }
            }
            calculated = false;
        }

        private void button3_Click(object sender, EventArgs e)
        { // 3 button // append 3
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "3";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("3");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "3";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("3");
                }
            }
            calculated = false;
        }

        private void button5_Click(object sender, EventArgs e)
        { // 5 button // append 5
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "5";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("5");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "5";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("5");
                }
            }
            calculated = false;
        }

        private void button8_Click(object sender, EventArgs e)
        { // 8 button // append 8
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "8";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("8");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "8";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("8");
                }
            }
            calculated = false;
        }

        private void button19_Click(object sender, EventArgs e)
        { // CE button // clears only last entry
            textBox2.Text = "0";
            calculated = false;
        }

        private void button18_Click(object sender, EventArgs e)
        { // MOD button // modulo operator
            operand = '%';
            textBox1.Text = operand.ToString();
            
        }

        private void button7_Click(object sender, EventArgs e)
        { // 7 button // append 7
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "7";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("7");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "7";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("7");
                }
            }
            calculated = false;
        }

        private void button4_Click(object sender, EventArgs e)
        { // 4 button // append 4
            if (operand == '\0')
            {
                if (Convert.ToDouble(output.Text) == 0 || calculated)
                {
                    output.Text = "4";
                }
                else if (output.Text.Length < 16 && !calculated)
                {
                    output.AppendText("4");
                }
            }
            else
            {
                if (Convert.ToDouble(textBox2.Text) == 0 || calculated)
                {
                    textBox2.Text = "4";
                }
                else if (textBox2.Text.Length < 16 && !calculated)
                {
                    textBox2.AppendText("4");
                }
            }
            calculated = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {// <-- button // backspace
            if (!calculated && output.Text != "0")
            {
                output.Text = output.Text.Remove(output.Text.Length - 1);
                if (output.Text.Length < 1)
                {
                    output.Text = "0";
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {// √ button // squareroot
            output.Text = Math.Sqrt(Convert.ToDouble(output.Text)).ToString();
            calculated = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {// x² button // square current entry
            output.Text = (Math.Pow(Convert.ToDouble(output.Text), 2)).ToString();
            calculated = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {// 1/x button // divide 1 by current entry
            output.Text = (1 / Convert.ToDouble(output.Text)).ToString();
            calculated = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
