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
            string student = txtStudent.Text;
            string grade = txtGrade.Text; lstGrades.Items.Add(student + " - " + grade);
            txtStudent.Clear();
            txtGrade.Clear();
        }
    }
}
