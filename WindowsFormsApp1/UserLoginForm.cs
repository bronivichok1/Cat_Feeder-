﻿using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string feeder;
            bool T = true;
            feeder = textBox1.Text ;
            FileStream file1 = new FileStream("feeder_file.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file1);
            string line;

            while (((line = reader.ReadLine()) != null))
            {

                string[] splitLine = line.Split(' ');


                string loginTXT = splitLine[0];

                if (feeder != loginTXT)
                {

                    T = true;

                }
                else
                {

                    T = false;

                    break;
                }

            }

            if (T == true)
            {
                MessageBox.Show("Такой кормушки нет");
                textBox1.Text = "";
                reader.Close();
            }
            else
            {
                MessageBox.Show("Успешный вход ");
                File.WriteAllText("name_feeder_for_type.txt", feeder);
                User_Form User_Form = new User_Form();
                User_Form.Show();
                
                this.Hide();
                File.AppendAllText("FileINFO.txt", "\n" + "Пользователь вошёл в кормушку" + feeder);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
