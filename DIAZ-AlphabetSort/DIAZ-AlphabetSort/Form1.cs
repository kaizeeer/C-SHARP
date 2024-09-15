using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIAZ_AlphabetSort
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = af.Text;
            string str = word.ToLower();
            char[] charstr = str.ToCharArray();
            char temp;

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            string sortedWord = new string(charstr);
            label2.Text = "Your Word: " + word + "\nSorted: " + sortedWord;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
