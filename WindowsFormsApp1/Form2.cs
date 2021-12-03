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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form User_form = new User_Form();
            User_form.Show();
            this.Hide();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int  ncheck;
            CheckBox checkBox = (CheckBox)sender; 
            if (checkBox.Checked == true)
            {
                ncheck=1;
            }
            else
            {
                ncheck = 0;
            }
            int j = 0;
            int k = 0;
            int d = 0;
            while (ncheck!=0)
            {
                
                if (d<7)
                {
                    d++;
                    if (j<25) 
                    {
                        j++;
                        string s2 = j.ToString();
                        File.AppendAllText("shet.txt", s2);
                        if (k<6) 
                        {
                            k++;
                            
                                
                              
                                string s1 = k.ToString();
                                File.AppendAllText("shet.txt", s1);
                            
                        }
                    
                    }
                }
            }
            

            
        }
        

        
    }
}
