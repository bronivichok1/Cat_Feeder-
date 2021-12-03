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
    public partial class feeder_seting : Form
    {
        public feeder_seting()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMetka formMetka = new FormMetka();
            formMetka.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Create_Schedule_Form Create_Schedule_Form = new Create_Schedule_Form();
            Create_Schedule_Form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            feeder_controlForm feeder_cF = new feeder_controlForm();
            feeder_cF.Show();
            this.Hide();
        }
    }
}
