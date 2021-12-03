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
            File.AppendAllText("FileINFO.txt", "\n" + "Началась симуляция 4 часов" );


            for (int i = 0; i == 4; i++)
            {

                for (int j1 = 0; j1 < 25; j1++)
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
                string k1 = d.ToString();
                string k2 = j.ToString();
                File.WriteAllText("data.txt", "\n" + k1 + "day" + "\n" + k2 + "hours");
            }
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

           
        }
    }
}
