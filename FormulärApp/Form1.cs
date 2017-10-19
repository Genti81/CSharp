using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulärApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var personNamn = textBox1.Text;
            var NewDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var telMob = textBox3.Text;

            var tokens = new string[]
            {
                personNamn, NewDate, telMob
            };

            File.WriteAllText(saveFileDialog1.FileName, string.Join(";", tokens));
            File.WriteAllText(saveFileDialog1.FileName, string.Join("-", " ", textBox3));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
