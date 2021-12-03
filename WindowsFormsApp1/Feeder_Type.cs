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
    public partial class Feeder_Type : Form
    {
        public Feeder_Type()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox chbx = sender as CheckBox;
            chbx.Checked = !chbx.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                FileStream file1 = new FileStream("name_feeder_for_type.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);

                string line;
                line = reader.ReadLine();
                string[] splitLine = line.Split(' ');
                string loginTXT = splitLine[0];
                reader.Close();
                File.WriteAllText("FiderName\\Korm1.txt", "");
                FileStream file2 = new FileStream("FiderName\\Korm1.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine(loginTXT + " ");
                writer2.WriteLine("\n" + "el");
                writer2.Close();
                File.AppendAllText("FileINFO.txt", "\n" + "Задан тип кормушки"+loginTXT+"el");

                MessageBox.Show("Тип кормушки установлен! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();

            }

            if (checkBox2.Checked)
            {
                FileStream file1 = new FileStream("name_feeder_for_type.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);

                string line;
                line = reader.ReadLine();
                string[] splitLine = line.Split(' ');
                string loginTXT = splitLine[0];
                reader.Close();
                File.WriteAllText("FiderName\\Korm1.txt", "");
                FileStream file2 = new FileStream("FiderName\\Korm1.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine(loginTXT + " ");
                writer2.WriteLine("\n" + "mex");
                writer2.Close();
                File.AppendAllText("FileINFO.txt", "\n" + "Задан тип кормушки" + loginTXT + "mex");


                MessageBox.Show("Тип кормушки установлен! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feeder_seting fedset = new feeder_seting();
            fedset.Show();
            this.Hide();
        }
    }
}
