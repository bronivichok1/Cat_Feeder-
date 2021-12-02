using System;
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
    public partial class Create_userForm : Form
    {
        public Create_userForm()
        {
            InitializeComponent();
        }

        private void Create_userForm_Load(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            string login;
            bool T = false;
            login = textBox1.Text + " ";
            FileStream file1 = new FileStream("log_file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string line;
            if (((line = reader.ReadLine()) != null) || (T != true))
            {


                {
                    string[] splitLine = line.Split(' ');

                    string loginTXT = splitLine[0] + " ";
                    if (login != loginTXT)
                    {

                        MessageBox.Show("Пользователь успешно создан");

                        T = true;


                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже существует");
                        textBox1.Text = "";
                        T = false;
                    }
                }

            }
            if (T == true)
            {
                reader.Close();
                FileStream file2 = new FileStream("log_file.txt", FileMode.Open);
                StreamWriter writer = new StreamWriter(file2);
                writer.WriteLine(login);
                writer.Close();
                adminForm AdminForm = new adminForm();
                AdminForm.Show();
                this.Hide();


            }





        }


    }
}


