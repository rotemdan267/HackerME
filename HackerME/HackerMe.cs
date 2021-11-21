using HackerMeDB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerME
{
    public partial class HackerMe : Form
    {
        public HackerMe()
        {
            InitializeComponent();
        }
        public void SwitchUserControl(UserControl userControl)
        {
            HackerMe.panel1.Controls.Clear();
            HackerMe.panel1.Controls.Add(userControl);
        }

        private void HackerMe_Load(object sender, EventArgs e)
        {
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            HackerMe.panel1.Controls.Clear();
            HackerMe.panel1.Controls.Add(newStudent);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            HackerMe.panel1.Controls.Clear();
            HackerMe.panel1.Controls.Add(editStudent);
        }



        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        public void SearchResults(int id)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsListTable studentsListTable = new StudentsListTable();
            HackerMe.panel1.Controls.Clear();
            HackerMe.panel1.Controls.Add(studentsListTable);
        }
    }
}
