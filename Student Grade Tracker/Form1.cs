using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            
            string student = txtStudent.Text.Trim();
            string gradeText = txtGrade.Text.Trim();

            if (string.IsNullOrWhiteSpace(student))
            {
                MessageBox.Show("Student name cannot be empty.");
                return;
            }
            if (!int.TryParse(gradeText, out int grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("Grade must be a number between 0 and 100.");
                return;
            }
            lstGrades.Items.Add($"{student} - {grade}");
            txtStudent.Clear();
            txtGrade.Clear();           

        }
    }
}
