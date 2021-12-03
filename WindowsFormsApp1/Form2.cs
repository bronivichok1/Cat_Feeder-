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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       bool N = true;
        int j = 0;
        int d = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form User_form = new User_Form();
            User_form.Show();
            this.Hide();
        }


        
        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("restart");
            int Nos = 0;
            Nos++;
            if (Nos==1)
            {
                j = 0;
                d = 0;
                Nos=0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            for (int i = 0; i == 1; i++)
            {

                for (int j1 = 0; j1 < 7; j1++)
                {
                    j++;

                    for (int d1 = 0; d1 < 4 && j == 6; d1++)
                    {
                        d++;

                        if (j == 6)
                        {
                            j = 0;
                        }
                        if (d == 4)
                        {
                            d = 0;
                        }

                    }

                }

            }
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            int k1 = d;
            string s1 = k1.ToString();
           
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
            s1
        };

            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int k2 = j * 4;
            string s2 = k2.ToString();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
            s2
        };

            textBox2.AutoCompleteCustomSource = source;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
