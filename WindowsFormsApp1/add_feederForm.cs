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
    public partial class add_feederForm : Form
    {
        public add_feederForm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string feeder;
            bool T = false;
            feeder = textBox1.Text + " ";
            FileStream file1 = new FileStream("feeder_file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string line;
            if (((line = reader.ReadLine()) != null) || (T != true))
            {

                {
                    string[] splitLine = line.Split(' ');

                    string loginTXT = splitLine[0] + " ";
                    if (feeder != loginTXT)
                    {

                        MessageBox.Show("Кормушка успешно создана ");

                        T = true;


                    }
                    else
                    {
                        MessageBox.Show("Такая кормушка уже есть");
                        textBox1.Text = "";
                        T = false;
                    }
                }
            }

            if (T == true)
            {
                reader.Close();
                File.AppendAllText("feeder_file.txt", feeder);
                adminForm AdminForm = new adminForm();
                AdminForm.Show();
                this.Hide();


            }
        }


    }
}