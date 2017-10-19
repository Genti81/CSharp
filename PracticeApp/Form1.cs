using System;
using System.IO;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var personNamn = textBox1.Text;
            var newDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var telMob = textBox2.Text;

            var fullInfo = $"{personNamn};{newDate};{telMob}";

            saveFileDialog1.ShowDialog();

            File.WriteAllText(saveFileDialog1.FileName, fullInfo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var content = File.ReadAllText(openFileDialog1.FileName);

            string[] splitContent = content.Split(';');

            var name = splitContent[0];
            var years = DateTime.Now.Year - dateTimePicker1.Value.Year;
            var mobil = splitContent[2];

            var fullInfo = $"{name} är {years} är gammal och har ett telefonnummer {mobil}";

            saveFileDialog2.ShowDialog();
            File.WriteAllText(saveFileDialog2.FileName, fullInfo);
        }
    }
}
