using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWindowsApp
{
    public partial class Form1 : Form
    {
        Exam nyExam = new Exam("");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var student = new Student(txtStudent.Text);
            nyExam.Assign(student);
            cbStudents.Items.Add(student);
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
           var student = (Student)cbStudents.SelectedItem;
           nyExam.Grade(student, cmbGrade.SelectedItem.ToString());
        }

        private void txtGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var gradeCountDictionary = nyExam.GenerateStatistics();

            var IGlabel = gradeCountDictionary["IG"];
            lbIG.Text = $"IG: {IGlabel}";

            var Glabel = gradeCountDictionary["G"];
            lbG.Text = $"IG: {Glabel}";

            var VGlabel = gradeCountDictionary["VG"];
            lbVG.Text = $"VG: {VGlabel}";
        }

    }
    }

