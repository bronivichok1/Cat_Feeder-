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
            login=textBox1.Text+" ";
            FileStream file1 = new FileStream("log_file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string loginTXT=
            if (login=)


            
            File.AppendAllText("log_file.txt",login);
          
        }

       
    }
}
