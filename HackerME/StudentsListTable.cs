﻿using HackerMeDB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerME
{
    public partial class StudentsListTable : UserControl
    {
        public StudentsListTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsListTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.Students.Students;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
