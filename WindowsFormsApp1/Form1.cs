using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using static System.Data.CommandType;
using static WindowsFormsApp1.Data.Repository;

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
                Hide();
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
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool T = true;
            var login = textBox1.Text;
            FileStream file1 = new FileStream("log_file.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file1);
            string line;

            while ((line = reader.ReadLine()) != null)
            {

                string[] splitLine = line.Split(' ');


                string loginTXT = splitLine[0];

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

            if (T)
            {
                reader.Close();
                MessageBox.Show("Такого пользователя нет ");
                textBox1.Text = "";
               
            }
            else
            {


                reader.Close();
                File.WriteAllText("UserAKT.txt", "");
                FileStream file2 = new FileStream("UserAKT.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine(login);
                writer2.Close();
                UserLoginForm User_Login_Form = new UserLoginForm();
                User_Login_Form.Show();
                Hide();

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}



