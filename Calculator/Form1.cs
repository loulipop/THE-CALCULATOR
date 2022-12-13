using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            textBoxOutput.Text = currentCalculation;
        }

        private string FormatInput(string Input)
        {
            string input = Input;
            input = input.Replace("÷", "/");
            char[] operands_open = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')'};
            int y = 0;
            do
            {
                y = input.IndexOf('(', y);
                if (y > 0 && operands_open.Contains(input[y - 1]))
                    input = input.Insert(y, "x");
                y++;
            }
            while (y > 0);

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                        input = input.Insert(i + 1, " ");
                        i++;
                        break;
                    case ')':
                        input = input.Insert(i, " ");
                        i++;
                        break;
                    case '+':
                    case '-':
                    case 'x':
                    case '/':
                        input = input.Insert(i + 1, " ");
                        input = input.Insert(i, " ");
                        i += 2;
                        break;
                    default:
                        break;
                }
            }
            input = input.Trim();
            input += " ";
            return input;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = FormatInput(currentCalculation);
            try
            {
                RPN infix = new RPN(formattedCalculation);
                BinaryTree bintree = new BinaryTree(infix);
                bintree.Calculate();

                currentCalculation = bintree.Result;
                textBoxOutput.Text = currentCalculation;
            }

            catch (FormatException error)
            {
                textBoxOutput.Text = "SYNTAX ERROR";
                currentCalculation = "";
            }
            catch (DivideByZeroException error)
            {
                textBoxOutput.Text = "MATH ERROR";
                currentCalculation = "";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            currentCalculation = "";
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            textBoxOutput.Text = currentCalculation;
        }



        /*private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Silver;
            gp.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(gp);
            gp.Dispose();
        }*/
    }
}
