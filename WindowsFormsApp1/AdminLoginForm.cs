using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminLoginForm : Form
    {
        private Form1 previousForm;
        public AdminLoginForm(Form1 prevform)
        {
            previousForm = prevform;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm AdminForm = new adminForm();
            string pass = "catfeeder";
            if (textBox2.Text == pass)
            {
                AdminForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Не верный пароль");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
