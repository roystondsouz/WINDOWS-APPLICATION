using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = NumtoWord(long.Parse(textBox1.Text));
            label2.Visible = true;
        }
        public string NumtoWord(long number)
        {
            string word = "";
            if (number == 0)
            {
                return "Zero";
            }
            if (number < 0)
            {
                return "Minus" + Math.Abs(number);
            }
            if (number / 10000000 > 0)
            {
                word += NumtoWord(number / 10000000) + "Corer";
                number %= 10000000;
            }
        if (number / 100000 > 0)
            {
                word += NumtoWord(number / 100000) + "Lacs";
                number %= 100000;
            }
            if (number / 1000 > 0)
            {
                word += NumtoWord(number / 1000) + "Thousand";
                number %= 1000;
            }
            if (number / 100 > 0)
            {
                word += NumtoWord(number / 100) + "Hundred";
                number %= 100;
            }
            if (number > 0)
            {
                string[] units = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six",
"Seven", "Eight", "Nine","TEN", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
"Seventeen", "Eighteen", "Nineteen" };
                string[] Tens = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty",
"Sixty", "Seventy", "Eighty", "Ninety" };
                if (number < 20)
                {
                    word += units[number];
                }
                else
                {
                    word += Tens[number / 10];
                    if (number % 10 > 0)
                    {
                        word += units[number % 10];
                    }
                }
            }
            return word;
        }
    }
}

        