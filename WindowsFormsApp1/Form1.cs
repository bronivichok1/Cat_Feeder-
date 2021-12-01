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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private AdminLoginForm lgnForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLoginForm User_Login_Form = new UserLoginForm();


            User_Login_Form.Show();
            this.Hide();
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
    }
}
