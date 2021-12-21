using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Check_status : Form
    {
        public Check_status()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adminForm adF = new adminForm();
            adF.Show();
            Hide();
        }
    }
}
