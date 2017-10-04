using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintOutMessApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var prefix = " ";
            var fitstName = textBox1.Text;
            var lastName = textBox2.Text;
            var personID = textBox3.Text;
            personID.Substring(11, 1);
            var nummer = Int64.Parse(personID);

            var modulo = nummer % 2;

            if (modulo == 0)
            {
                prefix = "Fröken";
            }
            else if(modulo == 1)
            {
                prefix = "Herr";
            } 

            label4.Text = $"Hej {prefix} {lastName}";
        }
    }
}
