using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIAZ_RomanNumeral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            bool isValid = int.TryParse(textBox1.Text, out number);

            if (!isValid || number < 1 || number > 1000)
            {
                textBox1.Text = "Please enter a valid number between 1 and 1000.";
            }
            else
            {
                label2.Text = "Roman Numeral: " + ToRoman(number);
            }
        }

        public static string ToRoman(int num)
        {
            Dictionary<int, string> romanNumerals = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

            string result = "";

            foreach (var item in romanNumerals)
            {
                while (num >= item.Key)
                {
                    result += item.Value;
                    num -= item.Key;
                }
            }

            return result;
        }
    }
}
