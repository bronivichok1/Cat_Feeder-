using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private AdminLoginForm lgnForm;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            AdminLoginForm lgnForm = new AdminLoginForm(this);
            
            string login = "admin";
            if (textBox2.Text == login)
            {
                lgnForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Не верный логин");
            textBox2.Text = "";

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login;
            bool T = true;
            login = textBox1.Text + "  ";
            FileStream file1 = new FileStream("log_file.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file1);
            string line;

            while (((line = reader.ReadLine()) != null))
            {

                string[] splitLine = line.Split(' ');


                string loginTXT = splitLine[0] + " ";

                if (login != loginTXT)
                {

                    T = true;

                }
                else
                {

                    T = false;

                    break;
                }

            }

            if (T == false)
            {
                reader.Close();
                MessageBox.Show("Такого пользователя нет ");
                textBox1.Text = "";
            }
            else
            {
                
               
                reader.Close();
                UserLoginForm User_Login_Form = new UserLoginForm();
                User_Login_Form.Show();
                this.Hide();

            }
        }

          


            

    }
            
            
        }


 
