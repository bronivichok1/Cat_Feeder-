using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Feed_Type : Form
    {
        public Feed_Type()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

                string loginTXT = null;
                string feederT = null;

                while (((line = reader.ReadLine()) != null))
                {
                    string[] splitLine = line.Split(' ');


                    loginTXT = splitLine[0] + " ";

                }

                reader.Close();
                File.WriteAllText("FiderName\\Korm1.txt", "");
                FileStream file2 = new FileStream("FiderName\\Korm1.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine(loginTXT + " ");
                writer2.WriteLine(feederT + " ");
                writer2.WriteLine("suhoy");
                writer2.Close();


                MessageBox.Show("Тип корма выбран! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                Hide();
            }

            if (checkBox2.Checked)
            {
                FileStream file1 = new FileStream("name_feeder_for_type.txt", FileMode.Open);
                StreamReader reader = new StreamReader(file1);

                string line;
                line = reader.ReadLine();

                string loginTXT = null;
                string feederT = null;

                while (((line = reader.ReadLine()) != null))
                {
                    string[] splitLine = line.Split(' ');
                    loginTXT = splitLine[0];
                    feederT = splitLine[1];
                }

                reader.Close();
                File.WriteAllText("FiderName\\Korm1.txt", "");
                FileStream file2 = new FileStream("FiderName\\Korm1.txt", FileMode.Create);
                StreamWriter writer2 = new StreamWriter(file2);
                writer2.WriteLine("\n" + loginTXT + " ");
                writer2.WriteLine("\n" + feederT + " ");
                writer2.WriteLine("zhidkiy");
                writer2.Close();


                MessageBox.Show("Тип корма выбран! ");
                feeder_seting feeder_Seting = new feeder_seting();
                feeder_Seting.Show();
                Hide();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            feeder_seting fedSet = new feeder_seting();
            fedSet.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
