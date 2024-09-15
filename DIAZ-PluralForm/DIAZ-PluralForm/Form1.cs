using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIAZ_PluralForm
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

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text.Trim().ToLower();
            string pluralWord = ConvertToPlural(word);
            if (string.IsNullOrEmpty(pluralWord))
            {
                MessageBox.Show("Invalid Word!", "Warning");
            }
            else
            {
                label6.Text = "The Plural Form is: " + pluralWord;
            }
        }

        private string ConvertToPlural(string word)
        {
          
            switch (word)
            {
                case "box":
                    return "boxes";
                case "paper":
                    return "papers";
                case "city":
                    return "cities";
                case "math":
                    return "maths";
                default:
                    return null; 
            }
        }

        
    }
}


