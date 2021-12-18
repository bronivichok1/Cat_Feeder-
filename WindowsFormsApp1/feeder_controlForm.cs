using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class feeder_controlForm : Form
    {
        public feeder_controlForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            feeder_seting feeder_seting = new feeder_seting();
            feeder_seting.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            User_Form fedS = new User_Form();
            fedS.Show();
            this.Hide();
        }
    }
}
