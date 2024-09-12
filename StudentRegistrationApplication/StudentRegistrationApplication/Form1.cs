using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        static String gen;
        static String day;
        static String month;
        static String year;
        static String program;
        ArrayList MonthArray = new ArrayList();
        ArrayList DayArray = new ArrayList();
        ArrayList YearArray = new ArrayList();
        ArrayList ProgramArray = new ArrayList();
        public Form1()
        {
            InitializeComponent();

            ProgramArray.Add("Bachelor of Science in Compute Science");
            ProgramArray.Add("Bachelor of Science in Information Technology");
            ProgramArray.Add("Bachelor of Science in Information Systems");
            ProgramArray.Add("Bachelor of Science in Computer Engineering");
            for (int i = 1; i <= 12; i++)
            {
                MonthArray.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                DayArray.Add(i);
            }
            for (int i = 1900; i <= 2024; i++)
            {
                YearArray.Add(i);
            }
            foreach (int months in MonthArray)
            {
                MONTH.Items.Add(months);
            }
            foreach (int days in DayArray)
            {
                DAY.Items.Add(days);
            }
            foreach (int years in YearArray)
            {
                YEAR.Items.Add(years);
            }
            foreach (String programs in ProgramArray)
            {
                ProgramCB.Items.Add(programs);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            String Firstname = FirstName.Text;
            String Middlename = MiddleName.Text;
            String Lastname = LastName.Text;
            MessageBox.Show("Student Name: " + Firstname + " " + Middlename + " " + Lastname + "\nGender: " + gen + "\nDate of Birth: " + month + "/" + day + "/" + year + "\nProgram: " + program);
        }

        private void GENMALE_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Male";
        }

        private void GENFEMALE_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Female";
        }

        private void DAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            day = DAY.SelectedItem.ToString();
        }

        private void MONTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = MONTH.SelectedItem.ToString();
        }

        private void YEAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = YEAR.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            program = ProgramCB.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
