using DrivingJornualLIb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingJornualApp1
{
    public partial class Form1 : Form
    {
        private DrivingJornual driverJournal;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            decimal miles = numericUpDown1.Value;
            string description = textBox1.Text;
            driverJournal.AddEntry(year, month, miles, description);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            label1.Text = driverJournal.MilesDriven(year, month).ToString();
        }
    }
}
