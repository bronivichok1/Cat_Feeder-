﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Create_Schedule_Form : Form
    {
        public Create_Schedule_Form()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Schedule;
            
            Schedule = textBox1.Text + " ";
            FileStream file1 = new FileStream("Schedule_file.txt", FileMode.Open);
            StreamWriter writer = new StreamWriter(file1);
            writer.WriteLine(Schedule);
            writer.Close();
        }
    }
}